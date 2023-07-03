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
        string connetionString;
        List<string> Querys = new List<string>();
        int progressCompleted = 0;
        int maximumProgress = 100;
        SqlConnection cnn;
        private readonly IConfiguration _configuration;

        public Installer()
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddJsonFile("sysconfig.json", optional: false, reloadOnChange: true).Build();
            iprogress.Maximum = maximumProgress;
            GetDBData();
            InstallDBComponents();

        }

        public async Task GetDBData() {
            try
            {
                string fileQuerys = @"./Installer/db_install.txt";
                using (var streamReader = File.OpenText(fileQuerys))
                {
                    var lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in lines)
                    {
                        if (line != "" && !line.Contains("*/"))
                            Querys.Add(line);
                    }
                }
                progressCompleted = 100 - Querys.Count;
                iprogress.Value = progressCompleted;
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

            try { 
                cnn.Open();
                int totalPendiente = maximumProgress - progressCompleted;
                int avancePorQuery = Querys.Count / totalPendiente;

                foreach (var Query in Querys)
                {
                    SqlCommand cmd = new SqlCommand(Query, cnn);
                    cmd.ExecuteNonQuery();
                    progressCompleted = progressCompleted + avancePorQuery;
                    iprogress.Value = progressCompleted;
                }
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se han producido errores al intentar conectar a la base de datos.\r\n\r\n" + ex.Message);
            }
        }
    }
}
