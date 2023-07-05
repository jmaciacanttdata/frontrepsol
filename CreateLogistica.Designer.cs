﻿namespace AutoRepsol
{
    partial class CreateLogistica
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
            label1 = new Label();
            dbDetalle = new TextBox();
            dbVertical = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dbTablaTemporal = new TextBox();
            label5 = new Label();
            dbURL = new TextBox();
            label4 = new Label();
            dbQuery = new RichTextBox();
            btnCancel = new Button();
            btnSave = new Button();
            dbXML = new RichTextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 3;
            label1.Text = "Detalle";
            // 
            // dbDetalle
            // 
            dbDetalle.Location = new Point(13, 89);
            dbDetalle.Margin = new Padding(4);
            dbDetalle.Name = "dbDetalle";
            dbDetalle.Size = new Size(651, 31);
            dbDetalle.TabIndex = 2;
            // 
            // dbVertical
            // 
            dbVertical.FormattingEnabled = true;
            dbVertical.Location = new Point(824, 89);
            dbVertical.Margin = new Padding(4);
            dbVertical.Name = "dbVertical";
            dbVertical.Size = new Size(482, 33);
            dbVertical.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(824, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 4;
            label2.Text = "Vertical";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 147);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 14;
            label3.Text = "Nombre Tabla Temporal";
            // 
            // dbTablaTemporal
            // 
            dbTablaTemporal.Location = new Point(13, 183);
            dbTablaTemporal.Margin = new Padding(4);
            dbTablaTemporal.Name = "dbTablaTemporal";
            dbTablaTemporal.Size = new Size(651, 31);
            dbTablaTemporal.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(824, 149);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 16;
            label5.Text = "URL";
            // 
            // dbURL
            // 
            dbURL.Location = new Point(824, 185);
            dbURL.Margin = new Padding(4);
            dbURL.Name = "dbURL";
            dbURL.Size = new Size(482, 31);
            dbURL.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 238);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 11;
            label4.Text = "Consulta SQL";
            // 
            // dbQuery
            // 
            dbQuery.BorderStyle = BorderStyle.None;
            dbQuery.Location = new Point(13, 267);
            dbQuery.Margin = new Padding(4);
            dbQuery.Name = "dbQuery";
            dbQuery.Size = new Size(1274, 366);
            dbQuery.TabIndex = 12;
            dbQuery.Text = "";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1017, 1085);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1169, 1085);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 36);
            btnSave.TabIndex = 19;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dbXML
            // 
            dbXML.BorderStyle = BorderStyle.None;
            dbXML.Location = new Point(13, 685);
            dbXML.Margin = new Padding(4);
            dbXML.Name = "dbXML";
            dbXML.Size = new Size(1274, 365);
            dbXML.TabIndex = 24;
            dbXML.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 656);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 23;
            label6.Text = "Estructura XML";
            // 
            // CreateLogistica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 1136);
            Controls.Add(dbXML);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(dbURL);
            Controls.Add(label3);
            Controls.Add(dbTablaTemporal);
            Controls.Add(dbQuery);
            Controls.Add(label4);
            Controls.Add(dbVertical);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dbDetalle);
            Name = "CreateLogistica";
            Text = "CreateLogistica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox dbDetalle;
        private ComboBox dbVertical;
        private Label label2;
        private Label label3;
        private TextBox dbTablaTemporal;
        private Label label5;
        private TextBox dbURL;
        private Label label4;
        private RichTextBox dbQuery;
        private Button btnCancel;
        private Button btnSave;
        private RichTextBox dbXML;
        private Label label6;
    }
}