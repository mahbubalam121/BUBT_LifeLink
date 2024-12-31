namespace Blood
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            Myprogress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label1 = new Label();
            Myprogress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Myprogress
            // 
            Myprogress.Controls.Add(pictureBox1);
            Myprogress.FillColor = Color.FromArgb(200, 213, 218, 223);
            Myprogress.FillThickness = 8;
            Myprogress.Font = new Font("Segoe UI", 12F);
            Myprogress.ForeColor = Color.White;
            Myprogress.Location = new Point(545, 228);
            Myprogress.Minimum = 0;
            Myprogress.Name = "Myprogress";
            Myprogress.ProgressColor = Color.Brown;
            Myprogress.ProgressColor2 = Color.Brown;
            Myprogress.ProgressThickness = 10;
            Myprogress.ShadowDecoration.CustomizableEdges = customizableEdges1;
            Myprogress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Myprogress.Size = new Size(214, 214);
            Myprogress.TabIndex = 2;
            Myprogress.Text = "guna2CircleProgressBar1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 18;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1052, 561);
            label2.Name = "label2";
            label2.Size = new Size(116, 39);
            label2.TabIndex = 3;
            label2.Text = "Depressed5";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(426, 59);
            label1.Name = "label1";
            label1.Size = new Size(444, 122);
            label1.TabIndex = 1;
            label1.Text = "BUBT-LifeLink";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 646);
            Controls.Add(label2);
            Controls.Add(Myprogress);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Splash_Load;
            Myprogress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleProgressBar Myprogress;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label1;
    }
}