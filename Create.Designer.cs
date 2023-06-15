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
            dbQuery = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // dbDetalle
            // 
            dbDetalle.Location = new Point(20, 52);
            dbDetalle.Margin = new Padding(3, 2, 3, 2);
            dbDetalle.Name = "dbDetalle";
            dbDetalle.Size = new Size(822, 23);
            dbDetalle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Detalle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 97);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Vertical";
            // 
            // dbVertical
            // 
            dbVertical.FormattingEnabled = true;
            dbVertical.Items.AddRange(new object[] { "BO - Backoffice", "FO - Frontoffice", "FA - Facturación", "PM - Pricing", "LO - Logística" });
            dbVertical.Location = new Point(24, 116);
            dbVertical.Margin = new Padding(3, 2, 3, 2);
            dbVertical.Name = "dbVertical";
            dbVertical.Size = new Size(283, 23);
            dbVertical.TabIndex = 3;
            // 
            // dbActivo
            // 
            dbActivo.FormattingEnabled = true;
            dbActivo.Items.AddRange(new object[] { "Si", "No" });
            dbActivo.Location = new Point(350, 116);
            dbActivo.Margin = new Padding(3, 2, 3, 2);
            dbActivo.Name = "dbActivo";
            dbActivo.Size = new Size(133, 23);
            dbActivo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 97);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "Activo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 166);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 6;
            label4.Text = "Consulta SQL";
            // 
            // dbQuery
            // 
            dbQuery.Location = new Point(28, 186);
            dbQuery.Margin = new Padding(3, 2, 3, 2);
            dbQuery.Multiline = true;
            dbQuery.Name = "dbQuery";
            dbQuery.Size = new Size(814, 206);
            dbQuery.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(760, 422);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += createCase;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(662, 422);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += closeCreateForm;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(886, 468);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dbQuery);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dbActivo);
            Controls.Add(dbVertical);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dbDetalle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox dbQuery;
        private Button btnSave;
        private Button btnCancel;
    }
}