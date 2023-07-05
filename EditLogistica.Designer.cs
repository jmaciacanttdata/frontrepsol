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
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            dbQuery = new RichTextBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 158);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 18;
            label3.Text = "Nombre Tabla Temporal";
            // 
            // dbTablaTemporal
            // 
            dbTablaTemporal.Location = new Point(13, 194);
            dbTablaTemporal.Margin = new Padding(4);
            dbTablaTemporal.Name = "dbTablaTemporal";
            dbTablaTemporal.Size = new Size(651, 31);
            dbTablaTemporal.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 16;
            label1.Text = "Detalle";
            // 
            // dbDetalle
            // 
            dbDetalle.Location = new Point(13, 100);
            dbDetalle.Margin = new Padding(4);
            dbDetalle.Name = "dbDetalle";
            dbDetalle.Size = new Size(651, 31);
            dbDetalle.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1104, 98);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(482, 33);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1104, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 4;
            label2.Text = "Vertical";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1104, 194);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(482, 31);
            textBox1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1104, 158);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 25);
            label4.TabIndex = 16;
            label4.Text = "URL";
            // 
            // dbQuery
            // 
            dbQuery.BorderStyle = BorderStyle.None;
            dbQuery.Location = new Point(13, 274);
            dbQuery.Margin = new Padding(4);
            dbQuery.Name = "dbQuery";
            dbQuery.Size = new Size(1556, 368);
            dbQuery.TabIndex = 20;
            dbQuery.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 245);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 19;
            label5.Text = "Consulta SQL";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(13, 694);
            richTextBox1.Margin = new Padding(4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1556, 365);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 665);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 21;
            label6.Text = "Estructura XML";
            // 
            // EditLogistica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1691, 1050);
            Controls.Add(richTextBox1);
            Controls.Add(label6);
            Controls.Add(dbQuery);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dbTablaTemporal);
            Controls.Add(label1);
            Controls.Add(dbDetalle);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "EditLogistica";
            Text = "EditLogistica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox dbTablaTemporal;
        private Label label1;
        private TextBox dbDetalle;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private RichTextBox dbQuery;
        private Label label5;
        private RichTextBox richTextBox1;
        private Label label6;
    }
}