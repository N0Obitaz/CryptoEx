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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            walletLabel = new Label();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            exchangePanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2CustomGradientPanel1.SuspendLayout();
            exchangePanel.SuspendLayout();
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
            guna2CustomGradientPanel1.Location = new Point(260, 90);
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
            walletLabel.Click += walletLabel_Click;
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
            // exchangePanel
            // 
            exchangePanel.BackColor = Color.Transparent;
            exchangePanel.BorderColor = Color.White;
            exchangePanel.BorderRadius = 20;
            exchangePanel.Controls.Add(guna2CustomGradientPanel1);
            exchangePanel.CustomizableEdges = customizableEdges3;
            exchangePanel.FillColor = Color.FromArgb(60, 63, 64);
            exchangePanel.FillColor2 = Color.FromArgb(60, 63, 64);
            exchangePanel.Location = new Point(0, 0);
            exchangePanel.Name = "exchangePanel";
            exchangePanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            exchangePanel.Size = new Size(1136, 733);
            exchangePanel.TabIndex = 72;
            // 
            // UC_Buy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(exchangePanel);
            Name = "UC_Buy";
            Size = new Size(1142, 743);
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            exchangePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        public Label walletLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel exchangePanel;
    }
}
