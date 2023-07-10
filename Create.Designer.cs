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
            dbRegulariza = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            dbQuery = new RichTextBox();
            dbTipo = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // dbDetalle
            // 
            dbDetalle.Location = new Point(32, 94);
            dbDetalle.Margin = new Padding(4);
            dbDetalle.Name = "dbDetalle";
            dbDetalle.Size = new Size(1130, 31);
            dbDetalle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 1;
            label1.Text = "Detalle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 161);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 2;
            label2.Text = "Vertical";
            // 
            // dbVertical
            // 
            dbVertical.FormattingEnabled = true;
            dbVertical.Location = new Point(34, 194);
            dbVertical.Margin = new Padding(4);
            dbVertical.Name = "dbVertical";
            dbVertical.Size = new Size(403, 33);
            dbVertical.TabIndex = 3;
            // 
            // dbRegulariza
            // 
            dbRegulariza.FormattingEnabled = true;
            dbRegulariza.Items.AddRange(new object[] { "Si", "No" });
            dbRegulariza.Location = new Point(500, 194);
            dbRegulariza.Margin = new Padding(4);
            dbRegulariza.Name = "dbRegulariza";
            dbRegulariza.Size = new Size(188, 33);
            dbRegulariza.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 161);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 5;
            label3.Text = "Regulariza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 276);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 6;
            label4.Text = "Consulta SQL";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1086, 704);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 36);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += createCase;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(946, 704);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += closeCreateForm;
            // 
            // dbQuery
            // 
            dbQuery.BorderStyle = BorderStyle.None;
            dbQuery.Location = new Point(40, 305);
            dbQuery.Margin = new Padding(4);
            dbQuery.Name = "dbQuery";
            dbQuery.Size = new Size(1162, 368);
            dbQuery.TabIndex = 10;
            dbQuery.Text = "";
            // 
            // dbTipo
            // 
            dbTipo.FormattingEnabled = true;
            dbTipo.Items.AddRange(new object[] { "Logs General", "Riesgos", "Riesgos Tarde", "Riesgos Tarde Viernes", "Riesgos Mañana Sabado", "Riesgos Tarde Sabado", "Pre Bajada", "Facturacion", "Precios", "Otros", "Resultados KPIS", "Fletamentos", "Demoras" });
            dbTipo.Location = new Point(757, 194);
            dbTipo.Name = "dbTipo";
            dbTipo.Size = new Size(386, 33);
            dbTipo.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(757, 161);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 12;
            label5.Text = "Tipo Script";
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1266, 780);
            Controls.Add(label5);
            Controls.Add(dbTipo);
            Controls.Add(dbQuery);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dbRegulariza);
            Controls.Add(dbVertical);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dbDetalle);
            Margin = new Padding(4);
            Name = "Create";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Regulariza";
            FormClosing += CLoseApp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dbDetalle;
        private Label label1;
        private Label label2;
        private ComboBox dbVertical;
        private ComboBox dbRegulariza;
        private Label label3;
        private Label label4;
        private Button btnSave;
        private Button btnCancel;
        private RichTextBox dbQuery;
        private ComboBox dbTipo;
        private Label label5;
    }
}