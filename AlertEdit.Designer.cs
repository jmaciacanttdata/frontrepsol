namespace AutoRepsol
{
    partial class AlertEdit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertEdit));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnRestore = new Button();
            panel2 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            panel3 = new Panel();
            cbVertical = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dtSupport = new DataGridView();
            dtBussines = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtSupport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtBussines).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 1, 2);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(dtSupport, 0, 1);
            tableLayoutPanel1.Controls.Add(dtBussines, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.848485F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.15151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Size = new Size(1570, 857);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRestore);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 813);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 41);
            panel1.TabIndex = 0;
            // 
            // btnRestore
            // 
            btnRestore.Dock = DockStyle.Left;
            btnRestore.Enabled = false;
            btnRestore.Location = new Point(0, 0);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(167, 41);
            btnRestore.TabIndex = 0;
            btnRestore.Text = "Restaurar Rollback";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += RestoreRollback;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(788, 813);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 41);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Right;
            btnCancel.Location = new Point(555, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 41);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += CloseWindow;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Right;
            btnSave.Enabled = false;
            btnSave.Location = new Point(667, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 41);
            btnSave.TabIndex = 0;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += SaveEditIni;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbVertical);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(779, 73);
            panel3.TabIndex = 2;
            // 
            // cbVertical
            // 
            cbVertical.FormattingEnabled = true;
            cbVertical.Items.AddRange(new object[] { "", "BO - Backoffice KPIs Simples", "BO - Backoffice KPIs Especiales", "BO - Backoffice Ficheros", "FO - Frontoffice", "FA - Facturación (Morning)", "FA - Facturacion (Afternoon)", "FA - Facturación (Ficheros General)", "FA - Facturación (Ficheros Continuos)", "LO - Logística", "PM - Pricing" });
            cbVertical.Location = new Point(92, 21);
            cbVertical.Name = "cbVertical";
            cbVertical.Size = new Size(408, 33);
            cbVertical.TabIndex = 1;
            cbVertical.SelectedIndexChanged += GetInfoVertical;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Vertical";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Location = new Point(1417, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 73);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dtSupport
            // 
            dtSupport.AllowUserToOrderColumns = true;
            dtSupport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtSupport.Dock = DockStyle.Fill;
            dtSupport.Location = new Point(3, 82);
            dtSupport.Name = "dtSupport";
            dtSupport.RowHeadersWidth = 62;
            dtSupport.RowTemplate.Height = 33;
            dtSupport.Size = new Size(779, 725);
            dtSupport.TabIndex = 4;
            // 
            // dtBussines
            // 
            dtBussines.AllowUserToOrderColumns = true;
            dtBussines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtBussines.Dock = DockStyle.Fill;
            dtBussines.Location = new Point(788, 82);
            dtBussines.Name = "dtBussines";
            dtBussines.RowHeadersWidth = 62;
            dtBussines.RowTemplate.Height = 33;
            dtBussines.Size = new Size(779, 725);
            dtBussines.TabIndex = 5;
            // 
            // AlertEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 857);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "AlertEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoRepsol";
            FormClosing += CloseApp;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtSupport).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtBussines).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnRestore;
        private Panel panel2;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel3;
        private ComboBox cbVertical;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dtSupport;
        private DataGridView dtBussines;
    }
}