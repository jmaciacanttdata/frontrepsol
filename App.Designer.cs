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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 36);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(91, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += deleteCase;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(8, 7);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(78, 20);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += openCreateForm;
            // 
            // panel2
            // 
            panel2.Controls.Add(dbData);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 36);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(899, 385);
            panel2.TabIndex = 1;
            // 
            // dbData
            // 
            dbData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbData.Dock = DockStyle.Fill;
            dbData.Location = new Point(0, 0);
            dbData.Margin = new Padding(2);
            dbData.Name = "dbData";
            dbData.ReadOnly = true;
            dbData.RowHeadersWidth = 62;
            dbData.RowTemplate.Height = 33;
            dbData.Size = new Size(899, 385);
            dbData.TabIndex = 3;
            dbData.CellDoubleClick += GetItemData;
            dbData.RowStateChanged += enableDisableDelete;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblServer);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblUserName);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 398);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(899, 23);
            panel3.TabIndex = 2;
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(209, 4);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(38, 15);
            lblServer.TabIndex = 3;
            lblServer.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 4);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Server:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(48, 4);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(38, 15);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "User:";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 421);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
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
    }
}