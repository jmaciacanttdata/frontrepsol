using AutoRepsol.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Linq;

namespace AutoRepsol
{
    public partial class Edit : Form
    {
        SqlConnection conn;
        string userDB;
        private readonly IConfiguration _configuration;

        public Edit(int IdCase, string dbUser, SqlConnection _conn)
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddJsonFile("sysconfig.json", optional: false, reloadOnChange: true).Build();
            dbIdCase.Text = IdCase.ToString();
            userDB = dbUser;
            conn = _conn;
            GetDataSourceVertical(_conn);
            GetDataSourceType(_conn);
            GetDataCase(IdCase);
        }

        public void GetDataSourceType(SqlConnection conn)
        {
            string query = "SELECT ID, TIPO FROM TR_OPTIMIZACION_AUTO_TIPO_SCRIPT ORDER BY ID ASC;";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                List<IdValue> ItemsTypes = new List<IdValue>();
                while (reader.Read())
                {
                    IdValue item = new IdValue();
                    item.Id = System.Convert.ToInt32(reader["ID"]);
                    item.Value = reader["TIPO"].ToString();
                    ItemsTypes.Add(item);
                }
                dbTipo.DataSource = ItemsTypes;
                dbTipo.DisplayMember = "Value";
                dbTipo.ValueMember = "Id";

            };
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
                    item.Id = System.Convert.ToInt32(reader["Id"]);
                    item.Value = reader["Vertical"].ToString();
                    ItemsVertical.Add(item);
                }
                dbVertical.DataSource = ItemsVertical;
                dbVertical.DisplayMember = "Value";
                dbVertical.ValueMember = "Id";

            };
        }

        public void GetDataCase(int IdCase)
        {
            dbQuery.ScrollBars = ScrollBars.Vertical;
            this.Controls.Add(dbQuery);
            var query = String.Format("SELECT OS.ID, TV.Id, TV.Vertical, OTS.TIPO, OS.NOMBRE_PROCEDIMIENTO, OS.REGULARIZA, OS.CONSULTA_SEL FROM TR_QUERY_VERTICAL QV INNER JOIN TR_VERTICAL TV ON TV.Id=QV.IdVertical INNER JOIN TR_OPTIMIZACION_AUTO_SCRIPT OS ON OS.ID = QV.IdQuery INNER JOIN TR_OPTIMIZACION_AUTO_TIPO_SCRIPT OTS ON OTS.ID = OS.ID_TIPO_SCRIPT where QV.IdQuery={0}", IdCase);
            SqlCommand cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dbDetalle.Text = reader["NOMBRE_PROCEDIMIENTO"].ToString();
                dbVertical.SelectedIndex = dbVertical.FindStringExact(reader["Vertical"].ToString());
                dbTipo.SelectedIndex = dbTipo.FindStringExact(reader["TIPO"].ToString());

                if (reader["REGULARIZA"].ToString() == "True")
                    dbRegulariza.Text = "Si";
                else
                    dbRegulariza.Text = "No";

                dbQuery.Text = reader["CONSULTA_SEL"].ToString();
            }
            reader.Close();
        }

        private void closeEditForm(object sender, EventArgs e)
        {
            var app = new App(userDB, conn);
            app.Show();
            this.Dispose(true);
        }
        public bool ValidateForm()
        {
            bool isCompleted = true;
            if (String.IsNullOrEmpty(dbDetalle.Text))
                isCompleted = false;
            else if (dbVertical.SelectedItem == null)
                isCompleted = false;
            else if (dbRegulariza.SelectedItem == null)
                isCompleted = false;
            else if (dbTipo.SelectedItem == null)
                isCompleted = false;
            else if (String.IsNullOrEmpty(dbQuery.Text))
                isCompleted = false;

            //TODO: Comprobar que todos los campos están rellenos y encaso de no estar almenos 1, poner el flag a FALSE

            return isCompleted;
        }

        private void saveEditCase(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //TODO: Aquí va el código para guardar la edición del registro.
                string IdCase = dbIdCase.Text;
                string query = String.Format("UPDATE TR_OPTIMIZACION_AUTO_SCRIPT set NOMBRE_PROCEDIMIENTO=@detalle, REGULARIZA=@activo, CONSULTA_SEL=@sqlQuery, ID_TIPO_SCRIPT=@type WHERE ID={0}", IdCase);
                string queryVertical = String.Format("UPDATE TR_QUERY_VERTICAL SET IdVertical = @vertical WHERE IdQuery = {0}", IdCase);
                bool active = false;
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlCommand command = new SqlCommand(queryVertical, conn);

                cmd.Parameters.AddWithValue("@detalle", dbDetalle.Text);
                command.Parameters.AddWithValue("@vertical", dbVertical.SelectedValue);
                if (dbRegulariza.Text == "Si")
                {
                    active = true;
                }
                cmd.Parameters.AddWithValue("@activo", active);
                cmd.Parameters.AddWithValue("@type", dbTipo.SelectedValue);
                cmd.Parameters.AddWithValue("@sqlQuery", dbQuery.Text);



                try
                {
                    command.ExecuteNonQuery();
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
    }
}
