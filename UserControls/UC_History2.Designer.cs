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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            historyBigPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            historyPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2vScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            historyBox = new Guna.UI2.WinForms.Guna2GradientPanel();
            subAction = new Guna.UI2.WinForms.Guna2HtmlLabel();
            timeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            amountLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            actionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dateLabelHistory = new Label();
            historyLabel = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            historyInsidePanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            historyBigPanel.SuspendLayout();
            historyPanel.SuspendLayout();
            historyBox.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // historyBigPanel
            // 
            historyBigPanel.BackColor = Color.Transparent;
            historyBigPanel.BorderColor = Color.White;
            historyBigPanel.BorderRadius = 20;
            historyBigPanel.Controls.Add(guna2Panel1);
            historyBigPanel.Controls.Add(guna2HtmlLabel1);
            historyBigPanel.CustomizableEdges = customizableEdges5;
            historyBigPanel.FillColor = Color.FromArgb(60, 63, 64);
            historyBigPanel.FillColor2 = Color.FromArgb(60, 63, 64);
            historyBigPanel.Location = new Point(0, 0);
            historyBigPanel.Name = "historyBigPanel";
            historyBigPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            historyBigPanel.Size = new Size(1136, 733);
            historyBigPanel.TabIndex = 4;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(500, 57);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(137, 39);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "History";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // historyPanel
            // 
            historyPanel.BackColor = Color.Transparent;
            historyPanel.BorderColor = Color.Wheat;
            historyPanel.BorderRadius = 15;
            historyPanel.Controls.Add(guna2vScrollBar1);
            historyPanel.Controls.Add(historyBox);
            historyPanel.Controls.Add(dateLabelHistory);
            historyPanel.Controls.Add(historyLabel);
            historyPanel.Controls.Add(guna2Separator1);
            historyPanel.CustomizableEdges = customizableEdges9;
            historyPanel.FillColor = Color.White;
            historyPanel.Location = new Point(1, 1);
            historyPanel.Name = "historyPanel";
            historyPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            historyPanel.Size = new Size(617, 579);
            historyPanel.TabIndex = 39;
            historyPanel.UseTransparentBackground = true;
            // 
            // guna2vScrollBar1
            // 
            guna2vScrollBar1.InUpdate = false;
            guna2vScrollBar1.LargeChange = 10;
            guna2vScrollBar1.Location = new Point(587, 67);
            guna2vScrollBar1.Name = "guna2vScrollBar1";
            guna2vScrollBar1.ScrollbarSize = 22;
            guna2vScrollBar1.Size = new Size(22, 491);
            guna2vScrollBar1.TabIndex = 40;
            // 
            // historyBox
            // 
            historyBox.BorderRadius = 20;
            historyBox.Controls.Add(subAction);
            historyBox.Controls.Add(timeLabel);
            historyBox.Controls.Add(amountLabel);
            historyBox.Controls.Add(actionLabel);
            historyBox.CustomizableEdges = customizableEdges7;
            historyBox.FillColor = Color.FromArgb(192, 255, 255);
            historyBox.FillColor2 = Color.FromArgb(0, 192, 192);
            historyBox.Location = new Point(37, 101);
            historyBox.Name = "historyBox";
            historyBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            historyBox.Size = new Size(523, 63);
            historyBox.TabIndex = 46;
            // 
            // subAction
            // 
            subAction.BackColor = Color.Transparent;
            subAction.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subAction.Location = new Point(41, 37);
            subAction.Name = "subAction";
            subAction.Size = new Size(93, 23);
            subAction.TabIndex = 50;
            subAction.Text = "Sub Action";
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.Transparent;
            timeLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.Location = new Point(439, 35);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(34, 22);
            timeLabel.TabIndex = 49;
            timeLabel.Text = "Time";
            // 
            // amountLabel
            // 
            amountLabel.BackColor = Color.Transparent;
            amountLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountLabel.Location = new Point(403, 8);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(80, 25);
            amountLabel.TabIndex = 48;
            amountLabel.Text = "Amount";
            // 
            // actionLabel
            // 
            actionLabel.BackColor = Color.Transparent;
            actionLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            actionLabel.Location = new Point(23, 11);
            actionLabel.Name = "actionLabel";
            actionLabel.Size = new Size(67, 25);
            actionLabel.TabIndex = 47;
            actionLabel.Text = "Action";
            // 
            // dateLabelHistory
            // 
            dateLabelHistory.AutoSize = true;
            dateLabelHistory.BackColor = Color.White;
            dateLabelHistory.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabelHistory.Location = new Point(38, 67);
            dateLabelHistory.Name = "dateLabelHistory";
            dateLabelHistory.Size = new Size(56, 23);
            dateLabelHistory.TabIndex = 45;
            dateLabelHistory.Text = "Date";
            // 
            // historyLabel
            // 
            historyLabel.AutoSize = true;
            historyLabel.BackColor = Color.White;
            historyLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historyLabel.Location = new Point(16, 10);
            historyLabel.Name = "historyLabel";
            historyLabel.Size = new Size(86, 27);
            historyLabel.TabIndex = 44;
            historyLabel.Text = "History";
            historyLabel.Click += historyLabel_Click;
            // 
            // guna2Separator1
            // 
            guna2Separator1.BackColor = Color.White;
            guna2Separator1.FillColor = Color.Black;
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(3, 45);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(613, 10);
            guna2Separator1.TabIndex = 44;
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
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 30;
            guna2Panel1.Controls.Add(historyInsidePanel);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.FillColor = Color.FromArgb(34, 35, 37);
            guna2Panel1.Location = new Point(101, 102);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(935, 605);
            guna2Panel1.TabIndex = 4;
            // 
            // UC_History2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(historyBigPanel);
            Controls.Add(historyPanel);
            Name = "UC_History2";
            Size = new Size(1136, 733);
            historyBigPanel.ResumeLayout(false);
            historyBigPanel.PerformLayout();
            historyPanel.ResumeLayout(false);
            historyPanel.PerformLayout();
            historyBox.ResumeLayout(false);
            historyBox.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion


        private Guna.UI2.WinForms.Guna2Panel historyPanel;
        public Label historyLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Label dateLabelHistory;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2vScrollBar1;
        public Guna.UI2.WinForms.Guna2GradientPanel historyBox;
        public Guna.UI2.WinForms.Guna2HtmlLabel timeLabel;
        public Guna.UI2.WinForms.Guna2HtmlLabel amountLabel;
        public Guna.UI2.WinForms.Guna2HtmlLabel actionLabel;
        public Guna.UI2.WinForms.Guna2HtmlLabel subAction;
        private Guna.UI2.WinForms.Guna2GradientPanel historyBigPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel historyInsidePanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
