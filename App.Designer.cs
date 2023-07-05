namespace AutoRepsol
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            cmbVertical = new ComboBox();
            btnDelete = new Button();
            btnCreate = new Button();
            panel2 = new Panel();
            dbData = new DataGridView();
            panel3 = new Panel();
            lblCatalog = new Label();
            label3 = new Label();
            lblServer = new Label();
            label2 = new Label();
            lblUserName = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dbData).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cmbVertical);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnCreate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 60);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1148, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // cmbVertical
            // 
            cmbVertical.FormattingEnabled = true;
            cmbVertical.Items.AddRange(new object[] { "Todos", "BO - Backoffice", "FO - Frontoffice", "FA - Facturación", "PM - Pricing", "LO - Logística" });
            cmbVertical.Location = new Point(267, 11);
            cmbVertical.Name = "cmbVertical";
            cmbVertical.Size = new Size(182, 33);
            cmbVertical.TabIndex = 2;
            cmbVertical.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(130, 11);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 34);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += deleteCase;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(11, 11);
            btnCreate.Margin = new Padding(2, 4, 2, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(111, 34);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += openCreateForm;
            // 
            // panel2
            // 
            panel2.Controls.Add(dbData);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Margin = new Padding(2, 4, 2, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1284, 641);
            panel2.TabIndex = 1;
            // 
            // dbData
            // 
            dbData.AllowUserToAddRows = false;
            dbData.AllowUserToDeleteRows = false;
            dbData.AllowUserToResizeColumns = false;
            dbData.AllowUserToResizeRows = false;
            dbData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbData.Dock = DockStyle.Fill;
            dbData.Location = new Point(0, 0);
            dbData.Margin = new Padding(2, 4, 2, 4);
            dbData.Name = "dbData";
            dbData.ReadOnly = true;
            dbData.RowHeadersWidth = 62;
            dbData.RowTemplate.Height = 33;
            dbData.ShowCellToolTips = false;
            dbData.ShowEditingIcon = false;
            dbData.Size = new Size(1284, 641);
            dbData.TabIndex = 3;
            dbData.CellDoubleClick += GetItemData;
            dbData.RowStateChanged += enableDisableDelete;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblCatalog);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblServer);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblUserName);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 662);
            panel3.Margin = new Padding(2, 4, 2, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1284, 39);
            panel3.TabIndex = 2;
            // 
            // lblCatalog
            // 
            lblCatalog.AutoSize = true;
            lblCatalog.Location = new Point(411, 6);
            lblCatalog.Margin = new Padding(4, 0, 4, 0);
            lblCatalog.Name = "lblCatalog";
            lblCatalog.Size = new Size(59, 25);
            lblCatalog.TabIndex = 5;
            lblCatalog.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 6);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Catalog:";
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(84, 8);
            lblServer.Margin = new Padding(4, 0, 4, 0);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(59, 25);
            lblServer.TabIndex = 3;
            lblServer.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 2;
            label2.Text = "Server:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(711, 6);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(59, 25);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(655, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 0;
            label1.Text = "User:";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 701);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 4, 2, 4);
            MaximizeBox = false;
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoRepsol";
            WindowState = FormWindowState.Maximized;
            FormClosing += CLoseApp;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dbData).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCreate;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label lblUserName;
        private Label label1;
        private DataGridView dbData;
        private Label lblServer;
        private Button btnDelete;
        private Label lblCatalog;
        private Label label3;
        private ComboBox cmbVertical;
        private PictureBox pictureBox1;
    }
}