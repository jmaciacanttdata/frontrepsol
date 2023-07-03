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
            _configuration = new ConfigurationBuilder().AddJsonFile("sysconfig.json", optional: false, reloadOnChange: true).Build();
            lblUserName.Text = dbUser;
            userDB = dbUser;
            lblServer.Text = _configuration.GetSection("dbServer").Value;
            lblCatalog.Text = _configuration.GetSection("dbDataBase").Value;
            conn = _conn;
            GetDataSourceVertical(conn);
            ChargeData();
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
            dbData.Columns.Add("Vertical", "Vertical");
            dbData.Columns.Add("Detalle", "Detalle");
            dbData.Columns.Add("Regulariza", "Regulariza");
            dbData.Columns.Add("Tipo Script", "Tipo Script");

            dbData.Columns[0].Width = (int)(dbData.Width * 0.1);
            dbData.Columns[1].Width = (int)(dbData.Width * 0.2);
            dbData.Columns[2].Width = (int)(dbData.Width * 0.45);
            dbData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dbData.Columns[3].Width = (int)(dbData.Width * 0.1);
            dbData.Columns[4].Width = (int)(dbData.Width * 0.15);
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
                    if(ItemsVertical.Count == 0)
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

        public void ChargeData()
        {
            PrepareDataGridView();
            var query = "";
            if (cmbVertical.SelectedIndex == 0)
            {
                query = "SELECT OS.ID, TV.Vertical, OS.NOMBRE_PROCEDIMIENTO, OS.REGULARIZA, OTS.TIPO FROM TR_QUERY_VERTICAL QV INNER JOIN TR_VERTICAL TV ON TV.Id=QV.IdVertical INNER JOIN TR_OPTIMIZACION_AUTO_SCRIPT OS ON OS.ID = QV.IdQuery INNER JOIN TR_OPTIMIZACION_AUTO_TIPO_SCRIPT OTS ON OTS.ID = OS.ID_TIPO_SCRIPT";
            }
            else
            {
                var vertical = cmbVertical.Text;
                query = String.Format("SELECT OS.ID, TV.Vertical, OS.NOMBRE_PROCEDIMIENTO, OS.REGULARIZA, OTS.TIPO FROM TR_QUERY_VERTICAL QV INNER JOIN TR_VERTICAL TV ON TV.Id=QV.IdVertical INNER JOIN TR_OPTIMIZACION_AUTO_SCRIPT OS ON OS.ID = QV.IdQuery INNER JOIN TR_OPTIMIZACION_AUTO_TIPO_SCRIPT OTS ON OTS.ID = OS.ID_TIPO_SCRIPT WHERE TV.Vertical LIKE '{0}'", vertical);
            }

            SqlCommand command = new SqlCommand(query, conn);
            var data = command.ExecuteReader();
            while (data.Read())
            {
                string validate = "No";
                if (data.GetBoolean(3))
                    validate = "Si";
                dbData.Rows.Add(data.GetInt32(0), data.GetString(1), data.GetString(2), validate, data.GetString(4));
            }
            iniciate = true;
            data.Close();
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
                var editForm = new Edit(System.Convert.ToInt32(IdRegistro), userDB, conn);
                editForm.FormClosed += new FormClosedEventHandler(RefreshData);
                editForm.Show();
                this.Dispose();
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
                bool active = false;
                if (dbData.SelectedCells[3].Value == "Si")
                    active = true;

                if (!active)
                {
                    var confirmDelete = MessageBox.Show("¿Está seguro de querer eliminar la consulta seleccionada?", "Borrado de Consultas", MessageBoxButtons.YesNo);
                    if (confirmDelete == DialogResult.Yes)
                    {
                        //TODO: Lanzar la query para eliminar el registro con id=caseId
                        int selectedId = (int)dbData.SelectedCells[0].Value;
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
                            MessageBox.Show("La consulta ha sido eliminada correctamente.", "Borrado de Consultas");
                            RefreshData(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                        this.Dispose();
                }
                else
                    MessageBox.Show("La consulta no se puede eliminar ya que está en estado activo");
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
    }
}
