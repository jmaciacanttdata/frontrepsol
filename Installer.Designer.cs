namespace AutoRepsol
{
    partial class Installer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installer));
            pictureBox1 = new PictureBox();
            iprogress = new ProgressBar();
            labelInstall = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 291);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // iprogress
            // 
            iprogress.Dock = DockStyle.Bottom;
            iprogress.Location = new Point(0, 416);
            iprogress.Name = "iprogress";
            iprogress.Size = new Size(800, 34);
            iprogress.TabIndex = 1;
            // 
            // labelInstall
            // 
            labelInstall.AutoSize = true;
            labelInstall.Dock = DockStyle.Bottom;
            labelInstall.Location = new Point(0, 391);
            labelInstall.Name = "labelInstall";
            labelInstall.Size = new Size(179, 25);
            labelInstall.TabIndex = 2;
            labelInstall.Text = "Iniciando aplicación...";
            labelInstall.TextAlign = ContentAlignment.TopCenter;
            // 
            // Installer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelInstall);
            Controls.Add(iprogress);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Installer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Installer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar iprogress;
        private Label labelInstall;
    }
}