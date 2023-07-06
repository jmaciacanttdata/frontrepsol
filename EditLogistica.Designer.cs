namespace AutoRepsol
{
    partial class EditLogistica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            dbTablaTemporal = new TextBox();
            label1 = new Label();
            dbDetalle = new TextBox();
            dbURL = new TextBox();
            label4 = new Label();
            dbQuery = new RichTextBox();
            label5 = new Label();
            dbXML = new RichTextBox();
            label6 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(984, 23);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 18;
            label3.Text = "Nombre Tabla Temporal";
            // 
            // dbTablaTemporal
            // 
            dbTablaTemporal.Location = new Point(984, 59);
            dbTablaTemporal.Margin = new Padding(4);
            dbTablaTemporal.Name = "dbTablaTemporal";
            dbTablaTemporal.Size = new Size(1021, 31);
            dbTablaTemporal.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 16;
            label1.Text = "Detalle";
            // 
            // dbDetalle
            // 
            dbDetalle.Location = new Point(37, 59);
            dbDetalle.Margin = new Padding(4);
            dbDetalle.Name = "dbDetalle";
            dbDetalle.Size = new Size(849, 31);
            dbDetalle.TabIndex = 15;
            // 
            // dbURL
            // 
            dbURL.Location = new Point(46, 60);
            dbURL.Margin = new Padding(4);
            dbURL.Name = "dbURL";
            dbURL.Size = new Size(1944, 31);
            dbURL.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 24);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 25);
            label4.TabIndex = 16;
            label4.Text = "URL";
            // 
            // dbQuery
            // 
            dbQuery.BorderStyle = BorderStyle.None;
            dbQuery.Dock = DockStyle.Bottom;
            dbQuery.Location = new Point(0, 29);
            dbQuery.Margin = new Padding(4);
            dbQuery.Name = "dbQuery";
            dbQuery.Size = new Size(2075, 413);
            dbQuery.TabIndex = 20;
            dbQuery.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 19;
            label5.Text = "Consulta SQL";
            // 
            // dbXML
            // 
            dbXML.BorderStyle = BorderStyle.None;
            dbXML.Location = new Point(176, 829);
            dbXML.Margin = new Padding(4);
            dbXML.Name = "dbXML";
            dbXML.Size = new Size(1177, 208);
            dbXML.TabIndex = 22;
            dbXML.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(176, 800);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 21;
            label6.Text = "Estructura XML";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(632, 1055);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(768, 1055);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 36);
            btnSave.TabIndex = 23;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dbTablaTemporal);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2075, 154);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.Controls.Add(dbDetalle);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 154);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dbURL);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(2075, 150);
            panel3.TabIndex = 26;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(dbQuery);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 304);
            panel4.Name = "panel4";
            panel4.Size = new Size(2075, 442);
            panel4.TabIndex = 27;
            // 
            // EditLogistica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2075, 1232);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dbXML);
            Controls.Add(label6);
            MaximizeBox = false;
            Name = "EditLogistica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditLogistica";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox dbTablaTemporal;
        private Label label1;
        private TextBox dbDetalle;
        private TextBox dbURL;
        private Label label4;
        private RichTextBox dbQuery;
        private Label label5;
        private RichTextBox dbXML;
        private Label label6;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}