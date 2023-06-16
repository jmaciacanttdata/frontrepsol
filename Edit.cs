using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
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
    public partial class Edit : Form
    {
        SqlConnection conn;
        private readonly IConfiguration _configuration;

        public Edit(int IdCase, SqlConnection _conn)
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddJsonFile("sysconfig.json", optional: false, reloadOnChange: true).Build();
            dbIdCase.Text = IdCase.ToString();
            conn = _conn;
            GetDataCase(IdCase);
        }

        public void GetDataCase(int IdCase)
        {
            //TODO: Aquí lanzamos la query para obtener los datos del registro
            //TODO: Aquí inyectamos en cada input del formulario su dato correspondiente
            dbDetalle.Text = "SELECT NOMBRE_PRODECIMIENTO FROM TR_OPTIMIZACION_AUTO_SCRIP WHERE ID=IdCase";
            dbVertical.Text = "SELECT ??? FROM TR_OPTIMIZACION_AUTO_SCRIP WHERE ID=IdCase";
            dbActivo.Text = "SELECT REGULARIZA FROM TR_OPTIMIZACION_AUTO_SCRIP WHERE ID=IdCase";
            dbQuery.Text = "SELECT CONSULTA_SEL FROM TR_OPTIMIZACION_AUTO_SCRIP WHERE ID=IdCase";

        }

        private void closeEditForm(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveEditCase(object sender, EventArgs e)
        {
            /* string IdCase = dbIdCase.Text;
             * string query = "Update TR_OPTIMIZACION_AUTO_SCRIP set NOMBRE_PROCEDIMIENTO=@detalle, blabla=@vertical, REGULARIZA=@activo, CONSULTA_SEL=@sqlQuery WHERE ID=IdCase";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@detalle", dbDetalle);
            cmd.Parameters.AddWithValue("@vertical", dbVertical);
            cmd.Parameters.AddWithValue("@activo", dbActivo);
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
            }*/

        }
    }
}
