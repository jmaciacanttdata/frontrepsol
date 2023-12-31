﻿using Microsoft.Extensions.Configuration;
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
    public partial class CreateLogistica : Form
    {
        SqlConnection conn;
        string userDB;
        string passDB;
        private readonly IConfiguration _configuration;
        public CreateLogistica(string dbUser, SqlConnection _conn)
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddJsonFile("sysconfig.json", optional: false, reloadOnChange: true).Build();
            passDB = _configuration.GetSection("dbEmergenciasPassword").Value;
            conn = _conn;
            userDB = dbUser;
            lblServer.Text = _configuration.GetSection("dbServer").Value;
            lblCatalog.Text = _configuration.GetSection("dbDataBase").Value;
            lblUserName.Text = userDB;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            var app = new App(userDB, conn);
            app.Show();
            this.Dispose(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var query = "insert into LOGISTICA_SCRIPTS (NOMBRE_PROCEDIMIENTO, CONSULTA_SEL, TEMP_TABLE, TEMP_TABLE_STRUC, XML_ORIGIN, XML_ORIGIN_USER, XML_ORIGIN_PASS) VALUES(@detalle, @consulta, @tablaTemporal, @xml, @url, @user, @pass)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@detalle", dbDetalle.Text);
                cmd.Parameters.AddWithValue("@consulta", dbQuery.Text);
                cmd.Parameters.AddWithValue("@tablaTemporal", dbTablaTemporal.Text);
                cmd.Parameters.AddWithValue("@xml", dbXML.Text);
                cmd.Parameters.AddWithValue("@url", dbURL.Text);
                cmd.Parameters.AddWithValue("@user", userDB);
                cmd.Parameters.AddWithValue("@pass", passDB);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se ha guardado la consulta correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                var app = new App(userDB, conn);
                app.Show();
                this.Dispose(true);
            }
            else
                MessageBox.Show("Debes rellenar todos los campos");
        }
        public bool ValidateForm()
        {
            bool isCompleted = true;
            if (String.IsNullOrEmpty(dbDetalle.Text))
                isCompleted = false;
            else if (String.IsNullOrEmpty(dbTablaTemporal.Text))
                isCompleted = false;
            else if (String.IsNullOrEmpty(dbURL.Text))
                isCompleted = false;
            else if (String.IsNullOrEmpty(dbXML.Text))
                isCompleted = false;
            else if (String.IsNullOrEmpty(dbQuery.Text))
                isCompleted = false;

            //TODO: Comprobar que todos los campos están rellenos y encaso de no estar almenos 1, poner el flag a FALSE

            return isCompleted;
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
    }
}
