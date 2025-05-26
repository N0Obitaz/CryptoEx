namespace WebSocketStreamingWithUI.UserControls
{
    partial class UC_History2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_History2));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            message = new Guna.UI2.WinForms.Guna2HtmlLabel();
            historyBigPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            historyInsidePanel = new Guna.UI2.WinForms.Guna2Panel();
            deleteButton = new Guna.UI2.WinForms.Guna2Button();
            HistoryLabel = new Label();
            messageLabel = new Label();
            historyBigPanel.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(79, 46);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(137, 39);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "History";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // message
            // 
            message.AutoSize = false;
            message.BackColor = Color.Transparent;
            message.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            message.ForeColor = Color.White;
            message.Location = new Point(318, 46);
            message.Name = "message";
            message.Size = new Size(500, 39);
            message.TabIndex = 5;
            message.Text = "Action";
            message.TextAlignment = ContentAlignment.MiddleCenter;
            message.Visible = false;
            // 
            // historyBigPanel
            // 
            historyBigPanel.BackColor = Color.Transparent;
            historyBigPanel.BorderRadius = 30;
            historyBigPanel.Controls.Add(messageLabel);
            historyBigPanel.Controls.Add(HistoryLabel);
            historyBigPanel.Controls.Add(guna2Panel1);
            historyBigPanel.Controls.Add(deleteButton);
            historyBigPanel.CustomizableEdges = customizableEdges7;
            historyBigPanel.FillColor = Color.FromArgb(60, 63, 64);
            historyBigPanel.Location = new Point(-1, 0);
            historyBigPanel.Name = "historyBigPanel";
            historyBigPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            historyBigPanel.Size = new Size(1137, 733);
            historyBigPanel.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 30;
            guna2Panel1.Controls.Add(historyInsidePanel);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.FillColor = Color.FromArgb(34, 35, 37);
            guna2Panel1.Location = new Point(98, 92);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(935, 605);
            guna2Panel1.TabIndex = 4;
            // 
            // historyInsidePanel
            // 
            historyInsidePanel.AutoScroll = true;
            historyInsidePanel.BackColor = Color.Transparent;
            historyInsidePanel.BorderRadius = 20;
            historyInsidePanel.CustomizableEdges = customizableEdges1;
            historyInsidePanel.FillColor = Color.Transparent;
            historyInsidePanel.Location = new Point(14, 16);
            historyInsidePanel.Name = "historyInsidePanel";
            historyInsidePanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            historyInsidePanel.Size = new Size(907, 573);
            historyInsidePanel.TabIndex = 3;
            // 
            // deleteButton
            // 
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.CustomizableEdges = customizableEdges5;
            deleteButton.DisabledState.BorderColor = Color.DarkGray;
            deleteButton.DisabledState.CustomBorderColor = Color.DarkGray;
            deleteButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deleteButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deleteButton.FillColor = Color.Transparent;
            deleteButton.Font = new Font("Segoe UI", 9F);
            deleteButton.ForeColor = Color.White;
            deleteButton.HoverState.Image = (Image)resources.GetObject("resource.Image");
            deleteButton.Image = (Image)resources.GetObject("deleteButton.Image");
            deleteButton.Location = new Point(953, 46);
            deleteButton.Name = "deleteButton";
            deleteButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            deleteButton.Size = new Size(50, 50);
            deleteButton.TabIndex = 0;
            deleteButton.Click += deleteButton_Click;
            // 
            // HistoryLabel
            // 
            HistoryLabel.AutoSize = true;
            HistoryLabel.BackColor = Color.Transparent;
            HistoryLabel.FlatStyle = FlatStyle.Popup;
            HistoryLabel.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold);
            HistoryLabel.ForeColor = SystemColors.GradientActiveCaption;
            HistoryLabel.Location = new Point(77, 33);
            HistoryLabel.Margin = new Padding(0);
            HistoryLabel.Name = "HistoryLabel";
            HistoryLabel.Size = new Size(142, 41);
            HistoryLabel.TabIndex = 70;
            HistoryLabel.Text = "History";
            HistoryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // messageLabel
            // 
            messageLabel.BackColor = Color.Transparent;
            messageLabel.FlatStyle = FlatStyle.Popup;
            messageLabel.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold);
            messageLabel.ForeColor = SystemColors.GradientActiveCaption;
            messageLabel.Location = new Point(318, 33);
            messageLabel.Margin = new Padding(0);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(500, 41);
            messageLabel.TabIndex = 71;
            messageLabel.Text = "History";
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            messageLabel.Visible = false;
            // 
            // UC_History2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(historyBigPanel);
            Name = "UC_History2";
            Size = new Size(1136, 733);
            historyBigPanel.ResumeLayout(false);
            historyBigPanel.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel message;
        private Guna.UI2.WinForms.Guna2Panel historyBigPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel historyInsidePanel;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        public Label messageLabel;
        public Label HistoryLabel;
    }
}
