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
            conn = _conn;
            GetDataCase(IdCase);
        }

        public void GetDataCase(int IdCase)
        {
            //TODO: Aquí lanzamos la query para obtener los datos del registro
            //TODO: Aquí inyectamos en cada input del formulario su dato correspondiente
        }

        private void closeEditForm(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveEditCase(object sender, EventArgs e)
        {
            //TODO: Aquí va el código para guardar la edición del registro.
            this.Dispose(true);
        }
    }
}
