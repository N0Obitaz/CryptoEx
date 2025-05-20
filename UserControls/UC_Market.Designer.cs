

using Guna.UI2.WinForms;

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

           
            for (int i = 0; i < currencies.Length; i++)
            {
               
                string currency = currencies[i];
                Guna2Button actionBtn = new Guna2Button();
                actionBtn.Name = "actionBtn" + i;
                actionBtn.Text = "Trade";
                actionBtn.Size = new Size(80, 35);
                actionBtn.Location = new Point(677, 13);
                actionBtn.Click += Button_Click;
                
                actionBtn.Tag = currency;

               
               
                actionBtn.ForeColor = Color.White;
                actionBtn.BorderRadius = 5;
                actionBtn.BackColor = Color.Transparent;
                actionBtn.Cursor = Cursors.Hand;
                panels[i].Controls.Add(actionBtn);
               
            
            
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges39 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges40 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges37 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges38 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges41 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges42 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            favoriteSwitch = new Guna2ToggleSwitch();
            searchBox = new Guna2TextBox();
            label11 = new Label();
            labelADA = new Label();
            labelDOGETicker = new Label();
            labelBTC = new Label();
            labelADATicker = new Label();
            guna2Separator2 = new Guna2Separator();
            labelDOGE = new Label();
            labelBTCTicker = new Label();
            label14 = new Label();
            actionLabel = new Label();
            label8 = new Label();
            dollarSymbol = new Label();
            labelAVAX = new Label();
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
            marketPanel = new Guna2Panel();
            Panel10 = new Guna2Panel();
            Panel9 = new Guna2Panel();
            Panel8 = new Guna2Panel();
            Panel7 = new Guna2Panel();
            Panel6 = new Guna2Panel();
            Panel5 = new Guna2Panel();
            Panel4 = new Guna2Panel();
            Panel3 = new Guna2Panel();
            Panel2 = new Guna2Panel();
            Panel1 = new Guna2Panel();
            guna2Panel2 = new Guna2Panel();
            favoriteLabel = new Guna2HtmlLabel();
            transactionPanel = new Guna2Panel();
            walletPanel = new Guna2Panel();
            sellButton = new Guna2Button();
            buyButton = new Guna2Button();
            withdrawButton = new Guna2Button();
            depositButton = new Guna2Button();
            balance = new Label();
            myBalanceLabel = new Label();
            walletSeparator = new Guna2Separator();
            guna2Panel1 = new Guna2Panel();
            phpSIgn = new Label();
            marketPanel.SuspendLayout();
            Panel10.SuspendLayout();
            Panel9.SuspendLayout();
            Panel8.SuspendLayout();
            Panel7.SuspendLayout();
            Panel6.SuspendLayout();
            Panel5.SuspendLayout();
            Panel4.SuspendLayout();
            Panel3.SuspendLayout();
            Panel2.SuspendLayout();
            Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
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
            favoriteSwitch.Location = new Point(731, 19);
            favoriteSwitch.Name = "favoriteSwitch";
            favoriteSwitch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            favoriteSwitch.Size = new Size(44, 25);
            favoriteSwitch.TabIndex = 6;
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
            searchBox.Location = new Point(18, 12);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderForeColor = Color.DimGray;
            searchBox.PlaceholderText = "Search";
            searchBox.SelectedText = "";
            searchBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            searchBox.Size = new Size(286, 37);
            searchBox.TabIndex = 72;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.FlatStyle = FlatStyle.Popup;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(273, 13);
            label11.Name = "label11";
            label11.Size = new Size(26, 25);
            label11.TabIndex = 53;
            label11.Text = "₱";
            // 
            // labelADA
            // 
            labelADA.AutoSize = true;
            labelADA.BackColor = Color.Transparent;
            labelADA.FlatStyle = FlatStyle.Popup;
            labelADA.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelADA.ForeColor = Color.White;
            labelADA.Location = new Point(300, 13);
            labelADA.Name = "labelADA";
            labelADA.Size = new Size(24, 25);
            labelADA.TabIndex = 54;
            labelADA.Text = "0";
            // 
            // labelDOGETicker
            // 
            labelDOGETicker.AutoSize = true;
            labelDOGETicker.BackColor = Color.Transparent;
            labelDOGETicker.FlatStyle = FlatStyle.Popup;
            labelDOGETicker.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            labelDOGETicker.ForeColor = Color.White;
            labelDOGETicker.Location = new Point(32, 12);
            labelDOGETicker.Name = "labelDOGETicker";
            labelDOGETicker.Size = new Size(121, 31);
            labelDOGETicker.TabIndex = 52;
            labelDOGETicker.Text = "TICKER";
            // 
            // labelBTC
            // 
            labelBTC.AutoSize = true;
            labelBTC.BackColor = Color.Transparent;
            labelBTC.FlatStyle = FlatStyle.Popup;
            labelBTC.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelBTC.ForeColor = Color.White;
            labelBTC.Location = new Point(300, 13);
            labelBTC.Name = "labelBTC";
            labelBTC.Size = new Size(24, 25);
            labelBTC.TabIndex = 36;
            labelBTC.Text = "0";
            // 
            // labelADATicker
            // 
            labelADATicker.AutoSize = true;
            labelADATicker.BackColor = Color.Transparent;
            labelADATicker.FlatStyle = FlatStyle.Popup;
            labelADATicker.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            labelADATicker.ForeColor = Color.White;
            labelADATicker.Location = new Point(32, 11);
            labelADATicker.Name = "labelADATicker";
            labelADATicker.Size = new Size(121, 31);
            labelADATicker.TabIndex = 55;
            labelADATicker.Text = "TICKER";
            // 
            // guna2Separator2
            // 
            guna2Separator2.BackColor = Color.Transparent;
            guna2Separator2.FillColor = Color.Black;
            guna2Separator2.FillThickness = 2;
            guna2Separator2.Location = new Point(2, 65);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new Size(801, 10);
            guna2Separator2.TabIndex = 70;
            // 
            // labelDOGE
            // 
            labelDOGE.AutoSize = true;
            labelDOGE.BackColor = Color.Transparent;
            labelDOGE.FlatStyle = FlatStyle.Popup;
            labelDOGE.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelDOGE.ForeColor = Color.White;
            labelDOGE.Location = new Point(300, 13);
            labelDOGE.Name = "labelDOGE";
            labelDOGE.Size = new Size(24, 25);
            labelDOGE.TabIndex = 51;
            labelDOGE.Text = "0";
            // 
            // labelBTCTicker
            // 
            labelBTCTicker.AutoSize = true;
            labelBTCTicker.BackColor = Color.Transparent;
            labelBTCTicker.FlatStyle = FlatStyle.Popup;
            labelBTCTicker.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            labelBTCTicker.ForeColor = Color.White;
            labelBTCTicker.Location = new Point(32, 7);
            labelBTCTicker.Margin = new Padding(0);
            labelBTCTicker.Name = "labelBTCTicker";
            labelBTCTicker.Size = new Size(121, 31);
            labelBTCTicker.TabIndex = 37;
            labelBTCTicker.Text = "TICKER";
            labelBTCTicker.TextAlign = ContentAlignment.TopCenter;
            labelBTCTicker.Click += labelBTCTicker_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.FlatStyle = FlatStyle.Popup;
            label14.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(273, 13);
            label14.Name = "label14";
            label14.Size = new Size(26, 25);
            label14.TabIndex = 56;
            label14.Text = "₱";
            // 
            // actionLabel
            // 
            actionLabel.AutoSize = true;
            actionLabel.BackColor = Color.Transparent;
            actionLabel.FlatStyle = FlatStyle.Popup;
            actionLabel.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            actionLabel.ForeColor = Color.White;
            actionLabel.Location = new Point(677, 13);
            actionLabel.Margin = new Padding(0);
            actionLabel.Name = "actionLabel";
            actionLabel.Size = new Size(91, 31);
            actionLabel.TabIndex = 69;
            actionLabel.Text = "Action";
            actionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(273, 13);
            label8.Name = "label8";
            label8.Size = new Size(26, 25);
            label8.TabIndex = 50;
            label8.Text = "₱";
            // 
            // dollarSymbol
            // 
            dollarSymbol.AutoSize = true;
            dollarSymbol.BackColor = Color.Transparent;
            dollarSymbol.FlatStyle = FlatStyle.Popup;
            dollarSymbol.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dollarSymbol.ForeColor = Color.White;
            dollarSymbol.Location = new Point(273, 13);
            dollarSymbol.Name = "dollarSymbol";
            dollarSymbol.Size = new Size(26, 25);
            dollarSymbol.TabIndex = 38;
            dollarSymbol.Text = "₱";
            // 
            // labelAVAX
            // 
            labelAVAX.AutoSize = true;
            labelAVAX.BackColor = Color.Transparent;
            labelAVAX.FlatStyle = FlatStyle.Popup;
            labelAVAX.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelAVAX.ForeColor = Color.White;
            labelAVAX.Location = new Point(300, 13);
            labelAVAX.Name = "labelAVAX";
            labelAVAX.Size = new Size(24, 25);
            labelAVAX.TabIndex = 57;
            labelAVAX.Text = "0";
            // 
            // labelXRPTicker
            // 
            labelXRPTicker.AutoSize = true;
            labelXRPTicker.BackColor = Color.Transparent;
            labelXRPTicker.FlatStyle = FlatStyle.Popup;
            labelXRPTicker.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            labelXRPTicker.ForeColor = Color.White;
            labelXRPTicker.Location = new Point(32, 9);
            labelXRPTicker.Name = "labelXRPTicker";
            labelXRPTicker.Size = new Size(121, 31);
            labelXRPTicker.TabIndex = 49;
            labelXRPTicker.Text = "TICKER";
            // 
            // labelETHTicker
            // 
            labelETHTicker.AutoSize = true;
            labelETHTicker.BackColor = Color.Transparent;
            labelETHTicker.FlatStyle = FlatStyle.Popup;
            labelETHTicker.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            labelETHTicker.ForeColor = Color.White;
            labelETHTicker.Location = new Point(32, 10);
            labelETHTicker.Name = "labelETHTicker";
            labelETHTicker.Size = new Size(121, 31);
            labelETHTicker.TabIndex = 39;
            labelETHTicker.Text = "TICKER";
            // 
            // labelAVAXTicker
            // 
            labelAVAXTicker.AutoSize = true;
            labelAVAXTicker.BackColor = Color.Transparent;
            labelAVAXTicker.FlatStyle = FlatStyle.Popup;
            labelAVAXTicker.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            labelAVAXTicker.ForeColor = Color.White;
            labelAVAXTicker.Location = new Point(32, 11);
            labelAVAXTicker.Name = "labelAVAXTicker";
            labelAVAXTicker.Size = new Size(121, 31);
            labelAVAXTicker.TabIndex = 58;
            labelAVAXTicker.Text = "TICKER";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.Transparent;
            priceLabel.FlatStyle = FlatStyle.Popup;
            priceLabel.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            priceLabel.ForeColor = Color.White;
            priceLabel.Location = new Point(273, 13);
            priceLabel.Margin = new Padding(0);
            priceLabel.Name = "priceLabel";
            priceLabel.Padding = new Padding(20, 0, 0, 0);
            priceLabel.RightToLeft = RightToLeft.No;
            priceLabel.Size = new Size(95, 31);
            priceLabel.TabIndex = 67;
            priceLabel.Text = "Price";
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelXRP
            // 
            labelXRP.AutoSize = true;
            labelXRP.BackColor = Color.Transparent;
            labelXRP.FlatStyle = FlatStyle.Popup;
            labelXRP.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelXRP.ForeColor = Color.White;
            labelXRP.Location = new Point(300, 13);
            labelXRP.Name = "labelXRP";
            labelXRP.Size = new Size(24, 25);
            labelXRP.TabIndex = 48;
            labelXRP.Text = "0";
            // 
            // labelETH
            // 
            labelETH.AutoSize = true;
            labelETH.BackColor = Color.Transparent;
            labelETH.FlatStyle = FlatStyle.Popup;
            labelETH.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelETH.ForeColor = Color.White;
            labelETH.Location = new Point(300, 13);
            labelETH.Name = "labelETH";
            labelETH.Size = new Size(24, 25);
            labelETH.TabIndex = 40;
            labelETH.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.FlatStyle = FlatStyle.Popup;
            label17.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label17.ForeColor = Color.White;
            label17.Location = new Point(273, 13);
            label17.Name = "label17";
            label17.Size = new Size(26, 25);
            label17.TabIndex = 59;
            label17.Text = "₱";
            // 
            // assetTicker
            // 
            assetTicker.AutoSize = true;
            assetTicker.BackColor = Color.Transparent;
            assetTicker.FlatStyle = FlatStyle.Popup;
            assetTicker.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            assetTicker.ForeColor = Color.White;
            assetTicker.Location = new Point(32, 13);
            assetTicker.Margin = new Padding(0);
            assetTicker.Name = "assetTicker";
            assetTicker.Size = new Size(76, 31);
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
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(273, 13);
            label5.Name = "label5";
            label5.Size = new Size(26, 25);
            label5.TabIndex = 47;
            label5.Text = "₱";
            // 
            // dollarSymbol2
            // 
            dollarSymbol2.AutoSize = true;
            dollarSymbol2.BackColor = Color.Transparent;
            dollarSymbol2.FlatStyle = FlatStyle.Popup;
            dollarSymbol2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dollarSymbol2.ForeColor = Color.White;
            dollarSymbol2.Location = new Point(273, 13);
            dollarSymbol2.Name = "dollarSymbol2";
            dollarSymbol2.Size = new Size(26, 25);
            dollarSymbol2.TabIndex = 41;
            dollarSymbol2.Text = "₱";
            // 
            // labelBCH
            // 
            labelBCH.AutoSize = true;
            labelBCH.BackColor = Color.Transparent;
            labelBCH.FlatStyle = FlatStyle.Popup;
            labelBCH.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelBCH.ForeColor = Color.White;
            labelBCH.Location = new Point(300, 13);
            labelBCH.Name = "labelBCH";
            labelBCH.Size = new Size(24, 25);
            labelBCH.TabIndex = 60;
            labelBCH.Text = "0";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.FlatStyle = FlatStyle.Popup;
            label23.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label23.ForeColor = Color.White;
            label23.Location = new Point(273, 13);
            label23.Name = "label23";
            label23.Size = new Size(26, 25);
            label23.TabIndex = 65;
            label23.Text = "₱";
            // 
            // labelSOLTicker
            // 
            labelSOLTicker.AutoSize = true;
            labelSOLTicker.BackColor = Color.Transparent;
            labelSOLTicker.Enabled = false;
            labelSOLTicker.FlatStyle = FlatStyle.Popup;
            labelSOLTicker.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            labelSOLTicker.ForeColor = Color.White;
            labelSOLTicker.Location = new Point(32, 10);
            labelSOLTicker.Name = "labelSOLTicker";
            labelSOLTicker.Size = new Size(121, 31);
            labelSOLTicker.TabIndex = 46;
            labelSOLTicker.Text = "TICKER";
            // 
            // labelBNB
            // 
            labelBNB.AutoSize = true;
            labelBNB.BackColor = Color.Transparent;
            labelBNB.FlatStyle = FlatStyle.Popup;
            labelBNB.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelBNB.ForeColor = Color.White;
            labelBNB.Location = new Point(300, 13);
            labelBNB.Name = "labelBNB";
            labelBNB.Size = new Size(24, 25);
            labelBNB.TabIndex = 42;
            labelBNB.Text = "0";
            // 
            // labelBCHTicker
            // 
            labelBCHTicker.AutoSize = true;
            labelBCHTicker.BackColor = Color.Transparent;
            labelBCHTicker.FlatStyle = FlatStyle.Popup;
            labelBCHTicker.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            labelBCHTicker.ForeColor = Color.White;
            labelBCHTicker.Location = new Point(32, 12);
            labelBCHTicker.Name = "labelBCHTicker";
            labelBCHTicker.Size = new Size(121, 31);
            labelBCHTicker.TabIndex = 61;
            labelBCHTicker.Text = "TICKER";
            // 
            // labelDOTTicker
            // 
            labelDOTTicker.AutoSize = true;
            labelDOTTicker.BackColor = Color.Transparent;
            labelDOTTicker.FlatStyle = FlatStyle.Popup;
            labelDOTTicker.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            labelDOTTicker.ForeColor = Color.White;
            labelDOTTicker.Location = new Point(32, 11);
            labelDOTTicker.Name = "labelDOTTicker";
            labelDOTTicker.Size = new Size(121, 31);
            labelDOTTicker.TabIndex = 64;
            labelDOTTicker.Text = "TICKER";
            // 
            // labelSOL
            // 
            labelSOL.AutoSize = true;
            labelSOL.BackColor = Color.Transparent;
            labelSOL.FlatStyle = FlatStyle.Popup;
            labelSOL.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelSOL.ForeColor = Color.White;
            labelSOL.Location = new Point(300, 13);
            labelSOL.Name = "labelSOL";
            labelSOL.Size = new Size(24, 25);
            labelSOL.TabIndex = 45;
            labelSOL.Text = "0";
            // 
            // labelBNBTicker
            // 
            labelBNBTicker.AutoSize = true;
            labelBNBTicker.BackColor = Color.Transparent;
            labelBNBTicker.FlatStyle = FlatStyle.Popup;
            labelBNBTicker.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            labelBNBTicker.ForeColor = Color.White;
            labelBNBTicker.Location = new Point(32, 9);
            labelBNBTicker.Name = "labelBNBTicker";
            labelBNBTicker.Size = new Size(121, 31);
            labelBNBTicker.TabIndex = 43;
            labelBNBTicker.Text = "TICKER";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.FlatStyle = FlatStyle.Popup;
            label20.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label20.ForeColor = Color.White;
            label20.Location = new Point(273, 13);
            label20.Name = "label20";
            label20.Size = new Size(26, 25);
            label20.TabIndex = 62;
            label20.Text = "₱";
            // 
            // labelDOT
            // 
            labelDOT.AutoSize = true;
            labelDOT.BackColor = Color.Transparent;
            labelDOT.FlatStyle = FlatStyle.Popup;
            labelDOT.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelDOT.ForeColor = Color.White;
            labelDOT.Location = new Point(300, 13);
            labelDOT.Name = "labelDOT";
            labelDOT.Size = new Size(24, 25);
            labelDOT.TabIndex = 63;
            labelDOT.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(273, 13);
            label2.Name = "label2";
            label2.Size = new Size(26, 25);
            label2.TabIndex = 44;
            label2.Text = "₱";
            // 
            // marketPanel
            // 
            marketPanel.BackColor = Color.Transparent;
            marketPanel.BorderColor = Color.White;
            marketPanel.BorderRadius = 20;
            marketPanel.Controls.Add(Panel10);
            marketPanel.Controls.Add(Panel9);
            marketPanel.Controls.Add(Panel8);
            marketPanel.Controls.Add(Panel7);
            marketPanel.Controls.Add(Panel6);
            marketPanel.Controls.Add(Panel5);
            marketPanel.Controls.Add(Panel4);
            marketPanel.Controls.Add(Panel3);
            marketPanel.Controls.Add(Panel2);
            marketPanel.Controls.Add(Panel1);
            marketPanel.Controls.Add(guna2Panel2);
            marketPanel.Controls.Add(favoriteLabel);
            marketPanel.Controls.Add(favoriteSwitch);
            marketPanel.Controls.Add(searchBox);
            marketPanel.Controls.Add(guna2Separator2);
            marketPanel.CustomizableEdges = customizableEdges27;
            marketPanel.FillColor = Color.FromArgb(60, 63, 64);
            marketPanel.Location = new Point(1, 1);
            marketPanel.Name = "marketPanel";
            marketPanel.ShadowDecoration.CustomizableEdges = customizableEdges28;
            marketPanel.Size = new Size(801, 733);
            marketPanel.TabIndex = 71;
            // 
            // Panel10
            // 
            Panel10.Controls.Add(labelDOTTicker);
            Panel10.Controls.Add(label23);
            Panel10.Controls.Add(labelDOT);
            Panel10.CustomizableEdges = customizableEdges5;
            Panel10.Location = new Point(18, 648);
            Panel10.Name = "Panel10";
            Panel10.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Panel10.Size = new Size(770, 55);
            Panel10.TabIndex = 83;
            // 
            // Panel9
            // 
            Panel9.Controls.Add(labelBCHTicker);
            Panel9.Controls.Add(labelBCH);
            Panel9.Controls.Add(label20);
            Panel9.CustomizableEdges = customizableEdges7;
            Panel9.Location = new Point(18, 592);
            Panel9.Name = "Panel9";
            Panel9.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Panel9.Size = new Size(770, 55);
            Panel9.TabIndex = 82;
            // 
            // Panel8
            // 
            Panel8.Controls.Add(labelAVAXTicker);
            Panel8.Controls.Add(label17);
            Panel8.Controls.Add(labelAVAX);
            Panel8.CustomizableEdges = customizableEdges9;
            Panel8.Location = new Point(18, 536);
            Panel8.Name = "Panel8";
            Panel8.ShadowDecoration.CustomizableEdges = customizableEdges10;
            Panel8.Size = new Size(770, 55);
            Panel8.TabIndex = 81;
            // 
            // Panel7
            // 
            Panel7.Controls.Add(labelADATicker);
            Panel7.Controls.Add(label14);
            Panel7.Controls.Add(labelADA);
            Panel7.CustomizableEdges = customizableEdges11;
            Panel7.Location = new Point(18, 480);
            Panel7.Name = "Panel7";
            Panel7.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Panel7.Size = new Size(770, 55);
            Panel7.TabIndex = 80;
            // 
            // Panel6
            // 
            Panel6.Controls.Add(labelDOGETicker);
            Panel6.Controls.Add(label11);
            Panel6.Controls.Add(labelDOGE);
            Panel6.CustomizableEdges = customizableEdges13;
            Panel6.Location = new Point(18, 424);
            Panel6.Name = "Panel6";
            Panel6.ShadowDecoration.CustomizableEdges = customizableEdges14;
            Panel6.Size = new Size(770, 55);
            Panel6.TabIndex = 79;
            // 
            // Panel5
            // 
            Panel5.Controls.Add(labelXRPTicker);
            Panel5.Controls.Add(labelXRP);
            Panel5.Controls.Add(label8);
            Panel5.CustomizableEdges = customizableEdges15;
            Panel5.Location = new Point(18, 368);
            Panel5.Name = "Panel5";
            Panel5.ShadowDecoration.CustomizableEdges = customizableEdges16;
            Panel5.Size = new Size(770, 55);
            Panel5.TabIndex = 78;
            // 
            // Panel4
            // 
            Panel4.Controls.Add(labelSOLTicker);
            Panel4.Controls.Add(label5);
            Panel4.Controls.Add(labelSOL);
            Panel4.CustomizableEdges = customizableEdges17;
            Panel4.Location = new Point(18, 312);
            Panel4.Name = "Panel4";
            Panel4.ShadowDecoration.CustomizableEdges = customizableEdges18;
            Panel4.Size = new Size(770, 55);
            Panel4.TabIndex = 0;
            // 
            // Panel3
            // 
            Panel3.Controls.Add(labelBNBTicker);
            Panel3.Controls.Add(labelBNB);
            Panel3.Controls.Add(label2);
            Panel3.CustomizableEdges = customizableEdges19;
            Panel3.Location = new Point(18, 256);
            Panel3.Name = "Panel3";
            Panel3.ShadowDecoration.CustomizableEdges = customizableEdges20;
            Panel3.Size = new Size(770, 55);
            Panel3.TabIndex = 42;
            // 
            // Panel2
            // 
            Panel2.Controls.Add(labelETHTicker);
            Panel2.Controls.Add(labelETH);
            Panel2.Controls.Add(dollarSymbol2);
            Panel2.CustomizableEdges = customizableEdges21;
            Panel2.Location = new Point(18, 200);
            Panel2.Name = "Panel2";
            Panel2.ShadowDecoration.CustomizableEdges = customizableEdges22;
            Panel2.Size = new Size(770, 55);
            Panel2.TabIndex = 77;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(labelBTCTicker);
            Panel1.Controls.Add(labelBTC);
            Panel1.Controls.Add(dollarSymbol);
            Panel1.CustomizableEdges = customizableEdges23;
            Panel1.Location = new Point(18, 144);
            Panel1.Name = "Panel1";
            Panel1.ShadowDecoration.CustomizableEdges = customizableEdges24;
            Panel1.Size = new Size(770, 55);
            Panel1.TabIndex = 76;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(assetTicker);
            guna2Panel2.Controls.Add(priceLabel);
            guna2Panel2.Controls.Add(actionLabel);
            guna2Panel2.CustomizableEdges = customizableEdges25;
            guna2Panel2.Location = new Point(18, 83);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges26;
            guna2Panel2.Size = new Size(770, 55);
            guna2Panel2.TabIndex = 75;
            // 
            // favoriteLabel
            // 
            favoriteLabel.BackColor = Color.Transparent;
            favoriteLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            favoriteLabel.ForeColor = Color.White;
            favoriteLabel.Location = new Point(636, 17);
            favoriteLabel.Name = "favoriteLabel";
            favoriteLabel.Size = new Size(80, 27);
            favoriteLabel.TabIndex = 74;
            favoriteLabel.Text = "Favorites";
            // 
            // transactionPanel
            // 
            transactionPanel.BackColor = Color.Transparent;
            transactionPanel.BorderRadius = 20;
            transactionPanel.CustomizableEdges = customizableEdges29;
            transactionPanel.FillColor = Color.FromArgb(60, 63, 64);
            transactionPanel.Location = new Point(815, 216);
            transactionPanel.Name = "transactionPanel";
            transactionPanel.ShadowDecoration.CustomizableEdges = customizableEdges30;
            transactionPanel.Size = new Size(322, 518);
            transactionPanel.TabIndex = 73;
            // 
            // walletPanel
            // 
            walletPanel.BackColor = Color.Transparent;
            walletPanel.BorderRadius = 20;
            walletPanel.Controls.Add(phpSIgn);
            walletPanel.Controls.Add(sellButton);
            walletPanel.Controls.Add(buyButton);
            walletPanel.Controls.Add(withdrawButton);
            walletPanel.Controls.Add(depositButton);
            walletPanel.Controls.Add(balance);
            walletPanel.Controls.Add(myBalanceLabel);
            walletPanel.Controls.Add(walletSeparator);
            walletPanel.CustomizableEdges = customizableEdges39;
            walletPanel.FillColor = Color.FromArgb(60, 63, 64);
            walletPanel.Location = new Point(815, 2);
            walletPanel.Name = "walletPanel";
            walletPanel.ShadowDecoration.CustomizableEdges = customizableEdges40;
            walletPanel.Size = new Size(319, 198);
            walletPanel.TabIndex = 72;
            // 
            // sellButton
            // 
            sellButton.BackColor = Color.Transparent;
            sellButton.BorderRadius = 15;
            sellButton.Cursor = Cursors.Hand;
            sellButton.CustomizableEdges = customizableEdges31;
            sellButton.DisabledState.BorderColor = Color.DarkGray;
            sellButton.DisabledState.CustomBorderColor = Color.DarkGray;
            sellButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            sellButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            sellButton.FillColor = Color.IndianRed;
            sellButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sellButton.ForeColor = Color.Black;
            sellButton.Location = new Point(234, 9);
            sellButton.Name = "sellButton";
            sellButton.ShadowDecoration.CustomizableEdges = customizableEdges32;
            sellButton.Size = new Size(75, 29);
            sellButton.TabIndex = 57;
            sellButton.Text = "Sell";
            // 
            // buyButton
            // 
            buyButton.BackColor = Color.Transparent;
            buyButton.BorderRadius = 15;
            buyButton.Cursor = Cursors.Hand;
            buyButton.CustomizableEdges = customizableEdges33;
            buyButton.DisabledState.BorderColor = Color.DarkGray;
            buyButton.DisabledState.CustomBorderColor = Color.DarkGray;
            buyButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buyButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buyButton.FillColor = Color.PaleGreen;
            buyButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buyButton.ForeColor = Color.Black;
            buyButton.Location = new Point(151, 10);
            buyButton.Name = "buyButton";
            buyButton.ShadowDecoration.CustomizableEdges = customizableEdges34;
            buyButton.Size = new Size(75, 29);
            buyButton.TabIndex = 56;
            buyButton.Text = "Buy";
            buyButton.Click += buyButton_Click;
            // 
            // withdrawButton
            // 
            withdrawButton.BackColor = Color.Transparent;
            withdrawButton.BorderRadius = 15;
            withdrawButton.Cursor = Cursors.Hand;
            withdrawButton.CustomizableEdges = customizableEdges35;
            withdrawButton.DisabledState.BorderColor = Color.DarkGray;
            withdrawButton.DisabledState.CustomBorderColor = Color.DarkGray;
            withdrawButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            withdrawButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            withdrawButton.FillColor = Color.CornflowerBlue;
            withdrawButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withdrawButton.ForeColor = Color.Black;
            withdrawButton.Location = new Point(164, 150);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.ShadowDecoration.CustomizableEdges = customizableEdges36;
            withdrawButton.Size = new Size(128, 39);
            withdrawButton.TabIndex = 55;
            withdrawButton.Text = "Withdraw";
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.BackColor = Color.Transparent;
            depositButton.BorderRadius = 15;
            depositButton.Cursor = Cursors.Hand;
            depositButton.CustomizableEdges = customizableEdges37;
            depositButton.DisabledState.BorderColor = Color.DarkGray;
            depositButton.DisabledState.CustomBorderColor = Color.DarkGray;
            depositButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            depositButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            depositButton.FillColor = Color.PaleGreen;
            depositButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositButton.ForeColor = Color.Black;
            depositButton.Location = new Point(30, 150);
            depositButton.Name = "depositButton";
            depositButton.ShadowDecoration.CustomizableEdges = customizableEdges38;
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
            guna2Panel1.CustomizableEdges = customizableEdges41;
            guna2Panel1.Location = new Point(3, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges42;
            guna2Panel1.Size = new Size(1243, 795);
            guna2Panel1.TabIndex = 74;
            // 
            // phpSIgn
            // 
            phpSIgn.AutoSize = true;
            phpSIgn.BackColor = Color.Transparent;
            phpSIgn.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            phpSIgn.ForeColor = Color.White;
            phpSIgn.Location = new Point(45, 93);
            phpSIgn.Name = "phpSIgn";
            phpSIgn.Size = new Size(54, 27);
            phpSIgn.TabIndex = 58;
            phpSIgn.Text = "PHP";
            phpSIgn.TextAlign = ContentAlignment.MiddleCenter;
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
            Panel10.ResumeLayout(false);
            Panel10.PerformLayout();
            Panel9.ResumeLayout(false);
            Panel9.PerformLayout();
            Panel8.ResumeLayout(false);
            Panel8.PerformLayout();
            Panel7.ResumeLayout(false);
            Panel7.PerformLayout();
            Panel6.ResumeLayout(false);
            Panel6.PerformLayout();
            Panel5.ResumeLayout(false);
            Panel5.PerformLayout();
            Panel4.ResumeLayout(false);
            Panel4.PerformLayout();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            walletPanel.ResumeLayout(false);
            walletPanel.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion



        private Guna.UI2.WinForms.Guna2Panel marketPanel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch favoriteSwitch;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        public Label actionLabel;
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel favoriteLabel;
        public Guna2Panel Panel2;
        public Guna2Panel Panel1;
        public Guna2Panel Panel6;
        public Guna2Panel Panel5;
        public Guna2Panel Panel4;
        public Guna2Panel Panel3;
        public Guna2Panel Panel9;
        public Guna2Panel Panel8;
        public Guna2Panel Panel7;
        public Guna2Panel Panel10;
        private Label phpSIgn;
    }
}
