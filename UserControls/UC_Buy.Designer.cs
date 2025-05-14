namespace WebSocketStreamingWithUI.UserControls
{
    partial class UC_Buy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            walletLabel = new Label();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BorderRadius = 15;
            guna2CustomGradientPanel1.Controls.Add(walletLabel);
            guna2CustomGradientPanel1.Controls.Add(guna2Separator2);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.FillColor = Color.PaleTurquoise;
            guna2CustomGradientPanel1.FillColor2 = Color.Teal;
            guna2CustomGradientPanel1.FillColor3 = Color.LightBlue;
            guna2CustomGradientPanel1.FillColor4 = Color.LightGray;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(617, 579);
            guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // walletLabel
            // 
            walletLabel.AutoSize = true;
            walletLabel.BackColor = Color.Transparent;
            walletLabel.FlatStyle = FlatStyle.Popup;
            walletLabel.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            walletLabel.Location = new Point(35, 22);
            walletLabel.Margin = new Padding(0);
            walletLabel.Name = "walletLabel";
            walletLabel.Size = new Size(82, 27);
            walletLabel.TabIndex = 69;
            walletLabel.Text = "Wallet";
            walletLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Separator2
            // 
            guna2Separator2.BackColor = Color.Transparent;
            guna2Separator2.FillColor = Color.Black;
            guna2Separator2.FillThickness = 2;
            guna2Separator2.Location = new Point(-3, 52);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new Size(641, 10);
            guna2Separator2.TabIndex = 37;
            // 
            // UC_Buy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2CustomGradientPanel1);
            Name = "UC_Buy";
            Size = new Size(641, 609);
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        public Label walletLabel;
    }
}
