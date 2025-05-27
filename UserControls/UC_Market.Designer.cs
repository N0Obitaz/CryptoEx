

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
                actionBtn.Location = new Point(631, 13);
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges43 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges44 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Market));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges39 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges40 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges37 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges38 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges41 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges42 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges47 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges48 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges45 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges46 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges53 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges54 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges49 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges50 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges51 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges52 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges55 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges56 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            guna2Button10 = new Guna2Button();
            Panel9 = new Guna2Panel();
            guna2Button9 = new Guna2Button();
            Panel8 = new Guna2Panel();
            guna2Button8 = new Guna2Button();
            Panel7 = new Guna2Panel();
            guna2Button7 = new Guna2Button();
            Panel6 = new Guna2Panel();
            guna2Button6 = new Guna2Button();
            Panel5 = new Guna2Panel();
            guna2Button5 = new Guna2Button();
            Panel4 = new Guna2Panel();
            guna2Button4 = new Guna2Button();
            Panel3 = new Guna2Panel();
            guna2Button3 = new Guna2Button();
            Panel2 = new Guna2Panel();
            guna2Button2 = new Guna2Button();
            Panel1 = new Guna2Panel();
            guna2Button1 = new Guna2Button();
            guna2Panel2 = new Guna2Panel();
            favoriteLabel = new Guna2HtmlLabel();
            favoritesPanel = new Guna2Panel();
            outerPanel = new Guna2Panel();
            guna2Separator1 = new Guna2Separator();
            walletPanel = new Guna2Panel();
            phpSIgn = new Label();
            sellButton = new Guna2Button();
            buyButton = new Guna2Button();
            balance = new Label();
            myBalanceLabel = new Label();
            walletSeparator = new Guna2Separator();
            guna2Panel1 = new Guna2Panel();
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
            favoritesPanel.SuspendLayout();
            walletPanel.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.FlatStyle = FlatStyle.Popup;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(320, 13);
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
            labelADA.Location = new Point(350, 13);
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
            labelBTC.Location = new Point(350, 13);
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
            labelDOGE.Location = new Point(350, 13);
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
            label14.Location = new Point(320, 13);
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
            actionLabel.Location = new Point(631, 13);
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
            label8.Location = new Point(320, 13);
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
            dollarSymbol.Location = new Point(320, 13);
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
            labelAVAX.Location = new Point(350, 13);
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
            priceLabel.Location = new Point(323, 13);
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
            labelXRP.Location = new Point(350, 13);
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
            labelETH.Location = new Point(350, 13);
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
            label17.Location = new Point(320, 13);
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
            label5.Location = new Point(320, 13);
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
            dollarSymbol2.Location = new Point(320, 13);
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
            labelBCH.Location = new Point(350, 13);
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
            label23.Location = new Point(320, 13);
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
            labelBNB.Location = new Point(350, 13);
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
            labelSOL.Location = new Point(350, 13);
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
            label20.Location = new Point(320, 13);
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
            labelDOT.Location = new Point(350, 13);
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
            label2.Location = new Point(320, 13);
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
            marketPanel.Controls.Add(guna2Separator2);
            marketPanel.CustomizableEdges = customizableEdges43;
            marketPanel.FillColor = Color.FromArgb(60, 63, 64);
            marketPanel.Location = new Point(1, 1);
            marketPanel.Name = "marketPanel";
            marketPanel.ShadowDecoration.CustomizableEdges = customizableEdges44;
            marketPanel.Size = new Size(801, 733);
            marketPanel.TabIndex = 71;
            marketPanel.Paint += marketPanel_Paint_1;
            // 
            // Panel10
            // 
            Panel10.Controls.Add(guna2Button10);
            Panel10.Controls.Add(labelDOTTicker);
            Panel10.Controls.Add(label23);
            Panel10.Controls.Add(labelDOT);
            Panel10.CustomizableEdges = customizableEdges3;
            Panel10.Location = new Point(18, 648);
            Panel10.Name = "Panel10";
            Panel10.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Panel10.Size = new Size(740, 55);
            Panel10.TabIndex = 83;
            // 
            // guna2Button10
            // 
            guna2Button10.Cursor = Cursors.Hand;
            guna2Button10.CustomizableEdges = customizableEdges1;
            guna2Button10.DisabledState.BorderColor = Color.DarkGray;
            guna2Button10.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button10.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button10.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button10.FillColor = Color.Transparent;
            guna2Button10.Font = new Font("Segoe UI", 9F);
            guna2Button10.ForeColor = Color.White;
            guna2Button10.HoverState.FillColor = Color.Transparent;
            guna2Button10.HoverState.Image = (Image)resources.GetObject("resource.Image");
            guna2Button10.Image = (Image)resources.GetObject("guna2Button10.Image");
            guna2Button10.ImageSize = new Size(80, 80);
            guna2Button10.Location = new Point(186, 6);
            guna2Button10.Name = "guna2Button10";
            guna2Button10.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button10.Size = new Size(40, 40);
            guna2Button10.TabIndex = 66;
            guna2Button10.Tag = "DOT";
            guna2Button10.Click += AddToFavorite;
            // 
            // Panel9
            // 
            Panel9.Controls.Add(guna2Button9);
            Panel9.Controls.Add(labelBCHTicker);
            Panel9.Controls.Add(labelBCH);
            Panel9.Controls.Add(label20);
            Panel9.CustomizableEdges = customizableEdges7;
            Panel9.Location = new Point(18, 592);
            Panel9.Name = "Panel9";
            Panel9.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Panel9.Size = new Size(740, 55);
            Panel9.TabIndex = 82;
            // 
            // guna2Button9
            // 
            guna2Button9.Cursor = Cursors.Hand;
            guna2Button9.CustomizableEdges = customizableEdges5;
            guna2Button9.DisabledState.BorderColor = Color.DarkGray;
            guna2Button9.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button9.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button9.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button9.FillColor = Color.Transparent;
            guna2Button9.Font = new Font("Segoe UI", 9F);
            guna2Button9.ForeColor = Color.White;
            guna2Button9.HoverState.FillColor = Color.Transparent;
            guna2Button9.HoverState.Image = (Image)resources.GetObject("resource.Image1");
            guna2Button9.Image = (Image)resources.GetObject("guna2Button9.Image");
            guna2Button9.ImageSize = new Size(80, 80);
            guna2Button9.Location = new Point(186, 6);
            guna2Button9.Name = "guna2Button9";
            guna2Button9.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button9.Size = new Size(40, 40);
            guna2Button9.TabIndex = 63;
            guna2Button9.Tag = "BCH";
            guna2Button9.Click += AddToFavorite;
            // 
            // Panel8
            // 
            Panel8.Controls.Add(guna2Button8);
            Panel8.Controls.Add(labelAVAXTicker);
            Panel8.Controls.Add(label17);
            Panel8.Controls.Add(labelAVAX);
            Panel8.CustomizableEdges = customizableEdges11;
            Panel8.Location = new Point(18, 536);
            Panel8.Name = "Panel8";
            Panel8.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Panel8.Size = new Size(740, 55);
            Panel8.TabIndex = 81;
            // 
            // guna2Button8
            // 
            guna2Button8.Cursor = Cursors.Hand;
            guna2Button8.CustomizableEdges = customizableEdges9;
            guna2Button8.DisabledState.BorderColor = Color.DarkGray;
            guna2Button8.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button8.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button8.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button8.FillColor = Color.Transparent;
            guna2Button8.Font = new Font("Segoe UI", 9F);
            guna2Button8.ForeColor = Color.White;
            guna2Button8.HoverState.FillColor = Color.Transparent;
            guna2Button8.HoverState.Image = (Image)resources.GetObject("resource.Image2");
            guna2Button8.Image = (Image)resources.GetObject("guna2Button8.Image");
            guna2Button8.ImageSize = new Size(80, 80);
            guna2Button8.Location = new Point(186, 6);
            guna2Button8.Name = "guna2Button8";
            guna2Button8.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button8.Size = new Size(40, 40);
            guna2Button8.TabIndex = 60;
            guna2Button8.Tag = "AVAX";
            guna2Button8.Click += AddToFavorite;
            // 
            // Panel7
            // 
            Panel7.Controls.Add(guna2Button7);
            Panel7.Controls.Add(labelADATicker);
            Panel7.Controls.Add(label14);
            Panel7.Controls.Add(labelADA);
            Panel7.CustomizableEdges = customizableEdges15;
            Panel7.Location = new Point(18, 480);
            Panel7.Name = "Panel7";
            Panel7.ShadowDecoration.CustomizableEdges = customizableEdges16;
            Panel7.Size = new Size(740, 55);
            Panel7.TabIndex = 80;
            // 
            // guna2Button7
            // 
            guna2Button7.Cursor = Cursors.Hand;
            guna2Button7.CustomizableEdges = customizableEdges13;
            guna2Button7.DisabledState.BorderColor = Color.DarkGray;
            guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button7.FillColor = Color.Transparent;
            guna2Button7.Font = new Font("Segoe UI", 9F);
            guna2Button7.ForeColor = Color.White;
            guna2Button7.HoverState.FillColor = Color.Transparent;
            guna2Button7.HoverState.Image = (Image)resources.GetObject("resource.Image3");
            guna2Button7.Image = (Image)resources.GetObject("guna2Button7.Image");
            guna2Button7.ImageSize = new Size(80, 80);
            guna2Button7.Location = new Point(186, 6);
            guna2Button7.Name = "guna2Button7";
            guna2Button7.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Button7.Size = new Size(40, 40);
            guna2Button7.TabIndex = 57;
            guna2Button7.Tag = "ADA";
            guna2Button7.Click += AddToFavorite;
            // 
            // Panel6
            // 
            Panel6.Controls.Add(guna2Button6);
            Panel6.Controls.Add(labelDOGETicker);
            Panel6.Controls.Add(label11);
            Panel6.Controls.Add(labelDOGE);
            Panel6.CustomizableEdges = customizableEdges19;
            Panel6.Location = new Point(18, 424);
            Panel6.Name = "Panel6";
            Panel6.ShadowDecoration.CustomizableEdges = customizableEdges20;
            Panel6.Size = new Size(740, 55);
            Panel6.TabIndex = 79;
            // 
            // guna2Button6
            // 
            guna2Button6.Cursor = Cursors.Hand;
            guna2Button6.CustomizableEdges = customizableEdges17;
            guna2Button6.DisabledState.BorderColor = Color.DarkGray;
            guna2Button6.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button6.FillColor = Color.Transparent;
            guna2Button6.Font = new Font("Segoe UI", 9F);
            guna2Button6.ForeColor = Color.White;
            guna2Button6.HoverState.FillColor = Color.Transparent;
            guna2Button6.HoverState.Image = (Image)resources.GetObject("resource.Image4");
            guna2Button6.Image = (Image)resources.GetObject("guna2Button6.Image");
            guna2Button6.ImageSize = new Size(80, 80);
            guna2Button6.Location = new Point(186, 6);
            guna2Button6.Name = "guna2Button6";
            guna2Button6.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2Button6.Size = new Size(40, 40);
            guna2Button6.TabIndex = 54;
            guna2Button6.Tag = "DOGE";
            guna2Button6.Click += AddToFavorite;
            // 
            // Panel5
            // 
            Panel5.Controls.Add(guna2Button5);
            Panel5.Controls.Add(labelXRPTicker);
            Panel5.Controls.Add(labelXRP);
            Panel5.Controls.Add(label8);
            Panel5.CustomizableEdges = customizableEdges23;
            Panel5.Location = new Point(18, 368);
            Panel5.Name = "Panel5";
            Panel5.ShadowDecoration.CustomizableEdges = customizableEdges24;
            Panel5.Size = new Size(740, 55);
            Panel5.TabIndex = 78;
            // 
            // guna2Button5
            // 
            guna2Button5.Cursor = Cursors.Hand;
            guna2Button5.CustomizableEdges = customizableEdges21;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = Color.Transparent;
            guna2Button5.Font = new Font("Segoe UI", 9F);
            guna2Button5.ForeColor = Color.White;
            guna2Button5.HoverState.FillColor = Color.Transparent;
            guna2Button5.HoverState.Image = (Image)resources.GetObject("resource.Image5");
            guna2Button5.Image = (Image)resources.GetObject("guna2Button5.Image");
            guna2Button5.ImageSize = new Size(80, 80);
            guna2Button5.Location = new Point(186, 6);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2Button5.Size = new Size(40, 40);
            guna2Button5.TabIndex = 51;
            guna2Button5.Tag = "XRP";
            guna2Button5.Click += AddToFavorite;
            // 
            // Panel4
            // 
            Panel4.Controls.Add(guna2Button4);
            Panel4.Controls.Add(labelSOLTicker);
            Panel4.Controls.Add(label5);
            Panel4.Controls.Add(labelSOL);
            Panel4.CustomizableEdges = customizableEdges27;
            Panel4.Location = new Point(18, 312);
            Panel4.Name = "Panel4";
            Panel4.ShadowDecoration.CustomizableEdges = customizableEdges28;
            Panel4.Size = new Size(740, 55);
            Panel4.TabIndex = 0;
            // 
            // guna2Button4
            // 
            guna2Button4.Cursor = Cursors.Hand;
            guna2Button4.CustomizableEdges = customizableEdges25;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.Transparent;
            guna2Button4.Font = new Font("Segoe UI", 9F);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.HoverState.FillColor = Color.Transparent;
            guna2Button4.HoverState.Image = (Image)resources.GetObject("resource.Image6");
            guna2Button4.Image = (Image)resources.GetObject("guna2Button4.Image");
            guna2Button4.ImageSize = new Size(80, 80);
            guna2Button4.Location = new Point(186, 6);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges26;
            guna2Button4.Size = new Size(40, 40);
            guna2Button4.TabIndex = 48;
            guna2Button4.Tag = "SOL";
            guna2Button4.Click += AddToFavorite;
            // 
            // Panel3
            // 
            Panel3.Controls.Add(guna2Button3);
            Panel3.Controls.Add(labelBNBTicker);
            Panel3.Controls.Add(labelBNB);
            Panel3.Controls.Add(label2);
            Panel3.CustomizableEdges = customizableEdges31;
            Panel3.Location = new Point(18, 256);
            Panel3.Name = "Panel3";
            Panel3.ShadowDecoration.CustomizableEdges = customizableEdges32;
            Panel3.Size = new Size(740, 55);
            Panel3.TabIndex = 42;
            // 
            // guna2Button3
            // 
            guna2Button3.Cursor = Cursors.Hand;
            guna2Button3.CustomizableEdges = customizableEdges29;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.Transparent;
            guna2Button3.Font = new Font("Segoe UI", 9F);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.HoverState.FillColor = Color.Transparent;
            guna2Button3.HoverState.Image = (Image)resources.GetObject("resource.Image7");
            guna2Button3.Image = (Image)resources.GetObject("guna2Button3.Image");
            guna2Button3.ImageSize = new Size(80, 80);
            guna2Button3.Location = new Point(186, 6);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges30;
            guna2Button3.Size = new Size(40, 40);
            guna2Button3.TabIndex = 45;
            guna2Button3.Tag = "BNB";
            guna2Button3.Click += AddToFavorite;
            // 
            // Panel2
            // 
            Panel2.Controls.Add(guna2Button2);
            Panel2.Controls.Add(labelETHTicker);
            Panel2.Controls.Add(labelETH);
            Panel2.Controls.Add(dollarSymbol2);
            Panel2.CustomizableEdges = customizableEdges35;
            Panel2.Location = new Point(18, 200);
            Panel2.Name = "Panel2";
            Panel2.ShadowDecoration.CustomizableEdges = customizableEdges36;
            Panel2.Size = new Size(740, 55);
            Panel2.TabIndex = 77;
            // 
            // guna2Button2
            // 
            guna2Button2.Cursor = Cursors.Hand;
            guna2Button2.CustomizableEdges = customizableEdges33;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.HoverState.FillColor = Color.Transparent;
            guna2Button2.HoverState.Image = (Image)resources.GetObject("resource.Image8");
            guna2Button2.Image = (Image)resources.GetObject("guna2Button2.Image");
            guna2Button2.ImageSize = new Size(80, 80);
            guna2Button2.Location = new Point(186, 6);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges34;
            guna2Button2.Size = new Size(40, 40);
            guna2Button2.TabIndex = 42;
            guna2Button2.Tag = "ETH";
            guna2Button2.Click += AddToFavorite;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(guna2Button1);
            Panel1.Controls.Add(labelBTCTicker);
            Panel1.Controls.Add(labelBTC);
            Panel1.Controls.Add(dollarSymbol);
            Panel1.CustomizableEdges = customizableEdges39;
            Panel1.Location = new Point(18, 144);
            Panel1.Name = "Panel1";
            Panel1.ShadowDecoration.CustomizableEdges = customizableEdges40;
            Panel1.Size = new Size(740, 55);
            Panel1.TabIndex = 76;
            // 
            // guna2Button1
            // 
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges37;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.FillColor = Color.Transparent;
            guna2Button1.HoverState.Image = (Image)resources.GetObject("resource.Image9");
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.ImageSize = new Size(80, 80);
            guna2Button1.Location = new Point(186, 6);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges38;
            guna2Button1.Size = new Size(40, 40);
            guna2Button1.TabIndex = 39;
            guna2Button1.Tag = "BTC";
            guna2Button1.Click += AddToFavorite;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(assetTicker);
            guna2Panel2.Controls.Add(priceLabel);
            guna2Panel2.Controls.Add(actionLabel);
            guna2Panel2.CustomizableEdges = customizableEdges41;
            guna2Panel2.Location = new Point(18, 83);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges42;
            guna2Panel2.Size = new Size(740, 55);
            guna2Panel2.TabIndex = 75;
            // 
            // favoriteLabel
            // 
            favoriteLabel.BackColor = Color.Transparent;
            favoriteLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            favoriteLabel.ForeColor = Color.White;
            favoriteLabel.Location = new Point(19, 13);
            favoriteLabel.Name = "favoriteLabel";
            favoriteLabel.Size = new Size(80, 27);
            favoriteLabel.TabIndex = 74;
            favoriteLabel.Text = "Favorites";
            // 
            // favoritesPanel
            // 
            favoritesPanel.BackColor = Color.Transparent;
            favoritesPanel.BorderRadius = 20;
            favoritesPanel.Controls.Add(outerPanel);
            favoritesPanel.Controls.Add(guna2Separator1);
            favoritesPanel.Controls.Add(favoriteLabel);
            favoritesPanel.CustomizableEdges = customizableEdges47;
            favoritesPanel.FillColor = Color.FromArgb(60, 63, 64);
            favoritesPanel.Location = new Point(815, 216);
            favoritesPanel.Name = "favoritesPanel";
            favoritesPanel.ShadowDecoration.CustomizableEdges = customizableEdges48;
            favoritesPanel.Size = new Size(322, 518);
            favoritesPanel.TabIndex = 73;
            favoritesPanel.Paint += transactionPanel_Paint;
            // 
            // outerPanel
            // 
            outerPanel.AutoScroll = true;
            outerPanel.CustomizableEdges = customizableEdges45;
            outerPanel.Location = new Point(18, 70);
            outerPanel.Name = "outerPanel";
            outerPanel.ShadowDecoration.CustomizableEdges = customizableEdges46;
            outerPanel.Size = new Size(287, 353);
            outerPanel.TabIndex = 77;
            // 
            // guna2Separator1
            // 
            guna2Separator1.BackColor = Color.Transparent;
            guna2Separator1.FillColor = Color.Black;
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(-5, 46);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(324, 10);
            guna2Separator1.TabIndex = 75;
            // 
            // walletPanel
            // 
            walletPanel.BackColor = Color.Transparent;
            walletPanel.BorderRadius = 20;
            walletPanel.Controls.Add(phpSIgn);
            walletPanel.Controls.Add(sellButton);
            walletPanel.Controls.Add(buyButton);
            walletPanel.Controls.Add(balance);
            walletPanel.Controls.Add(myBalanceLabel);
            walletPanel.Controls.Add(walletSeparator);
            walletPanel.CustomizableEdges = customizableEdges53;
            walletPanel.FillColor = Color.FromArgb(60, 63, 64);
            walletPanel.Location = new Point(815, 2);
            walletPanel.Name = "walletPanel";
            walletPanel.ShadowDecoration.CustomizableEdges = customizableEdges54;
            walletPanel.Size = new Size(319, 198);
            walletPanel.TabIndex = 72;
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
            // sellButton
            // 
            sellButton.BackColor = Color.Transparent;
            sellButton.BorderRadius = 15;
            sellButton.Cursor = Cursors.Hand;
            sellButton.CustomizableEdges = customizableEdges49;
            sellButton.DisabledState.BorderColor = Color.DarkGray;
            sellButton.DisabledState.CustomBorderColor = Color.DarkGray;
            sellButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            sellButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            sellButton.FillColor = Color.IndianRed;
            sellButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sellButton.ForeColor = Color.Black;
            sellButton.Location = new Point(166, 150);
            sellButton.Name = "sellButton";
            sellButton.ShadowDecoration.CustomizableEdges = customizableEdges50;
            sellButton.Size = new Size(137, 40);
            sellButton.TabIndex = 57;
            sellButton.Tag = "SELL";
            sellButton.Text = "Sell";
            sellButton.Click += sellButton_Click;
            // 
            // buyButton
            // 
            buyButton.BackColor = Color.Transparent;
            buyButton.BorderRadius = 15;
            buyButton.Cursor = Cursors.Hand;
            buyButton.CustomizableEdges = customizableEdges51;
            buyButton.DisabledState.BorderColor = Color.DarkGray;
            buyButton.DisabledState.CustomBorderColor = Color.DarkGray;
            buyButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buyButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buyButton.FillColor = Color.PaleGreen;
            buyButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buyButton.ForeColor = Color.Black;
            buyButton.Location = new Point(22, 149);
            buyButton.Name = "buyButton";
            buyButton.ShadowDecoration.CustomizableEdges = customizableEdges52;
            buyButton.Size = new Size(137, 40);
            buyButton.TabIndex = 56;
            buyButton.Tag = "BUY";
            buyButton.Text = "Buy";
            buyButton.Click += buyButton_Click;
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
            myBalanceLabel.ForeColor = Color.White;
            myBalanceLabel.Location = new Point(13, 13);
            myBalanceLabel.Name = "myBalanceLabel";
            myBalanceLabel.Size = new Size(111, 22);
            myBalanceLabel.TabIndex = 53;
            myBalanceLabel.Text = "My Portfolio";
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
            guna2Panel1.Controls.Add(favoritesPanel);
            guna2Panel1.Controls.Add(walletPanel);
            guna2Panel1.CustomizableEdges = customizableEdges55;
            guna2Panel1.Location = new Point(3, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges56;
            guna2Panel1.Size = new Size(1243, 795);
            guna2Panel1.TabIndex = 74;
            guna2Panel1.Paint += guna2Panel1_Paint;
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
            favoritesPanel.ResumeLayout(false);
            favoritesPanel.PerformLayout();
            walletPanel.ResumeLayout(false);
            walletPanel.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion



        private Guna.UI2.WinForms.Guna2Panel marketPanel;
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
        
        private Guna.UI2.WinForms.Guna2Panel favoritesPanel;
        private Guna.UI2.WinForms.Guna2Panel walletPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button sellButton;
        private Guna.UI2.WinForms.Guna2Button buyButton;
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
        private Guna2Separator guna2Separator1;
        private Guna2Button guna2Button1;
        private Guna2Button guna2Button10;
        private Guna2Button guna2Button9;
        private Guna2Button guna2Button8;
        private Guna2Button guna2Button7;
        private Guna2Button guna2Button6;
        private Guna2Button guna2Button5;
        private Guna2Button guna2Button4;
        private Guna2Button guna2Button3;
        private Guna2Button guna2Button2;
        private Guna2Panel outerPanel;
    }
}
