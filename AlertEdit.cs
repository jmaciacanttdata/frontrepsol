using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Drawing;

namespace AutoRepsol
{
    public partial class AlertEdit : Form
    {
        JObject config;
        string[] arraySupportMails;
        string[] arrayBussinesMails;

        SqlConnection conn;
        string userDB;

        public AlertEdit(string dbUser, SqlConnection _conn)
        {
            InitializeComponent();
            GetAppConfig();
            SetApplicationConfig();
            conn = _conn;
            userDB = dbUser;
        }

        private void GetAppConfig()
        {
            config = JObject.Parse(File.ReadAllText(@"appconfig.json"));
        }

        private void SetApplicationConfig()
        {
            string appTitle;
            appTitle = config.GetValue("appName").ToString() + " v" + config.GetValue("appVersion").ToString();
            this.Text = appTitle;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void CLoseApp(object sender, FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            }
            else
            {
                conn.Close();
                Environment.Exit(0);
            }
        }

        public static bool CloseCancel()
        {
            const string message = "¿Está seguro de querer cerrar la aplicación?";
            const string caption = "AutoRepsol";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private void GetInfoVertical(object sender, EventArgs e)
        {
            if (cbVertical.Text != null && cbVertical.Text != "")
            {
                if (dtSupport.Columns.Count > 0)
                    dtSupport.Columns.Clear();
                if (dtBussines.Columns.Count > 0)
                    dtBussines.Columns.Clear();
                btnRestore.Enabled = true;
                btnSave.Enabled = true;

                string fileIni = config.GetValue("rootPath").ToString() + GetFileIni(cbVertical.Text);
                string[] lines = File.ReadAllLines(fileIni);
                string mailSupport;
                string mailBussines;
                bool encontradoSupport = false;
                bool encontradoBussines = false;

                foreach (string line in lines)
                {
                    if (line.Contains("supportMails = "))
                    {
                        mailSupport = line.Replace("supportMails = ", "");
                        char separator = ',';
                        if (mailSupport.Contains(";"))
                            separator = ';';
                        arraySupportMails = mailSupport.Split(separator);

                        encontradoSupport = true;
                    }

                    if (line.Contains("businessMails = "))
                    {
                        mailBussines = line.Replace("businessMails = ", "");
                        char separator = ',';
                        if (mailBussines.Contains(";"))
                            separator = ';';
                        arrayBussinesMails = mailBussines.Split(separator);

                        encontradoBussines = true;
                    }

                    if (encontradoSupport && encontradoBussines)
                        break;
                }

                dtSupport.Columns.Add("Support Mails", "Support Mails");
                foreach (string mail in arraySupportMails)
                    dtSupport.Rows.Add(mail);

                dtBussines.Columns.Add("Bussines Mails", "Bussines Mails");
                foreach (string mail in arrayBussinesMails)
                    dtBussines.Rows.Add(mail);

                dtSupport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtBussines.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                btnRestore.Enabled = false;
                btnSave.Enabled = false;
                dtSupport.Columns.Clear();
                dtBussines.Columns.Clear();
            }
        }

        private string GetFileIni(string v)
        {
            string response = "";
            switch (v)
            {
                case "BO - Backoffice KPIs Simples":
                    response = "RepsolTritonKPISimple.ini";
                    break;
                case "BO - Backoffice KPIs Especiales":
                    response = "RepsolTritonKPIEspecial.ini";
                    break;
                case "BO - Backoffice Ficheros":
                    response = "RepsolTritonBOFiles.ini";
                    break;
                case "FO - Frontoffice":
                    response = "RepsolTritonFO.ini";
                    break;
                case "FA - Facturación (Morning)":
                    response = "RepsolTritonFRA_Morning.ini";
                    break;
                case "FA - Facturacion (Afternoon)":
                    response = "RepsolTritonFRA_Afternoon.ini";
                    break;
                case "FA - Facturación (Ficheros General)":
                    response = "RepsolTritonFRAFiles.ini";
                    break;
                case "FA - Facturación (Ficheros Continuos)":
                    response = "RepsolTritonFRAFilesContinuous.ini";
                    break;
                case "LO - Logística":
                    response = "RepsolTritonLogistica.ini";
                    break;
                case "PM - Pricing":
                    response = "RepsolTritonPricing.ini";
                    break;
                default:
                    break;
            }
            return response;
        }

        private void RestoreRollback(object sender, EventArgs e)
        {
            string fileIni = GetFileIni(cbVertical.Text);
            string rootFile = config.GetValue("rootPath").ToString() + fileIni;
            string rollbackFile = config.GetValue("rollbackPath").ToString() + fileIni;

            try
            {
                DialogResult dr = MessageBox.Show("Se va a restaurar el fichero rollback para la vertical " + cbVertical.Text + ".\r\n\r\n¿Está seguro de querer continuar con la restauración?", "Restauración Rollback", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    File.Delete(rootFile);
                    File.Copy(rollbackFile, rootFile, true);
                    btnRestore.Enabled = false;
                    btnSave.Enabled = false;
                    dtSupport.Columns.Clear();
                    dtBussines.Columns.Clear();
                    cbVertical.SelectedIndex = cbVertical.FindStringExact("");
                    MessageBox.Show("El fichero de configuración para la vertical " + cbVertical.Text + " ha sido restaurado correctamente.", "Restauración Rollback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Se han producido errores al intentar restaurar el fichero rollback para la vertical " + cbVertical.Text + ".\r\n\r\nContacte con el soporte", "Restauración Rollback", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveEditIni(object sender, EventArgs e)
        {
            bool encontradoSupport = false;
            bool encontradoBussines = false;
            string supportMails = "";
            string bussinesMails = "";
            string fileIni = GetFileIni(cbVertical.Text);
            string rootFile = config.GetValue("rootPath").ToString() + fileIni;
            string rollbackFile = config.GetValue("rollbackPath").ToString() + fileIni;
            DialogResult dr = MessageBox.Show("Se va a guardar el fichero de configuración editado para la vertical " + cbVertical.Text + ".\r\n\r\n¿Está seguro de querer continuar con el guardado?", "Guardado de Configuración", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //Creamos el rollbacl del fichero
                File.Copy(rootFile, rollbackFile, true);

                //Obtenemos el contenido del fichero
                string[] lines = File.ReadAllLines(rootFile);

                //Seteamos las líneas editadas
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];
                    char separator = ',';
                    if (line.Contains("supportMails = "))
                    {
                        if (line.Contains(";"))
                            separator = ';';

                        //Recogemos los valores del DataGridView de Support
                        foreach (DataGridViewRow row in dtSupport.Rows)
                        {
                            if (row.Cells[0].Value != null && row.Cells[0].Value != "")
                            {
                                if (supportMails == "")
                                    supportMails += row.Cells[0].Value.ToString();
                                else
                                    supportMails += separator + row.Cells[0].Value.ToString();
                            }
                        }
                        lines[i] = "supportMails = " + supportMails;
                    }

                    separator = ',';
                    if (line.Contains("businessMails = "))
                    {
                        if (line.Contains(";"))
                            separator = ';';

                        //Recogemos los valores del DataGridView de Support
                        foreach (DataGridViewRow row in dtBussines.Rows)
                        {
                            if (row.Cells[0].Value != null && row.Cells[0].Value != "")
                            {
                                if (bussinesMails == "")
                                    bussinesMails += row.Cells[0].Value.ToString();
                                else
                                    bussinesMails += separator + row.Cells[0].Value.ToString();
                            }
                        }
                        lines[i] = "businessMails = " + bussinesMails;
                    }

                    if (encontradoSupport && encontradoBussines)
                        break;
                }

                //Eliminamos el fichero origen
                File.Delete(rootFile);
                System.IO.File.WriteAllLines(rootFile, lines);

                btnRestore.Enabled = false;
                btnSave.Enabled = false;
                dtSupport.Columns.Clear();
                dtBussines.Columns.Clear();
                cbVertical.SelectedIndex = cbVertical.FindStringExact("");
                MessageBox.Show("El fichero de configuración para la vertical " + cbVertical.Text + " ha sido actualizado correctamente.", "Guardado de Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            var app = new App(userDB, conn);
            app.Show();
            this.Dispose(true);
        }
    }
}