using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Installer()
        {
            InitializeComponent();
            InstallDBComponents();

        }

        public void InstallDBComponents()
        {
            //TODO: Ejecutar aquí las querys para la creación de nuevas tablas

            //TODO: Ejecutar aquí las querys para la inserción de datos necesarios

            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
