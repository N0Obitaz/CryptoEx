namespace WebSocketStreamingWithUI.UserControls
{
    partial class UC_Wallet
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            walletPanel = new Guna.UI2.WinForms.Guna2Panel();
            sellButton = new Guna.UI2.WinForms.Guna2Button();
            buyButton = new Guna.UI2.WinForms.Guna2Button();
            withdrawButton = new Guna.UI2.WinForms.Guna2Button();
            depositButton = new Guna.UI2.WinForms.Guna2Button();
            balance = new Label();
            myBalanceLabel = new Label();
            guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            walletPanel.SuspendLayout();
            SuspendLayout();
            // 
            // walletPanel
            // 
            walletPanel.BorderRadius = 20;
            walletPanel.Controls.Add(sellButton);
            walletPanel.Controls.Add(buyButton);
            walletPanel.Controls.Add(withdrawButton);
            walletPanel.Controls.Add(depositButton);
            walletPanel.Controls.Add(balance);
            walletPanel.Controls.Add(myBalanceLabel);
            walletPanel.Controls.Add(guna2Separator4);
            walletPanel.CustomizableEdges = customizableEdges9;
            walletPanel.FillColor = Color.White;
            walletPanel.Location = new Point(0, 0);
            walletPanel.Name = "walletPanel";
            walletPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            walletPanel.Size = new Size(325, 226);
            walletPanel.TabIndex = 0;
            // 
            // sellButton
            // 
            sellButton.BackColor = Color.White;
            sellButton.BorderRadius = 15;
            sellButton.Cursor = Cursors.Hand;
            sellButton.CustomizableEdges = customizableEdges1;
            sellButton.DisabledState.BorderColor = Color.DarkGray;
            sellButton.DisabledState.CustomBorderColor = Color.DarkGray;
            sellButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            sellButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            sellButton.FillColor = Color.IndianRed;
            sellButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sellButton.ForeColor = Color.Black;
            sellButton.Location = new Point(237, 10);
            sellButton.Name = "sellButton";
            sellButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            sellButton.Size = new Size(75, 29);
            sellButton.TabIndex = 50;
            sellButton.Text = "Sell";
            // 
            // buyButton
            // 
            buyButton.BackColor = Color.White;
            buyButton.BorderRadius = 15;
            buyButton.Cursor = Cursors.Hand;
            buyButton.CustomizableEdges = customizableEdges3;
            buyButton.DisabledState.BorderColor = Color.DarkGray;
            buyButton.DisabledState.CustomBorderColor = Color.DarkGray;
            buyButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buyButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buyButton.FillColor = Color.PaleGreen;
            buyButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buyButton.ForeColor = Color.Black;
            buyButton.Location = new Point(154, 11);
            buyButton.Name = "buyButton";
            buyButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            buyButton.Size = new Size(75, 29);
            buyButton.TabIndex = 49;
            buyButton.Text = "Buy";
            // 
            // withdrawButton
            // 
            withdrawButton.BackColor = Color.White;
            withdrawButton.BorderRadius = 15;
            withdrawButton.Cursor = Cursors.Hand;
            withdrawButton.CustomizableEdges = customizableEdges5;
            withdrawButton.DisabledState.BorderColor = Color.DarkGray;
            withdrawButton.DisabledState.CustomBorderColor = Color.DarkGray;
            withdrawButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            withdrawButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            withdrawButton.FillColor = Color.CornflowerBlue;
            withdrawButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withdrawButton.ForeColor = Color.Black;
            withdrawButton.Location = new Point(167, 167);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            withdrawButton.Size = new Size(128, 39);
            withdrawButton.TabIndex = 48;
            withdrawButton.Text = "Withdraw";
            // 
            // depositButton
            // 
            depositButton.BackColor = Color.White;
            depositButton.BorderRadius = 15;
            depositButton.Cursor = Cursors.Hand;
            depositButton.CustomizableEdges = customizableEdges7;
            depositButton.DisabledState.BorderColor = Color.DarkGray;
            depositButton.DisabledState.CustomBorderColor = Color.DarkGray;
            depositButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            depositButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            depositButton.FillColor = Color.PaleGreen;
            depositButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositButton.ForeColor = Color.Black;
            depositButton.Location = new Point(33, 167);
            depositButton.Name = "depositButton";
            depositButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            depositButton.Size = new Size(128, 39);
            depositButton.TabIndex = 44;
            depositButton.Text = "Deposit";
            // 
            // balance
            // 
            balance.AutoSize = true;
            balance.BackColor = Color.White;
            balance.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            balance.Location = new Point(108, 100);
            balance.Name = "balance";
            balance.Size = new Size(109, 27);
            balance.TabIndex = 47;
            balance.Text = "Fetching";
            // 
            // myBalanceLabel
            // 
            myBalanceLabel.AutoSize = true;
            myBalanceLabel.BackColor = Color.White;
            myBalanceLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myBalanceLabel.Location = new Point(16, 14);
            myBalanceLabel.Name = "myBalanceLabel";
            myBalanceLabel.Size = new Size(114, 22);
            myBalanceLabel.TabIndex = 46;
            myBalanceLabel.Text = "My Balance";
            // 
            // guna2Separator4
            // 
            guna2Separator4.BackColor = Color.White;
            guna2Separator4.FillColor = Color.Black;
            guna2Separator4.FillThickness = 2;
            guna2Separator4.Location = new Point(0, 43);
            guna2Separator4.Name = "guna2Separator4";
            guna2Separator4.Size = new Size(324, 10);
            guna2Separator4.TabIndex = 45;
            // 
            // UC_Wallet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(walletPanel);
            Name = "UC_Wallet";
            Size = new Size(362, 246);
            walletPanel.ResumeLayout(false);
            walletPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel walletPanel;
        private Guna.UI2.WinForms.Guna2Button sellButton;
        private Guna.UI2.WinForms.Guna2Button buyButton;
        private Guna.UI2.WinForms.Guna2Button withdrawButton;
        private Guna.UI2.WinForms.Guna2Button depositButton;
        private Label balance;
        private Label myBalanceLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
    }
}
