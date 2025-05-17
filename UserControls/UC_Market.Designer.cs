

namespace WebSocketStreamingWithUI.UserControls
{
    partial class UC_Market
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


        private void CreateActionButtons()
        {
            string[] currencies = new[] { "BTC", "ETH", "BNB", "SOL", "XRP", "DOGE", "ADA", "AVAX", "BCH", "DOT" };

            int j = 107;
            for (int i = 0; i < currencies.Length; i++)
            {
               
                string currency = currencies[i];
                Button actionBtn = new Button();
                actionBtn.Name = "actionBtn" + i;
                actionBtn.Text = "Trade";
                actionBtn.Size = new Size(69, 30);
                actionBtn.Location = new Point(541, j + 38);
                actionBtn.Click += Button_Click;
                actionBtn.Tag = currency;

                actionBtn.FlatStyle = FlatStyle.Flat;
                actionBtn.FlatAppearance.BorderSize = 0;
                actionBtn.ForeColor = Color.White;
                actionBtn.FlatAppearance.BorderColor = Color.CornflowerBlue;
                actionBtn.BackColor = Color.CornflowerBlue;
                actionBtn.Cursor = Cursors.Hand;
                marketPanel.Controls.Add(actionBtn);
                j += 37;
            }
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            favoriteSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            label11 = new Label();
            labelADA = new Label();
            guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            labelDOGETicker = new Label();
            labelBTC = new Label();
            labelADATicker = new Label();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            labelDOGE = new Label();
            labelBTCTicker = new Label();
            label14 = new Label();
            actionLabel = new Label();
            label8 = new Label();
            dollarSymbol = new Label();
            labelAVAX = new Label();
            marketCap = new Label();
            labelXRPTicker = new Label();
            labelETHTicker = new Label();
            labelAVAXTicker = new Label();
            priceLabel = new Label();
            labelXRP = new Label();
            labelETH = new Label();
            label17 = new Label();
            assetTicker = new Label();
            label5 = new Label();
            dollarSymbol2 = new Label();
            labelBCH = new Label();
            label23 = new Label();
            labelSOLTicker = new Label();
            labelBNB = new Label();
            labelBCHTicker = new Label();
            labelDOTTicker = new Label();
            labelSOL = new Label();
            labelBNBTicker = new Label();
            label20 = new Label();
            labelDOT = new Label();
            label2 = new Label();
            marketPanel = new Guna.UI2.WinForms.Guna2Panel();
            transactionPanel = new Guna.UI2.WinForms.Guna2Panel();
            walletPanel = new Guna.UI2.WinForms.Guna2Panel();
            sellButton = new Guna.UI2.WinForms.Guna2Button();
            buyButton = new Guna.UI2.WinForms.Guna2Button();
            withdrawButton = new Guna.UI2.WinForms.Guna2Button();
            depositButton = new Guna.UI2.WinForms.Guna2Button();
            balance = new Label();
            myBalanceLabel = new Label();
            walletSeparator = new Guna.UI2.WinForms.Guna2Separator();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            marketPanel.SuspendLayout();
            walletPanel.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // favoriteSwitch
            // 
            favoriteSwitch.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            favoriteSwitch.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            favoriteSwitch.CheckedState.InnerBorderColor = Color.White;
            favoriteSwitch.CheckedState.InnerColor = Color.White;
            favoriteSwitch.CustomizableEdges = customizableEdges1;
            favoriteSwitch.Location = new Point(541, 59);
            favoriteSwitch.Name = "favoriteSwitch";
            favoriteSwitch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            favoriteSwitch.Size = new Size(44, 25);
            favoriteSwitch.TabIndex = 73;
            favoriteSwitch.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            favoriteSwitch.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            favoriteSwitch.UncheckedState.InnerBorderColor = Color.White;
            favoriteSwitch.UncheckedState.InnerColor = Color.White;
            favoriteSwitch.CheckedChanged += favoriteSwitch_CheckedChanged;
            // 
            // searchBox
            // 
            searchBox.BorderRadius = 10;
            searchBox.CustomizableEdges = customizableEdges3;
            searchBox.DefaultText = "";
            searchBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBox.Font = new Font("Segoe UI", 9F);
            searchBox.ForeColor = Color.Black;
            searchBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBox.Location = new Point(30, 32);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderForeColor = Color.DimGray;
            searchBox.PlaceholderText = "Search";
            searchBox.SelectedText = "";
            searchBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            searchBox.Size = new Size(187, 37);
            searchBox.TabIndex = 72;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.FlatStyle = FlatStyle.Popup;
            label11.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            label11.Location = new Point(181, 334);
            label11.Name = "label11";
            label11.Size = new Size(25, 27);
            label11.TabIndex = 53;
            label11.Text = "$";
            // 
            // labelADA
            // 
            labelADA.AutoSize = true;
            labelADA.BackColor = Color.Transparent;
            labelADA.FlatStyle = FlatStyle.Popup;
            labelADA.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelADA.Location = new Point(209, 371);
            labelADA.Name = "labelADA";
            labelADA.Size = new Size(25, 27);
            labelADA.TabIndex = 54;
            labelADA.Text = "0";
            // 
            // guna2Separator3
            // 
            guna2Separator3.BackColor = Color.Transparent;
            guna2Separator3.FillColor = Color.Black;
            guna2Separator3.FillThickness = 2;
            guna2Separator3.Location = new Point(33, 74);
            guna2Separator3.Name = "guna2Separator3";
            guna2Separator3.Size = new Size(122, 10);
            guna2Separator3.TabIndex = 71;
            // 
            // labelDOGETicker
            // 
            labelDOGETicker.AutoSize = true;
            labelDOGETicker.BackColor = Color.Transparent;
            labelDOGETicker.FlatStyle = FlatStyle.Popup;
            labelDOGETicker.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelDOGETicker.Location = new Point(35, 333);
            labelDOGETicker.Name = "labelDOGETicker";
            labelDOGETicker.Size = new Size(85, 27);
            labelDOGETicker.TabIndex = 52;
            labelDOGETicker.Text = "TICKER";
            // 
            // labelBTC
            // 
            labelBTC.AutoSize = true;
            labelBTC.BackColor = Color.Transparent;
            labelBTC.FlatStyle = FlatStyle.Popup;
            labelBTC.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelBTC.Location = new Point(209, 146);
            labelBTC.Name = "labelBTC";
            labelBTC.Size = new Size(25, 27);
            labelBTC.TabIndex = 36;
            labelBTC.Text = "0";
            // 
            // labelADATicker
            // 
            labelADATicker.AutoSize = true;
            labelADATicker.BackColor = Color.Transparent;
            labelADATicker.FlatStyle = FlatStyle.Popup;
            labelADATicker.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelADATicker.Location = new Point(33, 370);
            labelADATicker.Name = "labelADATicker";
            labelADATicker.Size = new Size(85, 27);
            labelADATicker.TabIndex = 55;
            labelADATicker.Text = "TICKER";
            // 
            // guna2Separator2
            // 
            guna2Separator2.BackColor = Color.Transparent;
            guna2Separator2.FillColor = Color.Black;
            guna2Separator2.FillThickness = 2;
            guna2Separator2.Location = new Point(-3, 90);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new Size(646, 10);
            guna2Separator2.TabIndex = 70;
            // 
            // labelDOGE
            // 
            labelDOGE.AutoSize = true;
            labelDOGE.BackColor = Color.Transparent;
            labelDOGE.FlatStyle = FlatStyle.Popup;
            labelDOGE.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelDOGE.Location = new Point(209, 334);
            labelDOGE.Name = "labelDOGE";
            labelDOGE.Size = new Size(25, 27);
            labelDOGE.TabIndex = 51;
            labelDOGE.Text = "0";
            // 
            // labelBTCTicker
            // 
            labelBTCTicker.AutoSize = true;
            labelBTCTicker.BackColor = Color.Transparent;
            labelBTCTicker.FlatStyle = FlatStyle.Popup;
            labelBTCTicker.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelBTCTicker.Location = new Point(33, 145);
            labelBTCTicker.Margin = new Padding(0);
            labelBTCTicker.Name = "labelBTCTicker";
            labelBTCTicker.Size = new Size(85, 27);
            labelBTCTicker.TabIndex = 37;
            labelBTCTicker.Text = "TICKER";
            labelBTCTicker.Click += labelBTCTicker_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.FlatStyle = FlatStyle.Popup;
            label14.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            label14.Location = new Point(181, 371);
            label14.Name = "label14";
            label14.Size = new Size(25, 27);
            label14.TabIndex = 56;
            label14.Text = "$";
            // 
            // actionLabel
            // 
            actionLabel.AutoSize = true;
            actionLabel.BackColor = Color.Transparent;
            actionLabel.FlatStyle = FlatStyle.Popup;
            actionLabel.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            actionLabel.Location = new Point(541, 107);
            actionLabel.Margin = new Padding(0);
            actionLabel.Name = "actionLabel";
            actionLabel.Size = new Size(86, 27);
            actionLabel.TabIndex = 69;
            actionLabel.Text = "Action";
            actionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            label8.Location = new Point(181, 296);
            label8.Name = "label8";
            label8.Size = new Size(25, 27);
            label8.TabIndex = 50;
            label8.Text = "$";
            // 
            // dollarSymbol
            // 
            dollarSymbol.AutoSize = true;
            dollarSymbol.BackColor = Color.Transparent;
            dollarSymbol.FlatStyle = FlatStyle.Popup;
            dollarSymbol.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            dollarSymbol.Location = new Point(181, 146);
            dollarSymbol.Name = "dollarSymbol";
            dollarSymbol.Size = new Size(25, 27);
            dollarSymbol.TabIndex = 38;
            dollarSymbol.Text = "$";
            // 
            // labelAVAX
            // 
            labelAVAX.AutoSize = true;
            labelAVAX.BackColor = Color.Transparent;
            labelAVAX.FlatStyle = FlatStyle.Popup;
            labelAVAX.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelAVAX.Location = new Point(209, 409);
            labelAVAX.Name = "labelAVAX";
            labelAVAX.Size = new Size(25, 27);
            labelAVAX.TabIndex = 57;
            labelAVAX.Text = "0";
            // 
            // marketCap
            // 
            marketCap.AutoSize = true;
            marketCap.BackColor = Color.Transparent;
            marketCap.FlatStyle = FlatStyle.Popup;
            marketCap.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            marketCap.Location = new Point(343, 107);
            marketCap.Margin = new Padding(0);
            marketCap.Name = "marketCap";
            marketCap.Size = new Size(144, 27);
            marketCap.TabIndex = 68;
            marketCap.Text = "Market Cap";
            marketCap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelXRPTicker
            // 
            labelXRPTicker.AutoSize = true;
            labelXRPTicker.BackColor = Color.Transparent;
            labelXRPTicker.FlatStyle = FlatStyle.Popup;
            labelXRPTicker.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelXRPTicker.Location = new Point(33, 295);
            labelXRPTicker.Name = "labelXRPTicker";
            labelXRPTicker.Size = new Size(85, 27);
            labelXRPTicker.TabIndex = 49;
            labelXRPTicker.Text = "TICKER";
            // 
            // labelETHTicker
            // 
            labelETHTicker.AutoSize = true;
            labelETHTicker.BackColor = Color.Transparent;
            labelETHTicker.FlatStyle = FlatStyle.Popup;
            labelETHTicker.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelETHTicker.Location = new Point(33, 183);
            labelETHTicker.Name = "labelETHTicker";
            labelETHTicker.Size = new Size(85, 27);
            labelETHTicker.TabIndex = 39;
            labelETHTicker.Text = "TICKER";
            // 
            // labelAVAXTicker
            // 
            labelAVAXTicker.AutoSize = true;
            labelAVAXTicker.BackColor = Color.Transparent;
            labelAVAXTicker.FlatStyle = FlatStyle.Popup;
            labelAVAXTicker.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelAVAXTicker.Location = new Point(33, 408);
            labelAVAXTicker.Name = "labelAVAXTicker";
            labelAVAXTicker.Size = new Size(85, 27);
            labelAVAXTicker.TabIndex = 58;
            labelAVAXTicker.Text = "TICKER";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.Transparent;
            priceLabel.FlatStyle = FlatStyle.Popup;
            priceLabel.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            priceLabel.Location = new Point(176, 107);
            priceLabel.Margin = new Padding(0);
            priceLabel.Name = "priceLabel";
            priceLabel.Padding = new Padding(20, 0, 0, 0);
            priceLabel.RightToLeft = RightToLeft.No;
            priceLabel.Size = new Size(88, 27);
            priceLabel.TabIndex = 67;
            priceLabel.Text = "Price";
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelXRP
            // 
            labelXRP.AutoSize = true;
            labelXRP.BackColor = Color.Transparent;
            labelXRP.FlatStyle = FlatStyle.Popup;
            labelXRP.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelXRP.Location = new Point(209, 296);
            labelXRP.Name = "labelXRP";
            labelXRP.Size = new Size(25, 27);
            labelXRP.TabIndex = 48;
            labelXRP.Text = "0";
            // 
            // labelETH
            // 
            labelETH.AutoSize = true;
            labelETH.BackColor = Color.Transparent;
            labelETH.FlatStyle = FlatStyle.Popup;
            labelETH.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelETH.Location = new Point(209, 184);
            labelETH.Name = "labelETH";
            labelETH.Size = new Size(25, 27);
            labelETH.TabIndex = 40;
            labelETH.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.FlatStyle = FlatStyle.Popup;
            label17.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            label17.Location = new Point(181, 409);
            label17.Name = "label17";
            label17.Size = new Size(25, 27);
            label17.TabIndex = 59;
            label17.Text = "$";
            // 
            // assetTicker
            // 
            assetTicker.AutoSize = true;
            assetTicker.BackColor = Color.Transparent;
            assetTicker.FlatStyle = FlatStyle.Popup;
            assetTicker.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            assetTicker.Location = new Point(36, 107);
            assetTicker.Margin = new Padding(0);
            assetTicker.Name = "assetTicker";
            assetTicker.Size = new Size(71, 27);
            assetTicker.TabIndex = 66;
            assetTicker.Text = "Asset";
            assetTicker.TextAlign = ContentAlignment.MiddleCenter;
            assetTicker.Click += assetTicker_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            label5.Location = new Point(181, 259);
            label5.Name = "label5";
            label5.Size = new Size(25, 27);
            label5.TabIndex = 47;
            label5.Text = "$";
            // 
            // dollarSymbol2
            // 
            dollarSymbol2.AutoSize = true;
            dollarSymbol2.BackColor = Color.Transparent;
            dollarSymbol2.FlatStyle = FlatStyle.Popup;
            dollarSymbol2.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            dollarSymbol2.Location = new Point(181, 184);
            dollarSymbol2.Name = "dollarSymbol2";
            dollarSymbol2.Size = new Size(25, 27);
            dollarSymbol2.TabIndex = 41;
            dollarSymbol2.Text = "$";
            // 
            // labelBCH
            // 
            labelBCH.AutoSize = true;
            labelBCH.BackColor = Color.Transparent;
            labelBCH.FlatStyle = FlatStyle.Popup;
            labelBCH.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelBCH.Location = new Point(209, 447);
            labelBCH.Name = "labelBCH";
            labelBCH.Size = new Size(25, 27);
            labelBCH.TabIndex = 60;
            labelBCH.Text = "0";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.FlatStyle = FlatStyle.Popup;
            label23.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            label23.Location = new Point(181, 485);
            label23.Name = "label23";
            label23.Size = new Size(25, 27);
            label23.TabIndex = 65;
            label23.Text = "$";
            // 
            // labelSOLTicker
            // 
            labelSOLTicker.AutoSize = true;
            labelSOLTicker.BackColor = Color.Transparent;
            labelSOLTicker.Enabled = false;
            labelSOLTicker.FlatStyle = FlatStyle.Popup;
            labelSOLTicker.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelSOLTicker.Location = new Point(33, 258);
            labelSOLTicker.Name = "labelSOLTicker";
            labelSOLTicker.Size = new Size(85, 27);
            labelSOLTicker.TabIndex = 46;
            labelSOLTicker.Text = "TICKER";
            // 
            // labelBNB
            // 
            labelBNB.AutoSize = true;
            labelBNB.BackColor = Color.Transparent;
            labelBNB.FlatStyle = FlatStyle.Popup;
            labelBNB.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelBNB.Location = new Point(209, 221);
            labelBNB.Name = "labelBNB";
            labelBNB.Size = new Size(25, 27);
            labelBNB.TabIndex = 42;
            labelBNB.Text = "0";
            // 
            // labelBCHTicker
            // 
            labelBCHTicker.AutoSize = true;
            labelBCHTicker.BackColor = Color.Transparent;
            labelBCHTicker.FlatStyle = FlatStyle.Popup;
            labelBCHTicker.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelBCHTicker.Location = new Point(35, 446);
            labelBCHTicker.Name = "labelBCHTicker";
            labelBCHTicker.Size = new Size(85, 27);
            labelBCHTicker.TabIndex = 61;
            labelBCHTicker.Text = "TICKER";
            // 
            // labelDOTTicker
            // 
            labelDOTTicker.AutoSize = true;
            labelDOTTicker.BackColor = Color.Transparent;
            labelDOTTicker.FlatStyle = FlatStyle.Popup;
            labelDOTTicker.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelDOTTicker.Location = new Point(35, 484);
            labelDOTTicker.Name = "labelDOTTicker";
            labelDOTTicker.Size = new Size(85, 27);
            labelDOTTicker.TabIndex = 64;
            labelDOTTicker.Text = "TICKER";
            // 
            // labelSOL
            // 
            labelSOL.AutoSize = true;
            labelSOL.BackColor = Color.Transparent;
            labelSOL.FlatStyle = FlatStyle.Popup;
            labelSOL.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelSOL.Location = new Point(209, 259);
            labelSOL.Name = "labelSOL";
            labelSOL.Size = new Size(25, 27);
            labelSOL.TabIndex = 45;
            labelSOL.Text = "0";
            // 
            // labelBNBTicker
            // 
            labelBNBTicker.AutoSize = true;
            labelBNBTicker.BackColor = Color.Transparent;
            labelBNBTicker.FlatStyle = FlatStyle.Popup;
            labelBNBTicker.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelBNBTicker.Location = new Point(33, 220);
            labelBNBTicker.Name = "labelBNBTicker";
            labelBNBTicker.Size = new Size(85, 27);
            labelBNBTicker.TabIndex = 43;
            labelBNBTicker.Text = "TICKER";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.FlatStyle = FlatStyle.Popup;
            label20.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            label20.Location = new Point(181, 447);
            label20.Name = "label20";
            label20.Size = new Size(25, 27);
            label20.TabIndex = 62;
            label20.Text = "$";
            // 
            // labelDOT
            // 
            labelDOT.AutoSize = true;
            labelDOT.BackColor = Color.Transparent;
            labelDOT.FlatStyle = FlatStyle.Popup;
            labelDOT.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            labelDOT.Location = new Point(209, 485);
            labelDOT.Name = "labelDOT";
            labelDOT.Size = new Size(25, 27);
            labelDOT.TabIndex = 63;
            labelDOT.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold);
            label2.Location = new Point(181, 221);
            label2.Name = "label2";
            label2.Size = new Size(25, 27);
            label2.TabIndex = 44;
            label2.Text = "$";
            // 
            // marketPanel
            // 
            marketPanel.BackColor = Color.Transparent;
            marketPanel.BorderColor = Color.White;
            marketPanel.BorderRadius = 20;
            marketPanel.Controls.Add(favoriteSwitch);
            marketPanel.Controls.Add(searchBox);
            marketPanel.Controls.Add(label11);
            marketPanel.Controls.Add(label2);
            marketPanel.Controls.Add(labelADA);
            marketPanel.Controls.Add(labelDOT);
            marketPanel.Controls.Add(guna2Separator3);
            marketPanel.Controls.Add(label20);
            marketPanel.Controls.Add(labelDOGETicker);
            marketPanel.Controls.Add(labelBNBTicker);
            marketPanel.Controls.Add(labelBTC);
            marketPanel.Controls.Add(labelSOL);
            marketPanel.Controls.Add(labelADATicker);
            marketPanel.Controls.Add(labelDOTTicker);
            marketPanel.Controls.Add(guna2Separator2);
            marketPanel.Controls.Add(labelBCHTicker);
            marketPanel.Controls.Add(labelDOGE);
            marketPanel.Controls.Add(labelBNB);
            marketPanel.Controls.Add(labelBTCTicker);
            marketPanel.Controls.Add(labelSOLTicker);
            marketPanel.Controls.Add(label14);
            marketPanel.Controls.Add(label23);
            marketPanel.Controls.Add(actionLabel);
            marketPanel.Controls.Add(labelBCH);
            marketPanel.Controls.Add(label8);
            marketPanel.Controls.Add(dollarSymbol2);
            marketPanel.Controls.Add(dollarSymbol);
            marketPanel.Controls.Add(label5);
            marketPanel.Controls.Add(labelAVAX);
            marketPanel.Controls.Add(assetTicker);
            marketPanel.Controls.Add(marketCap);
            marketPanel.Controls.Add(label17);
            marketPanel.Controls.Add(labelXRPTicker);
            marketPanel.Controls.Add(labelETH);
            marketPanel.Controls.Add(labelETHTicker);
            marketPanel.Controls.Add(labelXRP);
            marketPanel.Controls.Add(labelAVAXTicker);
            marketPanel.Controls.Add(priceLabel);
            marketPanel.CustomizableEdges = customizableEdges5;
            marketPanel.FillColor = Color.FromArgb(60, 63, 64);
            marketPanel.Location = new Point(1, 1);
            marketPanel.Name = "marketPanel";
            marketPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            marketPanel.Size = new Size(801, 733);
            marketPanel.TabIndex = 71;
            // 
            // transactionPanel
            // 
            transactionPanel.BackColor = Color.Transparent;
            transactionPanel.BorderRadius = 20;
            transactionPanel.CustomizableEdges = customizableEdges7;
            transactionPanel.FillColor = Color.FromArgb(60, 63, 64);
            transactionPanel.Location = new Point(815, 216);
            transactionPanel.Name = "transactionPanel";
            transactionPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            transactionPanel.Size = new Size(322, 518);
            transactionPanel.TabIndex = 73;
            // 
            // walletPanel
            // 
            walletPanel.BackColor = Color.Transparent;
            walletPanel.BorderRadius = 20;
            walletPanel.Controls.Add(sellButton);
            walletPanel.Controls.Add(buyButton);
            walletPanel.Controls.Add(withdrawButton);
            walletPanel.Controls.Add(depositButton);
            walletPanel.Controls.Add(balance);
            walletPanel.Controls.Add(myBalanceLabel);
            walletPanel.Controls.Add(walletSeparator);
            walletPanel.CustomizableEdges = customizableEdges17;
            walletPanel.FillColor = Color.FromArgb(60, 63, 64);
            walletPanel.Location = new Point(815, 2);
            walletPanel.Name = "walletPanel";
            walletPanel.ShadowDecoration.CustomizableEdges = customizableEdges18;
            walletPanel.Size = new Size(319, 198);
            walletPanel.TabIndex = 72;
            // 
            // sellButton
            // 
            sellButton.BackColor = Color.Transparent;
            sellButton.BorderRadius = 15;
            sellButton.Cursor = Cursors.Hand;
            sellButton.CustomizableEdges = customizableEdges9;
            sellButton.DisabledState.BorderColor = Color.DarkGray;
            sellButton.DisabledState.CustomBorderColor = Color.DarkGray;
            sellButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            sellButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            sellButton.FillColor = Color.IndianRed;
            sellButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sellButton.ForeColor = Color.Black;
            sellButton.Location = new Point(234, 9);
            sellButton.Name = "sellButton";
            sellButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            sellButton.Size = new Size(75, 29);
            sellButton.TabIndex = 57;
            sellButton.Text = "Sell";
            // 
            // buyButton
            // 
            buyButton.BackColor = Color.Transparent;
            buyButton.BorderRadius = 15;
            buyButton.Cursor = Cursors.Hand;
            buyButton.CustomizableEdges = customizableEdges11;
            buyButton.DisabledState.BorderColor = Color.DarkGray;
            buyButton.DisabledState.CustomBorderColor = Color.DarkGray;
            buyButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buyButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buyButton.FillColor = Color.PaleGreen;
            buyButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buyButton.ForeColor = Color.Black;
            buyButton.Location = new Point(151, 10);
            buyButton.Name = "buyButton";
            buyButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            buyButton.Size = new Size(75, 29);
            buyButton.TabIndex = 56;
            buyButton.Text = "Buy";
            // 
            // withdrawButton
            // 
            withdrawButton.BackColor = Color.Transparent;
            withdrawButton.BorderRadius = 15;
            withdrawButton.Cursor = Cursors.Hand;
            withdrawButton.CustomizableEdges = customizableEdges13;
            withdrawButton.DisabledState.BorderColor = Color.DarkGray;
            withdrawButton.DisabledState.CustomBorderColor = Color.DarkGray;
            withdrawButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            withdrawButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            withdrawButton.FillColor = Color.CornflowerBlue;
            withdrawButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withdrawButton.ForeColor = Color.Black;
            withdrawButton.Location = new Point(164, 150);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.ShadowDecoration.CustomizableEdges = customizableEdges14;
            withdrawButton.Size = new Size(128, 39);
            withdrawButton.TabIndex = 55;
            withdrawButton.Text = "Withdraw";
            // 
            // depositButton
            // 
            depositButton.BackColor = Color.Transparent;
            depositButton.BorderRadius = 15;
            depositButton.Cursor = Cursors.Hand;
            depositButton.CustomizableEdges = customizableEdges15;
            depositButton.DisabledState.BorderColor = Color.DarkGray;
            depositButton.DisabledState.CustomBorderColor = Color.DarkGray;
            depositButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            depositButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            depositButton.FillColor = Color.PaleGreen;
            depositButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositButton.ForeColor = Color.Black;
            depositButton.Location = new Point(30, 150);
            depositButton.Name = "depositButton";
            depositButton.ShadowDecoration.CustomizableEdges = customizableEdges16;
            depositButton.Size = new Size(128, 39);
            depositButton.TabIndex = 51;
            depositButton.Text = "Deposit";
            depositButton.Click += depositButton_Click;
            // 
            // balance
            // 
            balance.AutoSize = true;
            balance.BackColor = Color.Transparent;
            balance.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            balance.ForeColor = Color.White;
            balance.Location = new Point(105, 93);
            balance.Name = "balance";
            balance.Size = new Size(109, 27);
            balance.TabIndex = 54;
            balance.Text = "Fetching";
            balance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // myBalanceLabel
            // 
            myBalanceLabel.AutoSize = true;
            myBalanceLabel.BackColor = Color.Transparent;
            myBalanceLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myBalanceLabel.Location = new Point(13, 13);
            myBalanceLabel.Name = "myBalanceLabel";
            myBalanceLabel.Size = new Size(114, 22);
            myBalanceLabel.TabIndex = 53;
            myBalanceLabel.Text = "My Balance";
            // 
            // walletSeparator
            // 
            walletSeparator.BackColor = Color.Transparent;
            walletSeparator.FillColor = Color.Black;
            walletSeparator.FillThickness = 2;
            walletSeparator.Location = new Point(-3, 42);
            walletSeparator.Name = "walletSeparator";
            walletSeparator.Size = new Size(324, 10);
            walletSeparator.TabIndex = 52;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(marketPanel);
            guna2Panel1.Controls.Add(transactionPanel);
            guna2Panel1.Controls.Add(walletPanel);
            guna2Panel1.CustomizableEdges = customizableEdges19;
            guna2Panel1.Location = new Point(3, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2Panel1.Size = new Size(1243, 795);
            guna2Panel1.TabIndex = 74;
            // 
            // UC_Market
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 35, 37);
            Controls.Add(guna2Panel1);
            Name = "UC_Market";
            Size = new Size(1197, 795);
            Load += UC_Market_Load_1;
            marketPanel.ResumeLayout(false);
            marketPanel.PerformLayout();
            walletPanel.ResumeLayout(false);
            walletPanel.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel marketPanel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch favoriteSwitch;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        public Label actionLabel;
        public Label marketCap;
        public Label priceLabel;
        public Label assetTicker;
        public Label label23;
        public Label labelDOTTicker;
        public Label labelDOT;
        public Label label20;
        public Label labelBCHTicker;
        public Label labelBCH;
        public Label label17;
        public Label labelAVAXTicker;
        public Label labelAVAX;
        public Label label14;
        public Label labelADATicker;
        public Label labelADA;
        public Label label11;
        public Label labelDOGETicker;
        public Label labelDOGE;
        public Label label8;
        public Label labelXRPTicker;
        public Label labelXRP;
        public Label label5;
        public Label labelSOLTicker;
        public Label labelSOL;
        public Label label2;
        public Label labelBNBTicker;
        public Label labelBNB;
        public Label dollarSymbol2;
        public Label labelETH;
        public Label labelETHTicker;
        public Label dollarSymbol;
        public Label labelBTCTicker;
        public Label labelBTC;
        
        private Guna.UI2.WinForms.Guna2Panel transactionPanel;
        private Guna.UI2.WinForms.Guna2Panel walletPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button sellButton;
        private Guna.UI2.WinForms.Guna2Button buyButton;
        private Guna.UI2.WinForms.Guna2Button withdrawButton;
        private Guna.UI2.WinForms.Guna2Button depositButton;
        private Label balance;
        private Label myBalanceLabel;
        private Guna.UI2.WinForms.Guna2Separator walletSeparator;
    }
}
