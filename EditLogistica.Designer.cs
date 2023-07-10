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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            dbDetalle = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            dbURL = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel5 = new Panel();
            dbXML = new RichTextBox();
            label5 = new Label();
            panel4 = new Panel();
            dbQuery = new RichTextBox();
            label4 = new Label();
            dbTablaTemporal = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1252, 123);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dbDetalle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 117);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 26;
            label1.Text = "Detalle";
            // 
            // dbDetalle
            // 
            dbDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbDetalle.Location = new Point(26, 43);
            dbDetalle.Name = "dbDetalle";
            dbDetalle.Size = new Size(573, 31);
            dbDetalle.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dbURL);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(629, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(620, 117);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(34, 15);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 27;
            label2.Text = "URL";
            // 
            // dbURL
            // 
            dbURL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbURL.Location = new Point(34, 43);
            dbURL.Name = "dbURL";
            dbURL.Size = new Size(573, 31);
            dbURL.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel5, 0, 1);
            tableLayoutPanel2.Location = new Point(0, 252);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1249, 493);
            tableLayoutPanel2.TabIndex = 29;
            // 
            // panel5
            // 
            panel5.Controls.Add(dbXML);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(3, 249);
            panel5.Name = "panel5";
            panel5.Size = new Size(1243, 138);
            panel5.TabIndex = 28;
            // 
            // dbXML
            // 
            dbXML.Location = new Point(29, 50);
            dbXML.Name = "dbXML";
            dbXML.Size = new Size(1205, 226);
            dbXML.TabIndex = 29;
            dbXML.Text = "";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(29, 22);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 28;
            label5.Text = "Estructura XML";
            // 
            // panel4
            // 
            panel4.Controls.Add(dbQuery);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 228);
            panel4.Name = "panel4";
            panel4.Size = new Size(1252, 176);
            panel4.TabIndex = 27;
            // 
            // dbQuery
            // 
            dbQuery.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbQuery.Location = new Point(26, 40);
            dbQuery.Name = "dbQuery";
            dbQuery.Size = new Size(1216, 104);
            dbQuery.TabIndex = 30;
            dbQuery.Text = "";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(26, 12);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 27;
            label4.Text = "Consulta SQL";
            // 
            // dbTablaTemporal
            // 
            dbTablaTemporal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbTablaTemporal.Location = new Point(29, 59);
            dbTablaTemporal.Name = "dbTablaTemporal";
            dbTablaTemporal.Size = new Size(1207, 31);
            dbTablaTemporal.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(29, 31);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 27;
            label3.Text = "Nombre Tabla Temporal";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dbTablaTemporal);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(1252, 105);
            panel3.TabIndex = 26;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnCancel);
            panel6.Controls.Add(btnSave);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 748);
            panel6.Name = "panel6";
            panel6.Size = new Size(1252, 66);
            panel6.TabIndex = 30;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Right;
            btnCancel.Location = new Point(792, 0);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(230, 66);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Right;
            btnSave.Location = new Point(1022, 0);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(230, 66);
            btnSave.TabIndex = 25;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // EditLogistica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 814);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel3);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "EditLogistica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditLogistica";
            WindowState = FormWindowState.Maximized;
            FormClosing += CLoseApp;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private TextBox dbDetalle;
        private Panel panel2;
        private Label label2;
        private TextBox dbURL;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
        private RichTextBox dbXML;
        private Label label5;
        private TextBox dbTablaTemporal;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private RichTextBox dbQuery;
        private Label label4;
        private Panel panel6;
        private Button btnCancel;
        private Button btnSave;
    }
}