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
            btnCancel = new Button();
            btnSave = new Button();
            dbQuery = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dbActivo = new ComboBox();
            dbVertical = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dbDetalle = new TextBox();
            dbIdCase = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(674, 419);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += closeEditForm;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(772, 419);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 18;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += saveEditCase;
            // 
            // dbQuery
            // 
            dbQuery.Location = new Point(40, 183);
            dbQuery.Margin = new Padding(3, 2, 3, 2);
            dbQuery.Multiline = true;
            dbQuery.Name = "dbQuery";
            dbQuery.Size = new Size(814, 206);
            dbQuery.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 163);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 16;
            label4.Text = "Consulta SQL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 94);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 15;
            label3.Text = "Activo";
            // 
            // dbActivo
            // 
            dbActivo.FormattingEnabled = true;
            dbActivo.Items.AddRange(new object[] { "Si", "No" });
            dbActivo.Location = new Point(362, 113);
            dbActivo.Margin = new Padding(3, 2, 3, 2);
            dbActivo.Name = "dbActivo";
            dbActivo.Size = new Size(133, 23);
            dbActivo.TabIndex = 14;
            // 
            // dbVertical
            // 
            dbVertical.FormattingEnabled = true;
            dbVertical.Items.AddRange(new object[] { "BO - Backoffice", "FO - Frontoffice", "FA - Facturación", "PM - Pricing", "LO - Logística" });
            dbVertical.Location = new Point(36, 113);
            dbVertical.Margin = new Padding(3, 2, 3, 2);
            dbVertical.Name = "dbVertical";
            dbVertical.Size = new Size(283, 23);
            dbVertical.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 94);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 12;
            label2.Text = "Vertical";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 11;
            label1.Text = "Detalle";
            // 
            // dbDetalle
            // 
            dbDetalle.Location = new Point(32, 49);
            dbDetalle.Margin = new Padding(3, 2, 3, 2);
            dbDetalle.Name = "dbDetalle";
            dbDetalle.Size = new Size(822, 23);
            dbDetalle.TabIndex = 10;
            // 
            // dbIdCase
            // 
            dbIdCase.Location = new Point(554, 418);
            dbIdCase.Name = "dbIdCase";
            dbIdCase.Size = new Size(100, 23);
            dbIdCase.TabIndex = 20;
            dbIdCase.Visible = false;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(886, 468);
            Controls.Add(dbIdCase);
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
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox dbQuery;
        private Label label4;
        private Label label3;
        private ComboBox dbActivo;
        private ComboBox dbVertical;
        private Label label2;
        private Label label1;
        private TextBox dbDetalle;
        private TextBox dbIdCase;
    }
}