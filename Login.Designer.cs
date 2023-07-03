namespace AutoRepsol
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            dbUser = new TextBox();
            dbPassword = new TextBox();
            lblUser = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            lblClose = new Label();
            dbConnectionResult = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dbUser
            // 
            dbUser.Location = new Point(42, 235);
            dbUser.Margin = new Padding(2);
            dbUser.Name = "dbUser";
            dbUser.Size = new Size(316, 31);
            dbUser.TabIndex = 0;
            // 
            // dbPassword
            // 
            dbPassword.Location = new Point(42, 298);
            dbPassword.Margin = new Padding(2);
            dbPassword.Name = "dbPassword";
            dbPassword.PasswordChar = '*';
            dbPassword.Size = new Size(316, 31);
            dbPassword.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.ForeColor = Color.MidnightBlue;
            lblUser.Location = new Point(42, 207);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(72, 25);
            lblUser.TabIndex = 2;
            lblUser.Text = "Usuario";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.MidnightBlue;
            lblPassword.Location = new Point(42, 269);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.InactiveCaption;
            btnLogin.FlatStyle = FlatStyle.System;
            btnLogin.Location = new Point(132, 375);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 48);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += LoginDB;
            // 
            // lblClose
            // 
            lblClose.BackColor = SystemColors.Control;
            lblClose.Image = (Image)resources.GetObject("lblClose.Image");
            lblClose.Location = new Point(352, 6);
            lblClose.Margin = new Padding(2, 0, 2, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(40, 38);
            lblClose.TabIndex = 6;
            lblClose.Text = " ";
            lblClose.Click += CloseApp;
            // 
            // dbConnectionResult
            // 
            dbConnectionResult.AutoSize = true;
            dbConnectionResult.BackColor = Color.Transparent;
            dbConnectionResult.Dock = DockStyle.Bottom;
            dbConnectionResult.ForeColor = Color.Red;
            dbConnectionResult.Location = new Point(0, 469);
            dbConnectionResult.Margin = new Padding(4, 0, 4, 0);
            dbConnectionResult.Name = "dbConnectionResult";
            dbConnectionResult.Size = new Size(59, 25);
            dbConnectionResult.TabIndex = 7;
            dbConnectionResult.Text = "label1";
            dbConnectionResult.TextAlign = ContentAlignment.MiddleCenter;
            dbConnectionResult.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(398, 494);
            Controls.Add(pictureBox1);
            Controls.Add(dbConnectionResult);
            Controls.Add(lblClose);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Controls.Add(dbPassword);
            Controls.Add(dbUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dbUser;
        private TextBox dbPassword;
        private Label lblUser;
        private Label lblPassword;
        private Button btnLogin;
        private Label lblClose;
        private Label dbConnectionResult;
        private PictureBox pictureBox1;
    }
}