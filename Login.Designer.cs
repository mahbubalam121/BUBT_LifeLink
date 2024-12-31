namespace Blood
{
    partial class login2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login2));
            label1 = new Label();
            EmpPassTb = new TextBox();
            label3 = new Label();
            EmpIdTb = new TextBox();
            label2 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(469, 59);
            label1.Name = "label1";
            label1.Size = new Size(379, 81);
            label1.TabIndex = 2;
            label1.Text = "BUBT-LifeLink";
            // 
            // EmpPassTb
            // 
            EmpPassTb.Location = new Point(594, 306);
            EmpPassTb.Name = "EmpPassTb";
            EmpPassTb.Size = new Size(264, 23);
            EmpPassTb.TabIndex = 10;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(429, 306);
            label3.Name = "label3";
            label3.Size = new Size(135, 48);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // EmpIdTb
            // 
            EmpIdTb.AccessibleRole = AccessibleRole.None;
            EmpIdTb.Location = new Point(594, 254);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(264, 23);
            EmpIdTb.TabIndex = 8;
            EmpIdTb.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(429, 254);
            label2.Name = "label2";
            label2.Size = new Size(159, 43);
            label2.TabIndex = 7;
            label2.Text = "User Name";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Brown;
            guna2Button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(611, 359);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(173, 46);
            guna2Button1.TabIndex = 52;
            guna2Button1.Text = "Login";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(594, 450);
            label4.Name = "label4";
            label4.Size = new Size(205, 30);
            label4.TabIndex = 53;
            label4.Text = "Continue As Admin";
            label4.Click += label4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1169, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 55;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1220, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // login2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1261, 646);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(guna2Button1);
            Controls.Add(EmpPassTb);
            Controls.Add(label3);
            Controls.Add(EmpIdTb);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login2";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox EmpPassTb;
        private Label label3;
        private TextBox EmpIdTb;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}