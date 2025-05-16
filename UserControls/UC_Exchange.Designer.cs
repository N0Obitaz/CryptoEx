using System.Drawing.Text;
using Guna.UI2.WinForms;
using WebSocketStreamingWithUI.TestWebSocket;

namespace WebSocketStreamingWithUI.UserControls
{
    partial class UC_Exchange
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Exchange));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ExchangeNow = new Label();
            convertPanel = new Guna2Panel();
            overlayPanel = new Guna2Panel();
            closeButton = new Guna2Button();
            guna2Panel3 = new Guna2Panel();
            youGet = new Label();
            priceOfToCurrency = new Label();
            amountTo = new Guna2TextBox();
            selectOptionTo = new Guna2Button();
            label1 = new Label();
            guna2Panel2 = new Guna2Panel();
            priceOfFromCurrency = new Label();
            amountText = new Label();
            amountLabel = new Guna2TextBox();
            selectOptionFrom = new Guna2Button();
            from = new Label();
            Exchange = new Label();
            exchangePanel = new Guna2Panel();
            guna2Button1 = new Guna2Button();
            convertPanel.SuspendLayout();
            overlayPanel.SuspendLayout();
            guna2Panel3.SuspendLayout();
            guna2Panel2.SuspendLayout();
            exchangePanel.SuspendLayout();
            SuspendLayout();
            // 
            // ExchangeNow
            // 
            ExchangeNow.AutoSize = true;
            ExchangeNow.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExchangeNow.Location = new Point(328, 204);
            ExchangeNow.Name = "ExchangeNow";
            ExchangeNow.Size = new Size(213, 34);
            ExchangeNow.TabIndex = 0;
            ExchangeNow.Text = "ExchangeNow";
            // 
            // convertPanel
            // 
            convertPanel.BorderRadius = 20;
            convertPanel.Controls.Add(overlayPanel);
            convertPanel.Controls.Add(guna2Button1);
            convertPanel.Controls.Add(guna2Panel3);
            convertPanel.Controls.Add(guna2Panel2);
            convertPanel.CustomizableEdges = customizableEdges19;
            convertPanel.FillColor = Color.FromArgb(60, 63, 64);
            convertPanel.Location = new Point(58, 62);
            convertPanel.Name = "convertPanel";
            convertPanel.ShadowDecoration.CustomizableEdges = customizableEdges20;
            convertPanel.Size = new Size(539, 565);
            convertPanel.TabIndex = 73;
            // 
            // overlayPanel
            // 
            overlayPanel.AutoScroll = true;
            overlayPanel.Controls.Add(closeButton);
            overlayPanel.CustomizableEdges = customizableEdges3;
            overlayPanel.Location = new Point(119, 36);
            overlayPanel.Name = "overlayPanel";
            overlayPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            overlayPanel.Size = new Size(250, 249);
            overlayPanel.TabIndex = 89;
            overlayPanel.Visible = false;
            // 
            // closeButton
            // 
            closeButton.CustomizableEdges = customizableEdges1;
            closeButton.DisabledState.BorderColor = Color.DarkGray;
            closeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            closeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            closeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            closeButton.Font = new Font("Segoe UI", 9F);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(205, 0);
            closeButton.Name = "closeButton";
            closeButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            closeButton.Size = new Size(45, 32);
            closeButton.TabIndex = 0;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BorderRadius = 20;
            guna2Panel3.Controls.Add(youGet);
            guna2Panel3.Controls.Add(priceOfToCurrency);
            guna2Panel3.Controls.Add(amountTo);
            guna2Panel3.Controls.Add(selectOptionTo);
            guna2Panel3.Controls.Add(label1);
            guna2Panel3.CustomizableEdges = customizableEdges11;
            guna2Panel3.FillColor = Color.FromArgb(34, 35, 37);
            guna2Panel3.Location = new Point(25, 270);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel3.Size = new Size(468, 190);
            guna2Panel3.TabIndex = 83;
            // 
            // youGet
            // 
            youGet.AutoSize = true;
            youGet.BackColor = Color.Transparent;
            youGet.FlatStyle = FlatStyle.Popup;
            youGet.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            youGet.ForeColor = SystemColors.ControlDarkDark;
            youGet.Location = new Point(292, 10);
            youGet.Margin = new Padding(0);
            youGet.Name = "youGet";
            youGet.Size = new Size(103, 23);
            youGet.TabIndex = 88;
            youGet.Text = "You'll Get";
            youGet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // priceOfToCurrency
            // 
            priceOfToCurrency.AutoSize = true;
            priceOfToCurrency.BackColor = Color.Transparent;
            priceOfToCurrency.FlatStyle = FlatStyle.Popup;
            priceOfToCurrency.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            priceOfToCurrency.ForeColor = SystemColors.ControlDarkDark;
            priceOfToCurrency.Location = new Point(22, 115);
            priceOfToCurrency.Margin = new Padding(0);
            priceOfToCurrency.Name = "priceOfToCurrency";
            priceOfToCurrency.Size = new Size(21, 23);
            priceOfToCurrency.TabIndex = 88;
            priceOfToCurrency.Text = "0";
            priceOfToCurrency.TextAlign = ContentAlignment.MiddleCenter;
            priceOfToCurrency.Visible = false;
            // 
            // amountTo
            // 
            amountTo.BackColor = SystemColors.Control;
            amountTo.BorderRadius = 15;
            amountTo.BorderThickness = 0;
            amountTo.CustomizableEdges = customizableEdges7;
            amountTo.DefaultText = "";
            amountTo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            amountTo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            amountTo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            amountTo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            amountTo.FillColor = SystemColors.Control;
            amountTo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            amountTo.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountTo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            amountTo.Location = new Point(197, 55);
            amountTo.Margin = new Padding(4);
            amountTo.Name = "amountTo";
            amountTo.PlaceholderForeColor = SystemColors.ControlDarkDark;
            amountTo.PlaceholderText = "0";
            amountTo.SelectedText = "";
            amountTo.ShadowDecoration.CustomizableEdges = customizableEdges8;
            amountTo.Size = new Size(196, 45);
            amountTo.TabIndex = 87;
            amountTo.TextAlign = HorizontalAlignment.Right;
            amountTo.TextChanged += Text_Changed;
            // 
            // selectOptionTo
            // 
            selectOptionTo.BackgroundImage = (Image)resources.GetObject("selectOptionTo.BackgroundImage");
            selectOptionTo.BorderRadius = 10;
            selectOptionTo.CustomizableEdges = customizableEdges9;
            selectOptionTo.DisabledState.BorderColor = Color.DarkGray;
            selectOptionTo.DisabledState.CustomBorderColor = Color.DarkGray;
            selectOptionTo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            selectOptionTo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            selectOptionTo.FillColor = Color.Gainsboro;
            selectOptionTo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectOptionTo.ForeColor = Color.Black;
            selectOptionTo.Image = (Image)resources.GetObject("selectOptionTo.Image");
            selectOptionTo.ImageAlign = HorizontalAlignment.Right;
            selectOptionTo.Location = new Point(22, 55);
            selectOptionTo.Name = "selectOptionTo";
            selectOptionTo.ShadowDecoration.CustomizableEdges = customizableEdges10;
            selectOptionTo.Size = new Size(148, 45);
            selectOptionTo.TabIndex = 85;
            selectOptionTo.Text = "Select";
            selectOptionTo.TextAlign = HorizontalAlignment.Left;
            selectOptionTo.Click += selectOptionTo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(31, 23);
            label1.TabIndex = 72;
            label1.Text = "To";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BorderColor = Color.Transparent;
            guna2Panel2.BorderRadius = 20;
            guna2Panel2.Controls.Add(priceOfFromCurrency);
            guna2Panel2.Controls.Add(amountText);
            guna2Panel2.Controls.Add(amountLabel);
            guna2Panel2.Controls.Add(selectOptionFrom);
            guna2Panel2.Controls.Add(from);
            guna2Panel2.CustomizableEdges = customizableEdges17;
            guna2Panel2.FillColor = Color.FromArgb(34, 35, 37);
            guna2Panel2.Location = new Point(25, 52);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2Panel2.Size = new Size(468, 190);
            guna2Panel2.TabIndex = 82;
            // 
            // priceOfFromCurrency
            // 
            priceOfFromCurrency.AutoSize = true;
            priceOfFromCurrency.BackColor = Color.Transparent;
            priceOfFromCurrency.FlatStyle = FlatStyle.Popup;
            priceOfFromCurrency.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            priceOfFromCurrency.ForeColor = SystemColors.ControlDarkDark;
            priceOfFromCurrency.Location = new Point(22, 117);
            priceOfFromCurrency.Margin = new Padding(0);
            priceOfFromCurrency.Name = "priceOfFromCurrency";
            priceOfFromCurrency.Size = new Size(21, 23);
            priceOfFromCurrency.TabIndex = 87;
            priceOfFromCurrency.Text = "0";
            priceOfFromCurrency.TextAlign = ContentAlignment.MiddleCenter;
            priceOfFromCurrency.Visible = false;
            // 
            // amountText
            // 
            amountText.AutoSize = true;
            amountText.BackColor = Color.Transparent;
            amountText.FlatStyle = FlatStyle.Popup;
            amountText.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            amountText.ForeColor = SystemColors.ControlDarkDark;
            amountText.Location = new Point(303, 8);
            amountText.Margin = new Padding(0);
            amountText.Name = "amountText";
            amountText.Size = new Size(87, 23);
            amountText.TabIndex = 86;
            amountText.Text = "Amount";
            amountText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // amountLabel
            // 
            amountLabel.BackColor = SystemColors.Control;
            amountLabel.BorderRadius = 15;
            amountLabel.BorderThickness = 0;
            amountLabel.CustomizableEdges = customizableEdges13;
            amountLabel.DefaultText = "";
            amountLabel.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            amountLabel.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            amountLabel.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            amountLabel.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            amountLabel.FillColor = SystemColors.Control;
            amountLabel.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            amountLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountLabel.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            amountLabel.Location = new Point(197, 58);
            amountLabel.Margin = new Padding(4);
            amountLabel.Name = "amountLabel";
            amountLabel.PlaceholderForeColor = SystemColors.ControlDarkDark;
            amountLabel.PlaceholderText = "0";
            amountLabel.SelectedText = "";
            amountLabel.ShadowDecoration.CustomizableEdges = customizableEdges14;
            amountLabel.Size = new Size(196, 45);
            amountLabel.TabIndex = 85;
            amountLabel.TextAlign = HorizontalAlignment.Right;
            amountLabel.TextChanged += Text_Changed;
            // 
            // selectOptionFrom
            // 
            selectOptionFrom.BackgroundImage = (Image)resources.GetObject("selectOptionFrom.BackgroundImage");
            selectOptionFrom.BorderRadius = 10;
            selectOptionFrom.CustomizableEdges = customizableEdges15;
            selectOptionFrom.DisabledState.BorderColor = Color.DarkGray;
            selectOptionFrom.DisabledState.CustomBorderColor = Color.DarkGray;
            selectOptionFrom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            selectOptionFrom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            selectOptionFrom.FillColor = Color.Gainsboro;
            selectOptionFrom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectOptionFrom.ForeColor = Color.Black;
            selectOptionFrom.Image = (Image)resources.GetObject("selectOptionFrom.Image");
            selectOptionFrom.ImageAlign = HorizontalAlignment.Right;
            selectOptionFrom.Location = new Point(22, 58);
            selectOptionFrom.Name = "selectOptionFrom";
            selectOptionFrom.ShadowDecoration.CustomizableEdges = customizableEdges16;
            selectOptionFrom.Size = new Size(148, 45);
            selectOptionFrom.TabIndex = 84;
            selectOptionFrom.Text = "Select";
            selectOptionFrom.TextAlign = HorizontalAlignment.Left;
            selectOptionFrom.Click += selectOption_Click;
            // 
            // from
            // 
            from.AutoSize = true;
            from.BackColor = Color.Transparent;
            from.FlatStyle = FlatStyle.Popup;
            from.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            from.ForeColor = SystemColors.ControlDarkDark;
            from.Location = new Point(10, 10);
            from.Margin = new Padding(0);
            from.Name = "from";
            from.Size = new Size(58, 23);
            from.TabIndex = 72;
            from.Text = "From";
            from.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Exchange
            // 
            Exchange.AutoSize = true;
            Exchange.BackColor = Color.Transparent;
            Exchange.FlatStyle = FlatStyle.Popup;
            Exchange.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold);
            Exchange.ForeColor = SystemColors.GradientActiveCaption;
            Exchange.Location = new Point(37, 12);
            Exchange.Margin = new Padding(0);
            Exchange.Name = "Exchange";
            Exchange.Size = new Size(183, 41);
            Exchange.TabIndex = 69;
            Exchange.Text = "Exchange";
            Exchange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exchangePanel
            // 
            exchangePanel.BackColor = Color.Transparent;
            exchangePanel.BorderRadius = 20;
            exchangePanel.Controls.Add(convertPanel);
            exchangePanel.Controls.Add(Exchange);
            exchangePanel.CustomizableEdges = customizableEdges21;
            exchangePanel.FillColor = Color.FromArgb(34, 35, 37);
            exchangePanel.Location = new Point(0, 0);
            exchangePanel.Name = "exchangePanel";
            exchangePanel.ShadowDecoration.CustomizableEdges = customizableEdges22;
            exchangePanel.Size = new Size(1136, 733);
            exchangePanel.TabIndex = 74;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.IndianRed;
            guna2Button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(25, 474);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(468, 65);
            guna2Button1.TabIndex = 74;
            guna2Button1.Text = "Exchange";
            // 
            // UC_Exchange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(exchangePanel);
            Controls.Add(ExchangeNow);
            Name = "UC_Exchange";
            Size = new Size(1150, 748);
            convertPanel.ResumeLayout(false);
            overlayPanel.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            exchangePanel.ResumeLayout(false);
            exchangePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ExchangeNow;

        private void CreateButtons()
        {
            var client = new WebSocketPriceClient();
            int j = 0;
            
            for (int i = 0; i < client.pairs.Length; i++)
            {
                string currency = client.pairs[i].Split("usdt")[0].ToUpper();
                var currencyBtn = new Button();
                currencyBtn.Name = currency;
                currencyBtn.Text = currency;


                currencyBtn.Size = new Size(100, 50);
                currencyBtn.Location = new Point(70, j + 36);
                currencyBtn.Tag = currency;


                currencyBtn.Click += currencyBtn_Click;
                currencyBtn.FlatStyle = FlatStyle.Flat;
                currencyBtn.FlatAppearance.BorderSize = 0;
                currencyBtn.ForeColor = Color.White;
                currencyBtn.FlatAppearance.BorderColor = Color.CornflowerBlue;
                currencyBtn.BackColor = Color.CornflowerBlue;
                currencyBtn.Cursor = Cursors.Hand;

                overlayPanel.Controls.Add(currencyBtn);
                j += 36;
            }

           




        }
        private void Text_Changed(object sender, EventArgs e)
        {
            try
            {
                if (amountLabel.Text.ToString() == "")
                {
                    return;
                }
                else if (amountLabel.Text.ToString() == "0")
                {
                    amountTo.Text = "0";

                    return;

                }


                //Get amount of currency held
                float fromAmount = float.Parse(amountLabel.Text.ToString()) * float.Parse(priceOfFromCurrency.Text);

                //divide the currency held to the priceOfFromCurrency
                float calculated = (fromAmount / float.Parse(priceOfToCurrency.Text));

                //Calculate the converted amount by multiplying and diving to the desired currency
                amountTo.Text = calculated.ToString("N2");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }
        private Guna2Panel convertPanel;
        private Guna2Panel overlayPanel;
        private Guna2Button closeButton;
        private Guna2Panel guna2Panel3;
        public Label youGet;
        public Label priceOfToCurrency;
        private Guna2TextBox amountTo;
        private Guna2Button selectOptionTo;
        public Label label1;
        private Guna2Panel guna2Panel2;
        public Label priceOfFromCurrency;
        public Label amountText;
        private Guna2TextBox amountLabel;
        private Guna2Button selectOptionFrom;
        public Label from;
        public Label Exchange;
        public Guna2Panel exchangePanel;
        private Guna2Button guna2Button1;
    }
}
