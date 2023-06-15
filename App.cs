using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using System;
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
            dbData.Columns.Add("Vertical", "Vertical");
            dbData.Columns.Add("Detalle", "Detalle");
            dbData.Columns.Add("Detalle", "Activo");

            dbData.Columns[0].Width = (int)(dbData.Width * 0.1);
            dbData.Columns[1].Width = (int)(dbData.Width * 0.2);
            dbData.Columns[2].Width = (int)(dbData.Width * 0.6);
            dbData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dbData.Columns[3].Width = (int)(dbData.Width * 0.1);

        }

        private void ChargeData()
        {
            PrepareDataGridView();
            dbData.Rows.Add("1", "Facturación", "Prueba 1", "Si");
            dbData.Rows.Add("2", "Facturación", "Prueba 2", "No");
            dbData.Rows.Add("3", "Backoffice", "Prueba 3", "Si");
            dbData.Rows.Add("4", "Logística", "Prueba 3", "Si");
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
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

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
            var confirmDelete = MessageBox.Show("¿Está seguro de querer eliminar el registro seleccionado?", "Borrado de Registros", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                //TODO: Lanzar la query para eliminar el registro con id=caseId
                MessageBox.Show("El registro ha sido eliminado correctamente.", "Borrado de Registros");
            }
        }
    }
}
