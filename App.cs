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
        private readonly IConfiguration _configuration;

        public App(string dbUser, SqlConnection _conn)
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddJsonFile("sysconfig.json", optional: false, reloadOnChange: true).Build();
            lblUserName.Text = dbUser;
            lblServer.Text = _configuration.GetSection("dbServer").Value;
            lblCatalog.Text = _configuration.GetSection("dbDataBase").Value;
            conn = _conn;
            ChargeData();
        }

        private void PrepareDataGridView()
        {
            dbData.Columns.Add("Id", "Id");
            dbData.Columns.Add("Regulariza", "Regulariza");
            dbData.Columns.Add("Detalle", "Detalle");
            dbData.Columns.Add("Detalle", "Activo");

            dbData.Columns[0].Width = (int)(dbData.Width * 0.1);
            dbData.Columns[1].Width = (int)(dbData.Width * 0.2);
            dbData.Columns[2].Width = (int)(dbData.Width * 0.6);
            dbData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dbData.Columns[3].Width = (int)(dbData.Width * 0.1);
        }

        public void ChargeData()
        {
            PrepareDataGridView();
            var query = "SELECT OS.ID, TV.Vertical, OS.NOMBRE_PROCEDIMIENTO, OS.REGULARIZA FROM TR_QUERY_VERTICAL QV INNER JOIN TR_VERTICAL TV ON TV.Id=QV.IdVertical INNER JOIN TR_OPTIMIZACION_AUTO_SCRIPT OS ON OS.ID = QV.IdQuery";
            SqlCommand command = new SqlCommand(query, conn);
            var data = command.ExecuteReader();
            while(data.Read())
            {
                dbData.Rows.Add(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetBoolean(3));
            }
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

            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

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
            string IdRegistro = dbData.Rows[idRowSelected].Cells[0].Value.ToString();
            var editForm = new Edit(System.Convert.ToInt32(IdRegistro), conn);
            editForm.Show();
        }

        private void openCreateForm(object sender, EventArgs e)
        {
            var createForm = new Create(conn);
            createForm.Show();
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
            bool active = (bool)dbData.SelectedCells[3].Value;


            if (!active)
            {
                var confirmDelete = MessageBox.Show("¿Está seguro de querer eliminar el registro seleccionado?", "Borrado de Registros", MessageBoxButtons.YesNo);
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
                        MessageBox.Show("El registro ha sido eliminado correctamente.", "Borrado de Registros");
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
                MessageBox.Show("El registro no se puede eliminar ya que está en estado activo");
        }
    }
}
