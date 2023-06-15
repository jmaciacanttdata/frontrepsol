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
            panel1 = new Panel();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dbData).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnCreate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 48);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(104, 8);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += deleteCase;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(9, 9);
            btnCreate.Margin = new Padding(2, 3, 2, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(89, 27);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += openCreateForm;
            // 
            // panel2
            // 
            panel2.Controls.Add(dbData);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 48);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1027, 513);
            panel2.TabIndex = 1;
            // 
            // dbData
            // 
            dbData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbData.Dock = DockStyle.Fill;
            dbData.Location = new Point(0, 0);
            dbData.Margin = new Padding(2, 3, 2, 3);
            dbData.Name = "dbData";
            dbData.ReadOnly = true;
            dbData.RowHeadersWidth = 62;
            dbData.RowTemplate.Height = 33;
            dbData.Size = new Size(1027, 513);
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
            panel3.Location = new Point(0, 530);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1027, 31);
            panel3.TabIndex = 2;
            // 
            // lblCatalog
            // 
            lblCatalog.AutoSize = true;
            lblCatalog.Location = new Point(329, 6);
            lblCatalog.Name = "lblCatalog";
            lblCatalog.Size = new Size(50, 20);
            lblCatalog.TabIndex = 5;
            lblCatalog.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 5);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Catalog:";
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(67, 7);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(50, 20);
            lblServer.TabIndex = 3;
            lblServer.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 6);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Server:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(569, 6);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(50, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(524, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "User:";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 561);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoRepsol";
            WindowState = FormWindowState.Maximized;
            FormClosing += CLoseApp;
            panel1.ResumeLayout(false);
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
    }
}