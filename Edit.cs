using AutoRepsol.Models;
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
using System.Xml.Linq;

namespace AutoRepsol
{
    public partial class Edit : Form
    {
        SqlConnection conn;
        private readonly IConfiguration _configuration;

        public Edit(int IdCase, SqlConnection _conn)
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddJsonFile("sysconfig.json", optional: false, reloadOnChange: true).Build();
            dbIdCase.Text = IdCase.ToString();
            dbIdCase.Visible = true;
            conn = _conn;
            GetDataSourceVertical(_conn);
            GetDataCase(IdCase);
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
            //TODO: Aquí lanzamos la query para obtener los datos del registro
            //TODO: Aquí inyectamos en cada input del formulario su dato correspondiente
            dbQuery.ScrollBars = ScrollBars.Vertical;
            this.Controls.Add(dbQuery);
            var query = String.Format("SELECT OS.ID, TV.Id, TV.Vertical, OS.NOMBRE_PROCEDIMIENTO, OS.REGULARIZA, OS.CONSULTA_SEL FROM TR_QUERY_VERTICAL QV INNER JOIN TR_VERTICAL TV ON TV.Id=QV.IdVertical INNER JOIN TR_OPTIMIZACION_AUTO_SCRIPT OS ON OS.ID = QV.IdQuery where QV.IdQuery={0};", IdCase);
            SqlCommand cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dbDetalle.Text = reader["NOMBRE_PROCEDIMIENTO"].ToString();
                dbVertical.SelectedIndex = dbVertical.FindStringExact(reader["Vertical"].ToString());
                dbRegulariza.Text = reader["REGULARIZA"].ToString();
                dbQuery.Text = reader["CONSULTA_SEL"].ToString();
            }
            reader.Close();
        }

        private void closeEditForm(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveEditCase(object sender, EventArgs e)
        {
            //TODO: Aquí va el código para guardar la edición del registro.
            string IdCase = dbIdCase.Text;
            string query = "UPDATE FROM TR_OPTIMIZACION_AUTO_SCRIPT set NOMBRE_PROCEDIMIENTO=@detalle, VERTICAL=@vertical, REGULARIZA=@activo, CONSULTA_SEL=@sqlQuery WHERE ID=IdCase";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@detalle", dbDetalle);
            cmd.Parameters.AddWithValue("@vertical", dbVertical);
            cmd.Parameters.AddWithValue("@activo", dbRegulariza);
            cmd.Parameters.AddWithValue("@sqlQuery", dbQuery);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("El registro ha sido actualizado correctamente");
                this.Dispose(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
