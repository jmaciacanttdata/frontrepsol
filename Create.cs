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
            GetDataSourceType(_conn);
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

        private void createCase(object sender, EventArgs e)
        {
            //TODO: Aquí va el código de guardado del nuevo caso
            var query = "insert into TR_OPTIMIZACION_AUTO_SCRIPT (NOMBRE_PROCEDIMIENTO,ID_TIPO_SCRIPT ,REGULARIZA, CONSULTA_SEL) VALUES(@detalle,@tipo ,@regulariza, @consulta); ";
            var insertVertical = "insert into TR_QUERY_VERTICAL (IdQuery, IdVertical) VALUES (@pkOptimizacion, @pkVertical)";
            var SelectIdOpt = "Select TOP 1 ID from TR_OPTIMIZACION_AUTO_SCRIPT ORDER BY ID DESC";

            int idTipo = int.Parse(dbTipo.SelectedValue.ToString());
            int idVertical= int.Parse(dbVertical.SelectedValue.ToString());

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlCommand cmdInsertVertical = new SqlCommand(insertVertical, conn);
            SqlCommand cmdSelectIdOpt = new SqlCommand(SelectIdOpt, conn);

            cmd.Parameters.AddWithValue("@detalle", dbDetalle.Text);
            cmd.Parameters.AddWithValue("@tipo", idTipo);

            if (dbRegulariza.SelectedIndex == 1)
                cmd.Parameters.AddWithValue("@regulariza", false);
            else
                cmd.Parameters.AddWithValue("@regulariza", true);

            cmd.Parameters.AddWithValue("@consulta", dbQuery.Text);
            try
            {
                cmd.ExecuteNonQuery();
                int pkOptimizacion = (int)cmdSelectIdOpt.ExecuteScalar();
                cmdInsertVertical.Parameters.AddWithValue("@pkOptimizacion", pkOptimizacion);
                cmdInsertVertical.Parameters.AddWithValue("@pkVertical", idVertical);
                cmdInsertVertical.ExecuteNonQuery();
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
