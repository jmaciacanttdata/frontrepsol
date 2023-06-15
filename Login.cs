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
    public partial class Login : Form
    {
        string connetionString;
        SqlConnection cnn;
        private readonly IConfiguration _configuration;

        public Login()
        {
            InitializeComponent();
            lblClose.BackColor = System.Drawing.Color.Transparent;
            lblUser.BackColor = System.Drawing.Color.Transparent;
            lblPassword.BackColor = System.Drawing.Color.Transparent;
            _configuration = new ConfigurationBuilder().AddJsonFile("sysconfig.json", optional: false, reloadOnChange: true).Build();
        }

        private void CloseApp(object sender, EventArgs e)
        {
            cnn.Close();
            Application.Exit();
        }

        private void LoginDB(object sender, EventArgs e)
        {
            dbConnectionResult.Visible = false;
            string dbUserName = dbUser.Text;
            string dbUserPass = dbPassword.Text;

            string dbServer = _configuration.GetSection("dbServer").Value;
            string dbDataBase = _configuration.GetSection("dbDataBase").Value;
            connetionString = String.Format(_configuration.GetSection("dbConnection").Value, dbServer, dbDataBase, dbUserName, dbUserPass);
            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                var app = new App(dbUserName, cnn);
                app.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                dbConnectionResult.Text = "Las credenciales son erróneas";
                dbConnectionResult.Visible = true;
            }
        }
    }
}
