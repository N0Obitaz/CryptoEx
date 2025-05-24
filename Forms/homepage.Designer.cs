namespace WebSocketStreamingWithUI
{
    partial class homepage
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            logpanel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(guna2PictureBox1);
            guna2GradientPanel1.Controls.Add(guna2ControlBox1);
            guna2GradientPanel1.Controls.Add(logpanel1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges7;
            guna2GradientPanel1.Dock = DockStyle.Fill;
            guna2GradientPanel1.FillColor = Color.FromArgb(54, 55, 57);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(24, 25, 27);
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2GradientPanel1.Size = new Size(1288, 747);
            guna2GradientPanel1.TabIndex = 0;
            guna2GradientPanel1.Paint += guna2GradientPanel1_Paint;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(110, 71);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(500, 619);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 2;
            guna2PictureBox1.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges3;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(1220, 12);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox1.Size = new Size(56, 36);
            guna2ControlBox1.TabIndex = 1;
            guna2ControlBox1.Click += guna2ControlBox1_Click;
            // 
            // logpanel1
            // 
            logpanel1.BackColor = Color.Transparent;
            logpanel1.BorderColor = Color.White;
            logpanel1.BorderThickness = 2;
            logpanel1.CustomizableEdges = customizableEdges5;
            logpanel1.Location = new Point(718, 71);
            logpanel1.Name = "logpanel1";
            logpanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            logpanel1.Size = new Size(503, 619);
            logpanel1.TabIndex = 0;
            logpanel1.Paint += logpanel1_Paint;
            // 
            // homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 747);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "homepage";
            Load += homepage_Load;
            guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel logpanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}