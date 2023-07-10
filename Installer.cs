using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRepsol
{
    public partial class Installer : Form
    {
        bool processCompleted = false;
        string connetionString;
        string queryString;
        SqlConnection cnn;
        private readonly IConfiguration _configuration;
        string queryInstall = "";

        public Installer()
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddJsonFile("sysconfig.json", optional: false, reloadOnChange: true).Build();
            GetDBData();
            InstallDBComponents();
        }

        public async Task GetDBData()
        {
            try
            {
                string fileQuerys = @"./Installer/db_install.txt";
                queryString = File.ReadAllText(fileQuerys);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se han producido errores al obtener los datos de configuración.\r\n\r\n" + ex.Message);
            }
        }

        public void InstallDBComponents()
        {
            string dbServer = _configuration.GetSection("dbServer").Value;
            string dbDataBase = _configuration.GetSection("dbDataBase").Value;
            string dbEmergenciasUser = _configuration.GetSection("dbEmergenciasUser").Value;
            string dbEmergenciasPassword = _configuration.GetSection("dbEmergenciasPassword").Value;
            connetionString = String.Format(_configuration.GetSection("dbConnection").Value, dbServer, dbDataBase, dbEmergenciasUser, dbEmergenciasPassword);
            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(queryString, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                processCompleted = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se han producido errores al intentar conectar a la base de datos.\r\n\r\n" + ex.Message);
            }
        }

        private void ValidateProces(object sender, EventArgs e)
        {
            if (processCompleted)
            {
                Thread.Sleep(2000);
                Login uLogin = new Login();
                uLogin.Show();
                this.Hide();
            }
        }
    }
}
