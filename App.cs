using AutoRepsol.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AutoRepsol
{
    public partial class App : Form
    {
        string caseId = null;
        string caseName = null;
        SqlConnection conn;
        string userDB;
        bool iniciate = false;
        private readonly IConfiguration _configuration;

        public App(string dbUser, SqlConnection _conn)
        {
            InitializeComponent();
            dbData.ReadOnly = true;
            _configuration = new ConfigurationBuilder().AddJsonFile("sysconfig.json", optional: false, reloadOnChange: true).Build();
            lblUserName.Text = dbUser;
            userDB = dbUser;
            lblServer.Text = _configuration.GetSection("dbServer").Value;
            lblCatalog.Text = _configuration.GetSection("dbDataBase").Value;
            conn = _conn;
            GetDataSourceVertical(conn);
            ChargeData();
            cmbVertical.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void RefreshData(object sender, EventArgs e)
        {
            dbData.Rows.Clear();
            dbData.Columns.Clear();
            ChargeData();
        }

        private void PrepareDataGridView()
        {

            dbData.Columns.Add("Id", "Id");
            dbData.Columns.Add("Detalle", "Detalle");
            dbData.Columns.Add("Consulta", "Consulta");
            dbData.Columns.Add("Vertical", "Vertical");

            dbData.Columns[0].Width = (int)(dbData.Width * 0.1);
            dbData.Columns[1].Width = (int)(dbData.Width * 0.25);
            dbData.Columns[2].Width = (int)(dbData.Width * 0.45);
            dbData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dbData.Columns[3].Width = (int)(dbData.Width * 0.2);
        }

        public void GetDataSourceVertical(SqlConnection conn)
        {
            string query = "SELECT Id, Vertical FROM TR_VERTICAL ORDER BY Id ASC;";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                List<IdValue> ItemsVertical = new List<IdValue>();
                while (reader.Read())
                {
                    IdValue item = new IdValue();
                    if (ItemsVertical.Count == 0)
                    {
                        item.Id = System.Convert.ToInt32(0);
                        item.Value = "Todos".ToString();
                        ItemsVertical.Add(item);
                        item = new IdValue();
                    }
                    item.Id = System.Convert.ToInt32(reader["Id"]);
                    item.Value = reader["Vertical"].ToString();
                    ItemsVertical.Add(item);
                }
                reader.Close();
                cmbVertical.DataSource = ItemsVertical;
                cmbVertical.DisplayMember = "Value";
                cmbVertical.ValueMember = "Id";

            };
        }

        public void ChargeData(string txtSearch = null)
        {
            PrepareDataGridView();
            var query = "";
            var querylog = "";
            string whereConditionOS = " WHERE 1=1";
            string whereConditionLO = " WHERE 1=1";

            if (txtSearch != null && txtSearch != "")
            {
                whereConditionOS += " AND OS.CONSULTA_SEL LIKE '%" + txtSearch + "%'";
                whereConditionLO += " AND LO.CONSULTA_SEL LIKE '%" + txtSearch + "%'";
            }

            if (cmbVertical.SelectedIndex == 0)
            {
                query = "SELECT OS.ID, OS.NOMBRE_PROCEDIMIENTO, OS.CONSULTA_SEL, TV.Vertical FROM TR_QUERY_VERTICAL QV INNER JOIN TR_VERTICAL TV ON TV.Id=QV.IdVertical INNER JOIN TR_OPTIMIZACION_AUTO_SCRIPT OS ON OS.ID = QV.IdQuery INNER JOIN TR_OPTIMIZACION_AUTO_TIPO_SCRIPT OTS ON OTS.ID = OS.ID_TIPO_SCRIPT" + whereConditionOS;
                querylog = "SELECT LO.ID, LO.NOMBRE_PROCEDIMIENTO, LO.CONSULTA_SEL FROM LOGISTICA_SCRIPTS AS LO" + whereConditionLO;
            }
            else if (cmbVertical.SelectedIndex == 5)
            {
                query = "SELECT LO.ID, LO.NOMBRE_PROCEDIMIENTO, LO.CONSULTA_SEL FROM LOGISTICA_SCRIPTS AS LO" + whereConditionLO;
            }
            else
            {
                var vertical = cmbVertical.Text;
                query = String.Format("SELECT OS.ID, OS.NOMBRE_PROCEDIMIENTO, OS.CONSULTA_SEL, TV.Vertical FROM TR_QUERY_VERTICAL QV INNER JOIN TR_VERTICAL TV ON TV.Id=QV.IdVertical INNER JOIN TR_OPTIMIZACION_AUTO_SCRIPT OS ON OS.ID = QV.IdQuery INNER JOIN TR_OPTIMIZACION_AUTO_TIPO_SCRIPT OTS ON OTS.ID = OS.ID_TIPO_SCRIPT " + whereConditionOS + " AND TV.Vertical LIKE '{0}'", vertical);
            }

            SqlCommand command = new SqlCommand(query, conn);
            var data = command.ExecuteReader();
            while (data.Read())
            {
                if (cmbVertical.SelectedIndex != 5)
                {
                    dbData.Rows.Add(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetString(3));
                }
                else
                {
                    dbData.Rows.Add(data.GetInt32(0), data.GetString(1), data.GetString(2), "LO - Logistica");
                }
            }
            data.Close();

            if (cmbVertical.SelectedIndex == 0)
            {
                command = new SqlCommand(querylog, conn);
                data = command.ExecuteReader();
                while (data.Read())
                {
                    dbData.Rows.Add(data.GetInt32(0), data.GetString(1), data.GetString(2), "LO - Logistica");
                }
                data.Close();
            }


            iniciate = true;
        }

        private void CLoseApp(object sender, FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            }
            else
            {
                conn.Close();
                Environment.Exit(0);
            }
        }

        public static bool CloseCancel()
        {
            const string message = "¿Está seguro de querer cerrar la aplicación?";
            const string caption = "AutoRepsol";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private bool CloseSession()
        {
            string message = "";

            if (lblUserName.Text != null)
                message = "¿Está seguro de querer cerrar la sesión del usuario " + lblUserName.Text + "?";
            else
                message = "¿Está seguro de querer cerrar la sesión del usuario?";
            string caption = "AutoRepsol";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private void CloseSession(object sender, EventArgs e)
        {
            if (CloseSession() == true)
            {
                conn.Close();
                var login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void GetItemData(object sender, DataGridViewCellEventArgs e)
        {

            int idRowSelected = e.RowIndex;
            try
            {
                string IdRegistro = dbData.Rows[idRowSelected].Cells[0].Value.ToString();
                string Vertical = dbData.Rows[idRowSelected].Cells[3].Value.ToString();
                try
                {
                    if (Vertical == "LO - Logistica")
                    {
                        var editLogis = new EditLogistica(System.Convert.ToInt32(IdRegistro), userDB, conn);
                        editLogis.FormClosed += new FormClosedEventHandler(RefreshData);
                        editLogis.Show();
                        this.Dispose();
                    }
                    else
                    {
                        var editForm = new Edit(System.Convert.ToInt32(IdRegistro), userDB, conn);
                        editForm.FormClosed += new FormClosedEventHandler(RefreshData);
                        editForm.Show();
                        this.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro no válido");
            }
        }

        private void openCreateForm(object sender, EventArgs e)
        {
            var createForm = new Create(userDB, conn);
            createForm.Show();
            this.Dispose();
        }

        private void enableDisableDelete(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dbData.SelectedCells.Count > 0)
            {
                int selectedrowindex = dbData.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dbData.Rows[selectedrowindex];
                caseId = Convert.ToString(selectedRow.Cells["Id"].Value);
                caseName = Convert.ToString(selectedRow.Cells["Detalle"].Value);
                btnDelete.Enabled = true;
            }
            else
            {
                caseId = null;
                caseName = null;
                btnDelete.Enabled = false;
            }
        }

        private void deleteCase(object sender, EventArgs e)
        {
            try
            {
                var confirmDelete = MessageBox.Show("¿Está seguro de querer eliminar la consulta seleccionada?", "Borrado de Consultas", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    int selectedId = (int)dbData.SelectedCells[0].Value;
                    string Vertical = (string)dbData.SelectedCells[3].Value;

                    if (Vertical != "LO - Logistica")
                    {
                        //TODO: Lanzar la query para eliminar el registro con id=caseId
                        var query = "delete from TR_OPTIMIZACION_AUTO_SCRIPT where ID = @Id";
                        var queryVertical = "DELETE FROM TR_QUERY_VERTICAL WHERE IdQuery = @Id";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlCommand cmdVertical = new SqlCommand(queryVertical, conn);

                        cmd.Parameters.AddWithValue("@Id", selectedId);
                        cmdVertical.Parameters.AddWithValue("Id", selectedId);
                        try
                        {
                            cmd.ExecuteNonQuery();
                            cmdVertical.ExecuteNonQuery();
                            MessageBox.Show("La consulta ha sido eliminada correctamente.", "Borrado de Consultas.");
                            RefreshData(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        var query = "DELETE FROM LOGISTICA_SCRIPTS WHERE ID = @id";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedId);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("La consulta ha sido eliminada correctamente.", "Borrado de consultas.");
                            RefreshData(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
            catch (Exception ex)
            { MessageBox.Show("Consulta no válida"); }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (iniciate)
            {
                RefreshData(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var createForm = new CreateLogistica(userDB, conn);
            createForm.Show();
            this.Dispose();
        }

        private void searchItem(object sender, KeyEventArgs e)
        {
        }

        private void SearchItem(object sender, EventArgs e)
        {
            dbData.ClearSelection();
            string txtSearch = txtBuscar.Text;
            dbData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (txtSearch != "")
            {
                try
                {
                    bool valueResult = false;
                    foreach (DataGridViewRow r in dbData.Rows)
                    {
                        for (int i = 0; i < r.Cells.Count; i++)
                        {
                            if (r.Cells[i].Value != null && r.Cells[i].Value.ToString().Contains(txtSearch))
                            {
                                int rowIndex = r.Index;
                                dbData.Rows[rowIndex].Selected = true;
                                valueResult = true;
                                break;
                            }
                        }
                    }

                    if (!valueResult)
                    {
                        MessageBox.Show("No se encontraron registros que contengan el literal: " + txtSearch, "Not Found");
                        return;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                dbData.ClearSelection();
            }
        }
    }
}
