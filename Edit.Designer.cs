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
            dbRegulariza = new ComboBox();
            dbVertical = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dbDetalle = new TextBox();
            dbIdCase = new TextBox();
            dbTipo = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(963, 698);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 37);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += closeEditForm;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1103, 698);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 37);
            btnSave.TabIndex = 18;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += saveEditCase;
            // 
            // dbQuery
            // 
            dbQuery.Location = new Point(46, 300);
            dbQuery.Margin = new Padding(4, 3, 4, 3);
            dbQuery.Multiline = true;
            dbQuery.Name = "dbQuery";
            dbQuery.Size = new Size(1161, 341);
            dbQuery.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 272);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 16;
            label4.Text = "Consulta SQL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 157);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 15;
            label3.Text = "Regulariza";
            // 
            // dbRegulariza
            // 
            dbRegulariza.FormattingEnabled = true;
            dbRegulariza.Items.AddRange(new object[] { "Si", "No" });
            dbRegulariza.Location = new Point(517, 188);
            dbRegulariza.Margin = new Padding(4, 3, 4, 3);
            dbRegulariza.Name = "dbRegulariza";
            dbRegulariza.Size = new Size(188, 33);
            dbRegulariza.TabIndex = 14;
            // 
            // dbVertical
            // 
            dbVertical.FormattingEnabled = true;
            dbVertical.Items.AddRange(new object[] { "BO - Backoffice", "FO - Frontoffice", "FA - Facturación", "PM - Pricing", "LO - Logística" });
            dbVertical.Location = new Point(46, 188);
            dbVertical.Margin = new Padding(4, 3, 4, 3);
            dbVertical.Name = "dbVertical";
            dbVertical.Size = new Size(408, 33);
            dbVertical.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 157);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 12;
            label2.Text = "Vertical";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 11;
            label1.Text = "Detalle";
            // 
            // dbDetalle
            // 
            dbDetalle.Location = new Point(46, 82);
            dbDetalle.Margin = new Padding(4, 3, 4, 3);
            dbDetalle.Name = "dbDetalle";
            dbDetalle.Size = new Size(1161, 31);
            dbDetalle.TabIndex = 10;
            // 
            // dbIdCase
            // 
            dbIdCase.Location = new Point(791, 697);
            dbIdCase.Margin = new Padding(4, 5, 4, 5);
            dbIdCase.Name = "dbIdCase";
            dbIdCase.Size = new Size(141, 31);
            dbIdCase.TabIndex = 20;
            dbIdCase.Visible = false;
            // 
            // dbTipo
            // 
            dbTipo.DropDownWidth = 386;
            dbTipo.FormattingEnabled = true;
            dbTipo.Location = new Point(782, 188);
            dbTipo.Name = "dbTipo";
            dbTipo.Size = new Size(425, 33);
            dbTipo.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(782, 157);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 22;
            label5.Text = "Tipo Script";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1266, 780);
            Controls.Add(label5);
            Controls.Add(dbTipo);
            Controls.Add(dbIdCase);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dbQuery);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dbRegulariza);
            Controls.Add(dbVertical);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dbDetalle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            FormClosing += CLoseApp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox dbQuery;
        private Label label4;
        private Label label3;
        private ComboBox dbRegulariza;
        private ComboBox dbVertical;
        private Label label2;
        private Label label1;
        private TextBox dbDetalle;
        private TextBox dbIdCase;
        private ComboBox dbTipo;
        private Label label5;
    }
}