namespace WebSocketStreamingWithUI.UserControls
{
    partial class UC_Deposit
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            convertPanel = new Guna.UI2.WinForms.Guna2Panel();
            depositConfirmButton = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            amountLabel = new Guna.UI2.WinForms.Guna2TextBox();
            enterAmount = new Label();
            Deposit = new Label();
            convertPanel.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // convertPanel
            // 
            convertPanel.BorderRadius = 20;
            convertPanel.Controls.Add(depositConfirmButton);
            convertPanel.Controls.Add(guna2Panel2);
            convertPanel.CustomizableEdges = customizableEdges7;
            convertPanel.FillColor = Color.FromArgb(60, 63, 64);
            convertPanel.Location = new Point(58, 62);
            convertPanel.Name = "convertPanel";
            convertPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            convertPanel.Size = new Size(539, 522);
            convertPanel.TabIndex = 75;
            // 
            // depositConfirmButton
            // 
            depositConfirmButton.BackColor = Color.Transparent;
            depositConfirmButton.BorderRadius = 20;
            depositConfirmButton.Cursor = Cursors.Hand;
            depositConfirmButton.CustomizableEdges = customizableEdges1;
            depositConfirmButton.DisabledState.BorderColor = Color.DarkGray;
            depositConfirmButton.DisabledState.CustomBorderColor = Color.DarkGray;
            depositConfirmButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            depositConfirmButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            depositConfirmButton.FillColor = Color.MediumSpringGreen;
            depositConfirmButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositConfirmButton.ForeColor = Color.White;
            depositConfirmButton.Location = new Point(25, 396);
            depositConfirmButton.Name = "depositConfirmButton";
            depositConfirmButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            depositConfirmButton.Size = new Size(468, 65);
            depositConfirmButton.TabIndex = 74;
            depositConfirmButton.Text = "Deposit";
            depositConfirmButton.Click += depositConfirmButton_Click;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BorderColor = Color.Transparent;
            guna2Panel2.BorderRadius = 20;
            guna2Panel2.Controls.Add(amountLabel);
            guna2Panel2.Controls.Add(enterAmount);
            guna2Panel2.CustomizableEdges = customizableEdges5;
            guna2Panel2.FillColor = Color.FromArgb(34, 35, 37);
            guna2Panel2.Location = new Point(25, 33);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel2.Size = new Size(468, 331);
            guna2Panel2.TabIndex = 82;
            // 
            // amountLabel
            // 
            amountLabel.BackColor = Color.Transparent;
            amountLabel.BorderRadius = 15;
            amountLabel.BorderThickness = 0;
            amountLabel.Cursor = Cursors.IBeam;
            amountLabel.CustomizableEdges = customizableEdges3;
            amountLabel.DefaultText = "";
            amountLabel.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            amountLabel.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            amountLabel.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            amountLabel.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            amountLabel.FillColor = SystemColors.Control;
            amountLabel.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            amountLabel.Font = new Font("Century Gothic", 25F, FontStyle.Bold);
            amountLabel.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            amountLabel.Location = new Point(44, 130);
            amountLabel.Margin = new Padding(4);
            amountLabel.Name = "amountLabel";
            amountLabel.PlaceholderForeColor = SystemColors.ControlDarkDark;
            amountLabel.PlaceholderText = "0";
            amountLabel.SelectedText = "";
            amountLabel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            amountLabel.Size = new Size(380, 92);
            amountLabel.TabIndex = 85;
            amountLabel.TextChanged += amountLabel_TextChanged;
            // 
            // enterAmount
            // 
            enterAmount.AutoSize = true;
            enterAmount.BackColor = Color.Transparent;
            enterAmount.FlatStyle = FlatStyle.Popup;
            enterAmount.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            enterAmount.ForeColor = SystemColors.ControlLight;
            enterAmount.Location = new Point(23, 65);
            enterAmount.Margin = new Padding(0);
            enterAmount.Name = "enterAmount";
            enterAmount.Size = new Size(206, 23);
            enterAmount.TabIndex = 72;
            enterAmount.Text = "Enter Amount in USD";
            enterAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Deposit
            // 
            Deposit.AutoSize = true;
            Deposit.BackColor = Color.Transparent;
            Deposit.FlatStyle = FlatStyle.Popup;
            Deposit.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold);
            Deposit.ForeColor = SystemColors.GradientActiveCaption;
            Deposit.Location = new Point(37, 12);
            Deposit.Margin = new Padding(0);
            Deposit.Name = "Deposit";
            Deposit.Size = new Size(148, 41);
            Deposit.TabIndex = 74;
            Deposit.Text = "Deposit";
            Deposit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_Deposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 35, 37);
            Controls.Add(convertPanel);
            Controls.Add(Deposit);
            Name = "UC_Deposit";
            Size = new Size(736, 688);
            convertPanel.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel convertPanel;
        private Guna.UI2.WinForms.Guna2Button depositConfirmButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox amountLabel;
        public Label enterAmount;
        public Label Deposit;
    }
}
