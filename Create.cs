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

namespace AutoRepsol
{
    public partial class Create : Form
    {
        SqlConnection conn;
        private readonly IConfiguration _configuration;

        public Create(SqlConnection _conn)
        {
            InitializeComponent();
            _configuration = new ConfigurationBuilder().AddJsonFile("sysconfig.json", optional: false, reloadOnChange: true).Build();
            conn = _conn;
            GetDataSourceVertical(_conn);
        }

        private void closeCreateForm(object sender, EventArgs e)
        {
            this.Dispose();

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

        private void createCase(object sender, EventArgs e)
        {
            //TODO: Aquí va el código de guardado del nuevo caso
            var queryVertical = "insert into TR_VERTICAL() VALUES ";
            var query = "insert into TR_OPTIMIZACION_AUTO_SCRIPT (NOMBRE_PROCEDIMIENTO, REGULARIZA, CONSULTA_SEL) VALUES(@detalle, @activo, @consulta)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@detalle", dbDetalle);
            cmd.Parameters.AddWithValue("@vertical", dbVertical);
            cmd.Parameters.AddWithValue("@regulariza", dbRegulariza);
            cmd.Parameters.AddWithValue("@consulta", dbQuery);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha guardado la consulta correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Dispose(true);
        }

        /*public void AddLineNumbers()
        {
            // create & set Point pt to (0,0)    
            Point pt = new Point(0, 0);
            // get First Index & First Line from richTextBox1    
            int First_Index = dbQuery.GetCharIndexFromPosition(pt);
            int First_Line = dbQuery.GetLineFromCharIndex(First_Index);
            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively    
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            // get Last Index & Last Line from richTextBox1    
            int Last_Index = dbQuery.GetCharIndexFromPosition(pt);
            int Last_Line = dbQuery.GetLineFromCharIndex(Last_Index);
            // set Center alignment to LineNumberTextBox    
            LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Center;
            // set LineNumberTextBox text to null & width to getWidth() function value    
            LineNumberTextBox.Text = "";
            LineNumberTextBox.Width = getWidth();
            // now add each line number to LineNumberTextBox upto last line    
            for (int i = First_Line; i <= Last_Line + 2; i++)
            {
                LineNumberTextBox.Text += i + 1 + "\n";
            }
        }*/
    }
}
