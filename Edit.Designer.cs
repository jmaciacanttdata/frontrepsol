namespace AutoRepsol
{
    partial class Edit
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
            panel5 = new Panel();
            dbQuery = new TextBox();
            panel8 = new Panel();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            dbVertical = new ComboBox();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            dbRegulariza = new ComboBox();
            panel4 = new Panel();
            label5 = new Label();
            dbTipo = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            dbDetalle = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel7 = new Panel();
            lblCatalog = new Label();
            label6 = new Label();
            lblServer = new Label();
            label7 = new Label();
            lblUserName = new Label();
            label8 = new Label();
            panel6 = new Panel();
            dbIdCase = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(dbQuery);
            panel5.Controls.Add(panel8);
            panel5.Location = new Point(-4, 279);
            panel5.Name = "panel5";
            panel5.Size = new Size(1264, 416);
            panel5.TabIndex = 39;
            // 
            // dbQuery
            // 
            dbQuery.Dock = DockStyle.Fill;
            dbQuery.Location = new Point(0, 29);
            dbQuery.Margin = new Padding(4, 4, 4, 3);
            dbQuery.Multiline = true;
            dbQuery.Name = "dbQuery";
            dbQuery.Size = new Size(1264, 387);
            dbQuery.TabIndex = 18;
            // 
            // panel8
            // 
            panel8.Controls.Add(label4);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1264, 29);
            panel8.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 20;
            label4.Text = "Consulta SQL";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2454472F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.42122F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Location = new Point(-7, 126);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1249, 150);
            tableLayoutPanel1.TabIndex = 37;
            // 
            // panel2
            // 
            panel2.Controls.Add(dbVertical);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 144);
            panel2.TabIndex = 0;
            // 
            // dbVertical
            // 
            dbVertical.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbVertical.FormattingEnabled = true;
            dbVertical.Items.AddRange(new object[] { "BO - Backoffice", "FO - Frontoffice", "FA - Facturación", "PM - Pricing", "LO - Logística" });
            dbVertical.Location = new Point(37, 56);
            dbVertical.Margin = new Padding(4, 3, 4, 3);
            dbVertical.Name = "dbVertical";
            dbVertical.Size = new Size(356, 33);
            dbVertical.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(37, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 14;
            label2.Text = "Vertical";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dbRegulariza);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(419, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 144);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(59, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 17;
            label3.Text = "Regulariza";
            // 
            // dbRegulariza
            // 
            dbRegulariza.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbRegulariza.FormattingEnabled = true;
            dbRegulariza.Items.AddRange(new object[] { "Si", "No" });
            dbRegulariza.Location = new Point(59, 56);
            dbRegulariza.Margin = new Padding(4, 3, 4, 3);
            dbRegulariza.Name = "dbRegulariza";
            dbRegulariza.Size = new Size(254, 33);
            dbRegulariza.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(dbTipo);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(796, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(450, 144);
            panel4.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(30, 25);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 24;
            label5.Text = "Tipo Script";
            // 
            // dbTipo
            // 
            dbTipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbTipo.DropDownWidth = 386;
            dbTipo.FormattingEnabled = true;
            dbTipo.Location = new Point(30, 56);
            dbTipo.Name = "dbTipo";
            dbTipo.Size = new Size(395, 33);
            dbTipo.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dbDetalle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1252, 120);
            panel1.TabIndex = 38;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(40, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 3;
            label1.Text = "Detalle";
            // 
            // dbDetalle
            // 
            dbDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbDetalle.Location = new Point(40, 48);
            dbDetalle.Margin = new Padding(4);
            dbDetalle.Name = "dbDetalle";
            dbDetalle.Size = new Size(1174, 31);
            dbDetalle.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel7, 0, 1);
            tableLayoutPanel2.Controls.Add(panel6, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 691);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1252, 97);
            tableLayoutPanel2.TabIndex = 40;
            // 
            // panel7
            // 
            panel7.Controls.Add(lblCatalog);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(lblServer);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(lblUserName);
            panel7.Controls.Add(label8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(2, 52);
            panel7.Margin = new Padding(2, 4, 2, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(1248, 41);
            panel7.TabIndex = 42;
            // 
            // lblCatalog
            // 
            lblCatalog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCatalog.AutoSize = true;
            lblCatalog.Location = new Point(432, 8);
            lblCatalog.Margin = new Padding(4, 0, 4, 0);
            lblCatalog.Name = "lblCatalog";
            lblCatalog.Size = new Size(59, 25);
            lblCatalog.TabIndex = 5;
            lblCatalog.Text = "label4";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(352, 8);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 4;
            label6.Text = "Catalog:";
            // 
            // lblServer
            // 
            lblServer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblServer.AutoSize = true;
            lblServer.Location = new Point(84, 8);
            lblServer.Margin = new Padding(4, 0, 4, 0);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(59, 25);
            lblServer.TabIndex = 3;
            lblServer.Text = "label3";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(11, 8);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 2;
            label7.Text = "Server:";
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(673, 8);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(59, 25);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "label2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(617, 8);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 0;
            label8.Text = "User:";
            // 
            // panel6
            // 
            panel6.Controls.Add(dbIdCase);
            panel6.Controls.Add(btnCancel);
            panel6.Controls.Add(btnSave);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(1246, 42);
            panel6.TabIndex = 41;
            // 
            // dbIdCase
            // 
            dbIdCase.Location = new Point(802, 6);
            dbIdCase.Name = "dbIdCase";
            dbIdCase.Size = new Size(102, 31);
            dbIdCase.TabIndex = 20;
            dbIdCase.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Right;
            btnCancel.Location = new Point(948, 0);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(149, 42);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += closeEditForm;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Right;
            btnSave.Location = new Point(1097, 0);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 42);
            btnSave.TabIndex = 10;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += saveEditCase;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 788);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel5);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 840);
            Name = "Edit";
            Text = "AutoRepsol";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private ComboBox dbVertical;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private ComboBox dbRegulariza;
        private Panel panel4;
        private Label label5;
        private ComboBox dbTipo;
        private Panel panel1;
        private Label label1;
        private TextBox dbDetalle;
        public TextBox dbQuery;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel7;
        private Label lblCatalog;
        private Label label6;
        private Label lblServer;
        private Label label7;
        private Label lblUserName;
        private Label label8;
        private Panel panel6;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel8;
        private Label label4;
        private TextBox dbIdCase;
    }
}