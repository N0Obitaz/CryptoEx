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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ExchangeNow = new Label();
            convertPanel = new Guna2Panel();
            guna2Button1 = new Guna2Button();
            guna2Panel3 = new Guna2Panel();
            selectedLabelTo = new Guna2HtmlLabel();
            amountTo = new Guna2TextBox();
            dropDownTo = new Guna2ComboBox();
            youGet = new Label();
            priceOfToCurrency = new Label();
            label1 = new Label();
            guna2Panel2 = new Guna2Panel();
            SelectedLabelFrom = new Guna2HtmlLabel();
            dropDownFrom = new Guna2ComboBox();
            priceOfFromCurrency = new Label();
            amountText = new Label();
            amountLabel = new Guna2TextBox();
            from = new Label();
            Exchange = new Label();
            exchangePanel = new Guna2Panel();
            convertPanel.SuspendLayout();
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
            convertPanel.Controls.Add(guna2Button1);
            convertPanel.Controls.Add(guna2Panel3);
            convertPanel.Controls.Add(guna2Panel2);
            convertPanel.CustomizableEdges = customizableEdges15;
            convertPanel.FillColor = Color.FromArgb(60, 63, 64);
            convertPanel.Location = new Point(58, 62);
            convertPanel.Name = "convertPanel";
            convertPanel.ShadowDecoration.CustomizableEdges = customizableEdges16;
            convertPanel.Size = new Size(539, 565);
            convertPanel.TabIndex = 73;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.IndianRed;
            guna2Button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(35, 474);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(468, 65);
            guna2Button1.TabIndex = 74;
            guna2Button1.Text = "Exchange";
            // 
            // guna2Panel3
            // 
            guna2Panel3.BorderRadius = 20;
            guna2Panel3.Controls.Add(selectedLabelTo);
            guna2Panel3.Controls.Add(amountTo);
            guna2Panel3.Controls.Add(dropDownTo);
            guna2Panel3.Controls.Add(youGet);
            guna2Panel3.Controls.Add(priceOfToCurrency);
            guna2Panel3.Controls.Add(label1);
            guna2Panel3.CustomizableEdges = customizableEdges7;
            guna2Panel3.FillColor = Color.FromArgb(34, 35, 37);
            guna2Panel3.Location = new Point(35, 270);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel3.Size = new Size(468, 190);
            guna2Panel3.TabIndex = 83;
            // 
            // selectedLabelTo
            // 
            selectedLabelTo.BackColor = Color.FromArgb(60, 63, 64);
            selectedLabelTo.Font = new Font("Segoe UI", 10F);
            selectedLabelTo.ForeColor = Color.White;
            selectedLabelTo.Location = new Point(22, 61);
            selectedLabelTo.Name = "selectedLabelTo";
            selectedLabelTo.Size = new Size(106, 25);
            selectedLabelTo.TabIndex = 92;
            selectedLabelTo.Text = "Select Option";
            // 
            // amountTo
            // 
            amountTo.BackColor = Color.Transparent;
            amountTo.BorderRadius = 15;
            amountTo.BorderThickness = 0;
            amountTo.Cursor = Cursors.IBeam;
            amountTo.CustomizableEdges = customizableEdges3;
            amountTo.DefaultText = "";
            amountTo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            amountTo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            amountTo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            amountTo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            amountTo.FillColor = Color.FromArgb(60, 63, 64);
            amountTo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            amountTo.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountTo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            amountTo.Location = new Point(204, 55);
            amountTo.Margin = new Padding(11, 9, 11, 9);
            amountTo.Name = "amountTo";
            amountTo.PlaceholderForeColor = Color.White;
            amountTo.PlaceholderText = "0";
            amountTo.SelectedText = "";
            amountTo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            amountTo.Size = new Size(242, 64);
            amountTo.TabIndex = 91;
            amountTo.TextAlign = HorizontalAlignment.Right;
            // 
            // dropDownTo
            // 
            dropDownTo.AutoCompleteCustomSource.AddRange(new string[] { "btc", "eth", "you" });
            dropDownTo.BackColor = Color.Transparent;
            dropDownTo.BorderRadius = 10;
            dropDownTo.BorderThickness = 0;
            dropDownTo.Cursor = Cursors.Hand;
            dropDownTo.CustomizableEdges = customizableEdges5;
            dropDownTo.DrawMode = DrawMode.OwnerDrawFixed;
            dropDownTo.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownTo.FillColor = Color.FromArgb(60, 63, 64);
            dropDownTo.FocusedColor = Color.FromArgb(94, 148, 255);
            dropDownTo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            dropDownTo.Font = new Font("Segoe UI", 10F);
            dropDownTo.ForeColor = Color.White;
            dropDownTo.ItemHeight = 30;
            dropDownTo.Items.AddRange(new object[] { "BTC", "ETH", "BNB", "SOL", "XRP", "DOGE", "ADA", "AVAX", "BCH", "DOT" });
            dropDownTo.Location = new Point(12, 55);
            dropDownTo.Name = "dropDownTo";
            dropDownTo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dropDownTo.Size = new Size(175, 36);
            dropDownTo.StartIndex = 0;
            dropDownTo.TabIndex = 91;
            dropDownTo.Tag = "Select Option";
            dropDownTo.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged_1;
            // 
            // youGet
            // 
            youGet.AutoSize = true;
            youGet.BackColor = Color.Transparent;
            youGet.FlatStyle = FlatStyle.Popup;
            youGet.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            youGet.ForeColor = SystemColors.ControlDarkDark;
            youGet.Location = new Point(337, 14);
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
            priceOfToCurrency.Location = new Point(22, 102);
            priceOfToCurrency.Margin = new Padding(0);
            priceOfToCurrency.Name = "priceOfToCurrency";
            priceOfToCurrency.Size = new Size(21, 23);
            priceOfToCurrency.TabIndex = 88;
            priceOfToCurrency.Text = "0";
            priceOfToCurrency.TextAlign = ContentAlignment.MiddleCenter;
            priceOfToCurrency.Visible = false;
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
            guna2Panel2.Controls.Add(SelectedLabelFrom);
            guna2Panel2.Controls.Add(dropDownFrom);
            guna2Panel2.Controls.Add(priceOfFromCurrency);
            guna2Panel2.Controls.Add(amountText);
            guna2Panel2.Controls.Add(amountLabel);
            guna2Panel2.Controls.Add(from);
            guna2Panel2.CustomizableEdges = customizableEdges13;
            guna2Panel2.FillColor = Color.FromArgb(34, 35, 37);
            guna2Panel2.Location = new Point(35, 52);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Panel2.Size = new Size(468, 190);
            guna2Panel2.TabIndex = 82;
            // 
            // SelectedLabelFrom
            // 
            SelectedLabelFrom.BackColor = Color.FromArgb(60, 63, 64);
            SelectedLabelFrom.Font = new Font("Segoe UI", 10F);
            SelectedLabelFrom.ForeColor = Color.White;
            SelectedLabelFrom.Location = new Point(24, 62);
            SelectedLabelFrom.Name = "SelectedLabelFrom";
            SelectedLabelFrom.Size = new Size(106, 25);
            SelectedLabelFrom.TabIndex = 91;
            SelectedLabelFrom.Text = "Select Option";
            // 
            // dropDownFrom
            // 
            dropDownFrom.AutoCompleteCustomSource.AddRange(new string[] { "btc", "eth", "you" });
            dropDownFrom.BackColor = Color.Transparent;
            dropDownFrom.BorderRadius = 10;
            dropDownFrom.BorderThickness = 0;
            dropDownFrom.Cursor = Cursors.Hand;
            dropDownFrom.CustomizableEdges = customizableEdges9;
            dropDownFrom.DrawMode = DrawMode.OwnerDrawFixed;
            dropDownFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownFrom.FillColor = Color.FromArgb(60, 63, 64);
            dropDownFrom.FocusedColor = Color.FromArgb(94, 148, 255);
            dropDownFrom.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            dropDownFrom.Font = new Font("Segoe UI", 10F);
            dropDownFrom.ForeColor = Color.White;
            dropDownFrom.ItemHeight = 30;
            dropDownFrom.Items.AddRange(new object[] { "BTC", "ETH", "BNB", "SOL", "XRP", "DOGE", "ADA", "AVAX", "BCH", "DOT" });
            dropDownFrom.Location = new Point(15, 58);
            dropDownFrom.Name = "dropDownFrom";
            dropDownFrom.ShadowDecoration.CustomizableEdges = customizableEdges10;
            dropDownFrom.Size = new Size(175, 36);
            dropDownFrom.StartIndex = 0;
            dropDownFrom.TabIndex = 90;
            dropDownFrom.Tag = "Select Option";
            dropDownFrom.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // priceOfFromCurrency
            // 
            priceOfFromCurrency.AutoSize = true;
            priceOfFromCurrency.BackColor = Color.Transparent;
            priceOfFromCurrency.FlatStyle = FlatStyle.Popup;
            priceOfFromCurrency.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            priceOfFromCurrency.ForeColor = SystemColors.ControlDarkDark;
            priceOfFromCurrency.Location = new Point(22, 104);
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
            amountText.Location = new Point(348, 12);
            amountText.Margin = new Padding(0);
            amountText.Name = "amountText";
            amountText.Size = new Size(87, 23);
            amountText.TabIndex = 86;
            amountText.Text = "Amount";
            amountText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // amountLabel
            // 
            amountLabel.BackColor = Color.Transparent;
            amountLabel.BorderRadius = 15;
            amountLabel.BorderThickness = 0;
            amountLabel.Cursor = Cursors.IBeam;
            amountLabel.CustomizableEdges = customizableEdges11;
            amountLabel.DefaultText = "";
            amountLabel.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            amountLabel.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            amountLabel.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            amountLabel.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            amountLabel.FillColor = Color.FromArgb(60, 63, 64);
            amountLabel.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            amountLabel.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountLabel.ForeColor = Color.White;
            amountLabel.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            amountLabel.Location = new Point(204, 58);
            amountLabel.Margin = new Padding(11, 9, 11, 9);
            amountLabel.Name = "amountLabel";
            amountLabel.PlaceholderForeColor = Color.White;
            amountLabel.PlaceholderText = "0";
            amountLabel.SelectedText = "";
            amountLabel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            amountLabel.Size = new Size(242, 64);
            amountLabel.TabIndex = 85;
            amountLabel.TextAlign = HorizontalAlignment.Right;
            amountLabel.TextChanged += Text_Changed;
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
            exchangePanel.CustomizableEdges = customizableEdges17;
            exchangePanel.FillColor = Color.FromArgb(34, 35, 37);
            exchangePanel.Location = new Point(0, 0);
            exchangePanel.Name = "exchangePanel";
            exchangePanel.ShadowDecoration.CustomizableEdges = customizableEdges18;
            exchangePanel.Size = new Size(1136, 733);
            exchangePanel.TabIndex = 74;
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
                currencyBtn.Location = new Point(10, j + 36);
                currencyBtn.Tag = currency;


              
                currencyBtn.FlatStyle = FlatStyle.Flat;
                currencyBtn.FlatAppearance.BorderSize = 0;
                currencyBtn.ForeColor = Color.White;
                currencyBtn.FlatAppearance.BorderColor = Color.CornflowerBlue;
                currencyBtn.BackColor = Color.CornflowerBlue;
              
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
                amountTo.ForeColor = Color.White;
                amountTo.Text = calculated.ToString("N2");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }
        private Guna2Panel convertPanel;
        private Guna2Panel guna2Panel3;
        public Label youGet;
        public Label priceOfToCurrency;
        public Label label1;
        private Guna2Panel guna2Panel2;
        public Label priceOfFromCurrency;
        public Label amountText;
        private Guna2TextBox amountLabel;
        public Label from;
        public Label Exchange;
        public Guna2Panel exchangePanel;
        private Guna2Button guna2Button1;
        public Guna2ComboBox dropDownFrom;
        public Guna2ComboBox dropDownTo;
        private Guna2TextBox amountTo;
        private Guna2HtmlLabel selectedLabelTo;
        private Guna2HtmlLabel SelectedLabelFrom;
    }
}
