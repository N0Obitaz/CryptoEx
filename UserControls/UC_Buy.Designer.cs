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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            separator1 = new Guna.UI2.WinForms.Guna2Separator();
            buyPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            EntryField = new Guna.UI2.WinForms.Guna2Panel();
            priceChanges = new Guna.UI2.WinForms.Guna2HtmlLabel();
            selectOption = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dropDownBuy = new Guna.UI2.WinForms.Guna2ComboBox();
            currencyLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            sell = new Guna.UI2.WinForms.Guna2Button();
            buy = new Guna.UI2.WinForms.Guna2Button();
            separator2 = new Guna.UI2.WinForms.Guna2Separator();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            buyPanel.SuspendLayout();
            guna2Panel1.SuspendLayout();
            EntryField.SuspendLayout();
            SuspendLayout();
            // 
            // separator1
            // 
            separator1.BackColor = Color.Transparent;
            separator1.FillColor = Color.Black;
            separator1.FillThickness = 2;
            separator1.Location = new Point(262, 86);
            separator1.Name = "separator1";
            separator1.Size = new Size(308, 10);
            separator1.TabIndex = 37;
            // 
            // buyPanel
            // 
            buyPanel.BackColor = Color.Transparent;
            buyPanel.BorderColor = Color.Black;
            buyPanel.BorderRadius = 20;
            buyPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            buyPanel.Controls.Add(guna2Panel1);
            buyPanel.Controls.Add(sell);
            buyPanel.Controls.Add(buy);
            buyPanel.Controls.Add(separator2);
            buyPanel.Controls.Add(separator1);
            buyPanel.CustomizableEdges = customizableEdges23;
            buyPanel.FillColor = Color.FromArgb(34, 35, 37);
            buyPanel.FillColor2 = Color.FromArgb(34, 35, 37);
            buyPanel.Location = new Point(0, 0);
            buyPanel.Name = "buyPanel";
            buyPanel.ShadowDecoration.CustomizableEdges = customizableEdges24;
            buyPanel.Size = new Size(1136, 733);
            buyPanel.TabIndex = 72;
            buyPanel.Paint += exchangePanel_Paint;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.White;
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(EntryField);
            guna2Panel1.CustomizableEdges = customizableEdges17;
            guna2Panel1.FillColor = Color.Transparent;
            guna2Panel1.Location = new Point(261, 102);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2Panel1.Size = new Size(615, 529);
            guna2Panel1.TabIndex = 72;
            // 
            // EntryField
            // 
            EntryField.BorderRadius = 15;
            EntryField.Controls.Add(priceChanges);
            EntryField.Controls.Add(selectOption);
            EntryField.Controls.Add(dropDownBuy);
            EntryField.Controls.Add(currencyLabel);
            EntryField.CustomizableEdges = customizableEdges15;
            EntryField.FillColor = Color.FromArgb(60, 63, 64);
            EntryField.Location = new Point(22, 126);
            EntryField.Name = "EntryField";
            EntryField.ShadowDecoration.CustomizableEdges = customizableEdges16;
            EntryField.Size = new Size(570, 163);
            EntryField.TabIndex = 0;
            // 
            // priceChanges
            // 
            priceChanges.BackColor = Color.Transparent;
            priceChanges.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            priceChanges.ForeColor = Color.LightGray;
            priceChanges.Location = new Point(25, 115);
            priceChanges.Name = "priceChanges";
            priceChanges.Size = new Size(13, 24);
            priceChanges.TabIndex = 75;
            priceChanges.Text = "0";
            priceChanges.Visible = false;
            // 
            // selectOption
            // 
            selectOption.BackColor = Color.Transparent;
            selectOption.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectOption.ForeColor = Color.Silver;
            selectOption.Location = new Point(25, 62);
            selectOption.Name = "selectOption";
            selectOption.Size = new Size(114, 46);
            selectOption.TabIndex = 74;
            selectOption.Text = "Select";
            selectOption.Click += selectOption_Click;
            // 
            // dropDownBuy
            // 
            dropDownBuy.BackColor = Color.Transparent;
            dropDownBuy.BorderThickness = 0;
            dropDownBuy.CustomizableEdges = customizableEdges13;
            dropDownBuy.DrawMode = DrawMode.OwnerDrawFixed;
            dropDownBuy.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownBuy.FillColor = Color.FromArgb(60, 63, 64);
            dropDownBuy.FocusedColor = Color.FromArgb(94, 148, 255);
            dropDownBuy.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            dropDownBuy.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dropDownBuy.ForeColor = Color.FromArgb(68, 88, 112);
            dropDownBuy.ItemHeight = 30;
            dropDownBuy.Items.AddRange(new object[] { "BTC", "ETH", "BNB", "SOL", "XRP", "DOGE", "ADA", "AVAX", "BCH", "DOT" });
            dropDownBuy.Location = new Point(14, 72);
            dropDownBuy.Name = "dropDownBuy";
            dropDownBuy.ShadowDecoration.CustomizableEdges = customizableEdges14;
            dropDownBuy.Size = new Size(175, 36);
            dropDownBuy.TabIndex = 1;
            dropDownBuy.SelectedIndexChanged += dropDownBuy_SelectedIndexChanged;
            // 
            // currencyLabel
            // 
            currencyLabel.BackColor = Color.Transparent;
            currencyLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currencyLabel.ForeColor = Color.White;
            currencyLabel.Location = new Point(14, 12);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(85, 24);
            currencyLabel.TabIndex = 73;
            currencyLabel.Text = "Currency";
            currencyLabel.Click += currencyLabel_Click;
            // 
            // sell
            // 
            sell.CustomizableEdges = customizableEdges19;
            sell.DisabledState.BorderColor = Color.DarkGray;
            sell.DisabledState.CustomBorderColor = Color.DarkGray;
            sell.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            sell.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            sell.FillColor = Color.Transparent;
            sell.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sell.ForeColor = Color.DarkGray;
            sell.HoverState.FillColor = Color.Transparent;
            sell.HoverState.ForeColor = Color.White;
            sell.Location = new Point(570, 24);
            sell.Name = "sell";
            sell.ShadowDecoration.CustomizableEdges = customizableEdges20;
            sell.Size = new Size(308, 56);
            sell.TabIndex = 71;
            sell.Text = "Sell";
            sell.Click += sell_Click;
            // 
            // buy
            // 
            buy.CustomizableEdges = customizableEdges21;
            buy.DisabledState.BorderColor = Color.DarkGray;
            buy.DisabledState.CustomBorderColor = Color.DarkGray;
            buy.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buy.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buy.FillColor = Color.Transparent;
            buy.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buy.ForeColor = Color.DarkGray;
            buy.HoverState.FillColor = Color.Transparent;
            buy.HoverState.ForeColor = Color.White;
            buy.Location = new Point(263, 24);
            buy.Name = "buy";
            buy.ShadowDecoration.CustomizableEdges = customizableEdges22;
            buy.Size = new Size(308, 56);
            buy.TabIndex = 70;
            buy.Text = "Buy";
            buy.Click += buy_Click;
            // 
            // separator2
            // 
            separator2.BackColor = Color.Transparent;
            separator2.FillColor = Color.Black;
            separator2.FillThickness = 2;
            separator2.Location = new Point(570, 86);
            separator2.Name = "separator2";
            separator2.Size = new Size(308, 10);
            separator2.TabIndex = 38;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // UC_Buy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buyPanel);
            Name = "UC_Buy";
            Size = new Size(1142, 743);
            buyPanel.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            EntryField.ResumeLayout(false);
            EntryField.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Separator separator1;
        private Guna.UI2.WinForms.Guna2GradientPanel buyPanel;
        private Guna.UI2.WinForms.Guna2Button buy;
        private Guna.UI2.WinForms.Guna2Separator separator2;
        private Guna.UI2.WinForms.Guna2Button sell;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel EntryField;
        private Guna.UI2.WinForms.Guna2HtmlLabel currencyLabel;
        private Guna.UI2.WinForms.Guna2ComboBox dropDownBuy;
        private Guna.UI2.WinForms.Guna2HtmlLabel selectOption;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        public Guna.UI2.WinForms.Guna2HtmlLabel priceChanges;
    }
}
