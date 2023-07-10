using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRepsol
{
    public partial class EditLogistica : Form
    {
        SqlConnection conn;
        string userDB;
        private readonly IConfiguration _configuration;
        int Id;

        public EditLogistica(int IdCase, string dbUser, SqlConnection _conn)
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddJsonFile("sysconfig.json", optional: false, reloadOnChange: true).Build();
            Id = IdCase;
            userDB = dbUser;
            conn = _conn;
            GetDataCase(IdCase);
        }

        void GetDataCase(int IdCase)
        {
            //dbQuery.ScrollBars = (ScrollBars)(RichTextBoxScrollBars)ScrollBars.Vertical;
            dbXML.ScrollBars = RichTextBoxScrollBars.Vertical | RichTextBoxScrollBars.Horizontal;
            this.Controls.Add(dbQuery);
            this.Controls.Add(dbXML);
            var query = String.Format("SELECT LO.NOMBRE_PROCEDIMIENTO, LO.CONSULTA_SEL, LO.TEMP_TABLE, LO.TEMP_TABLE_STRUC, LO.XML_ORIGIN FROM LOGISTICA_SCRIPTS AS LO WHERE ID={0}", IdCase);
            SqlCommand cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dbDetalle.Text = reader["NOMBRE_PROCEDIMIENTO"].ToString();
                dbURL.Text = reader["XML_ORIGIN"].ToString();
                dbTablaTemporal.Text = reader["TEMP_TABLE"].ToString();
                dbXML.Text = reader["TEMP_TABLE_STRUC"].ToString();
                dbQuery.Text = reader["CONSULTA_SEL"].ToString();
            }
            reader.Close();
        }

        public bool ValidateForm()
        {
            bool isCompleted = true;
            if (String.IsNullOrEmpty(dbDetalle.Text))
                isCompleted = false;
            else if (String.IsNullOrEmpty(dbURL.Text))
                isCompleted = false;
            else if (String.IsNullOrEmpty(dbXML.Text))
                isCompleted = false;
            else if (String.IsNullOrEmpty(dbTablaTemporal.Text))
                isCompleted = false;
            else if (String.IsNullOrEmpty(dbQuery.Text))
                isCompleted = false;

            //TODO: Comprobar que todos los campos están rellenos y encaso de no estar almenos 1, poner el flag a FALSE

            return isCompleted;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //TODO: Aquí va el código para guardar la edición del registro.
                string query = String.Format("UPDATE LOGISTICA_SCRIPTS SET NOMBRE_PROCEDIMIENTO = @nombre, CONSULTA_SEL = @consulta, TEMP_TABLE = @tabla, TEMP_TABLE_STRUC = @struc, XML_ORIGIN = @xml WHERE ID = {0}", Id);
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre", dbDetalle.Text);
                cmd.Parameters.AddWithValue("@tabla", dbURL.Text);
                cmd.Parameters.AddWithValue("@struc", dbXML.Text);
                cmd.Parameters.AddWithValue("@xml", dbTablaTemporal.Text);
                cmd.Parameters.AddWithValue("@consulta", dbQuery.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El registro ha sido actualizado correctamente");

                    var app = new App(userDB, conn);
                    app.Show();
                    this.Dispose(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
                MessageBox.Show("Debes rellenar todos los campos");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var app = new App(userDB, conn);
            app.Show();
            this.Dispose(true);
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
