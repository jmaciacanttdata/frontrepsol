namespace AutoRepsol
{
    partial class Create
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
            dbDetalle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dbVertical = new ComboBox();
            dbActivo = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            dbQuery = new RichTextBox();
            SuspendLayout();
            // 
            // dbDetalle
            // 
            dbDetalle.Location = new Point(23, 69);
            dbDetalle.Name = "dbDetalle";
            dbDetalle.Size = new Size(939, 27);
            dbDetalle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 40);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Detalle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 129);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Vertical";
            // 
            // dbVertical
            // 
            dbVertical.FormattingEnabled = true;
            dbVertical.Items.AddRange(new object[] { "BO - Backoffice", "FO - Frontoffice", "FA - Facturación", "PM - Pricing", "LO - Logística" });
            dbVertical.Location = new Point(27, 155);
            dbVertical.Name = "dbVertical";
            dbVertical.Size = new Size(323, 28);
            dbVertical.TabIndex = 3;
            // 
            // dbActivo
            // 
            dbActivo.FormattingEnabled = true;
            dbActivo.Items.AddRange(new object[] { "Si", "No" });
            dbActivo.Location = new Point(400, 155);
            dbActivo.Name = "dbActivo";
            dbActivo.Size = new Size(151, 28);
            dbActivo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 129);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 5;
            label3.Text = "Activo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 221);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 6;
            label4.Text = "Consulta SQL";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(869, 563);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += createCase;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(757, 563);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += closeCreateForm;
            // 
            // dbQuery
            // 
            dbQuery.BorderStyle = BorderStyle.None;
            dbQuery.Location = new Point(32, 244);
            dbQuery.Name = "dbQuery";
            dbQuery.Size = new Size(930, 294);
            dbQuery.TabIndex = 10;
            dbQuery.Text = "";
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1013, 624);
            Controls.Add(dbQuery);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dbActivo);
            Controls.Add(dbVertical);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dbDetalle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Create";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dbDetalle;
        private Label label1;
        private Label label2;
        private ComboBox dbVertical;
        private ComboBox dbActivo;
        private Label label3;
        private Label label4;
        private Button btnSave;
        private Button btnCancel;
        private RichTextBox dbQuery;
    }
}