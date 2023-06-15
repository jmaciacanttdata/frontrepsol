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
    public partial class Create : Form
    {
        SqlConnection conn;

        public Create(SqlConnection _conn)
        {
            InitializeComponent();
            conn = _conn;
        }

        private void closeCreateForm(object sender, EventArgs e)
        {
            //Duda
            this.Dispose();
        }

        private void createCase(object sender, EventArgs e)
        {
            //TODO: Aquí va el código de guardado del nuevo caso
            this.Dispose(true);
        }
    }
}
