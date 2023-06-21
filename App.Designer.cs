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
            btnRefresh = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dbData).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnCreate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 60);
            panel1.TabIndex = 0;
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
            dbData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbData.Dock = DockStyle.Fill;
            dbData.Location = new Point(0, 0);
            dbData.Margin = new Padding(2, 4, 2, 4);
            dbData.Name = "dbData";
            dbData.ReadOnly = true;
            dbData.RowHeadersWidth = 62;
            dbData.RowTemplate.Height = 33;
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
            lblCatalog.Location = new Point(411, 8);
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
            lblServer.Location = new Point(84, 9);
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
            lblUserName.Location = new Point(711, 8);
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
            // btnRefresh
            // 
            btnRefresh.Location = new Point(255, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 33);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Actualizar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
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
        private Button btnRefresh;
    }
}