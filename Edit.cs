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
    public partial class Edit : Form
    {
        SqlConnection conn;
        private readonly IConfiguration _configuration;

        public Edit(int IdCase, SqlConnection _conn)
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddJsonFile("sysconfig.json", optional: false, reloadOnChange: true).Build();
            dbIdCase.Text = IdCase.ToString();
            //dbIdCase.Visible = true;
            conn = _conn;
            GetDataCase(IdCase);
        }
        private void InitializeMyScrollBar()
        {
            VScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            Controls.Add(vScrollBar1);
        }

        public void GetDataCase(int IdCase)
        {
            //TODO: Aquí lanzamos la query para obtener los datos del registro
            //TODO: Aquí inyectamos en cada input del formulario su dato correspondiente
            var query = "SELECT * FROM TR_OPTIMIZACION_AUTO_SCRIPT WHERE ID=1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                dbDetalle.Text = reader["NOMBRE_PROCEDIMIENTO"].ToString();
                dbVertical.Text = reader["PARAM_SEL"].ToString();
                dbActivo.Text = reader["REGULARIZA"].ToString();
                dbQuery.Text = reader["CONSULTA_SEL"].ToString();
                InitializeMyScrollBar();
            }
        }

        private void closeEditForm(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveEditCase(object sender, EventArgs e)
        {
            //TODO: Aquí va el código para guardar la edición del registro.
            string IdCase = dbIdCase.Text;
            string query = "Update TR_OPTIMIZACION_AUTO_SCRIPT set NOMBRE_PROCEDIMIENTO=@detalle, blabla=@vertical, REGULARIZA=@activo, CONSULTA_SEL=@sqlQuery WHERE ID=IdCase";
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
            }
        }
    }
}
