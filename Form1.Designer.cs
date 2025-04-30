namespace WebSocketStreamingWithUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            printDialog1 = new PrintDialog();
            printDialog2 = new PrintDialog();
            label1 = new Label();
            labelBTC = new Label();
            labelBTCTicker = new Label();
            dollarSymbol = new Label();
            labelETHTicker = new Label();
            labelETH = new Label();
            dollarSymbol2 = new Label();
            labelBNB = new Label();
            labelBNBTicker = new Label();
            label2 = new Label();
            labelSOL = new Label();
            labelSOLTicker = new Label();
            label5 = new Label();
            labelXRP = new Label();
            labelXRPTicker = new Label();
            label8 = new Label();
            labelDOGE = new Label();
            labelDOGETicker = new Label();
            label11 = new Label();
            labelADA = new Label();
            labelADATicker = new Label();
            label14 = new Label();
            labelAVAX = new Label();
            labelAVAXTicker = new Label();
            label17 = new Label();
            labelBCH = new Label();
            labelBCHTicker = new Label();
            label20 = new Label();
            labelDOT = new Label();
            labelDOTTicker = new Label();
            label23 = new Label();
            assetTicker = new Label();
            marketRatePanel = new Panel();
            actionBtn = new Button();
            actionLabel = new Label();
            marketCap = new Label();
            priceLabel = new Label();
            marketRatePanel.SuspendLayout();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDialog2
            // 
            printDialog2.UseEXDialog = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 13.2000008F);
            label1.Location = new Point(90, 111);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 4;
            // 
            // labelBTC
            // 
            labelBTC.AutoSize = true;
            labelBTC.BackColor = SystemColors.GradientActiveCaption;
            labelBTC.FlatStyle = FlatStyle.Popup;
            labelBTC.Font = new Font("Segoe UI", 13F);
            labelBTC.Location = new Point(204, 66);
            labelBTC.Name = "labelBTC";
            labelBTC.Size = new Size(25, 30);
            labelBTC.TabIndex = 0;
            labelBTC.Text = "0";
            labelBTC.Click += labelBTC_Click;
            // 
            // labelBTCTicker
            // 
            labelBTCTicker.AutoSize = true;
            labelBTCTicker.BackColor = SystemColors.GradientActiveCaption;
            labelBTCTicker.FlatStyle = FlatStyle.Popup;
            labelBTCTicker.Font = new Font("Segoe UI", 13.2000008F);
            labelBTCTicker.Location = new Point(28, 65);
            labelBTCTicker.Margin = new Padding(0);
            labelBTCTicker.Name = "labelBTCTicker";
            labelBTCTicker.Size = new Size(85, 31);
            labelBTCTicker.TabIndex = 2;
            labelBTCTicker.Text = "TICKER";
            // 
            // dollarSymbol
            // 
            dollarSymbol.AutoSize = true;
            dollarSymbol.BackColor = SystemColors.GradientActiveCaption;
            dollarSymbol.FlatStyle = FlatStyle.Popup;
            dollarSymbol.Font = new Font("Segoe UI", 13F);
            dollarSymbol.Location = new Point(176, 66);
            dollarSymbol.Name = "dollarSymbol";
            dollarSymbol.Size = new Size(25, 30);
            dollarSymbol.TabIndex = 3;
            dollarSymbol.Text = "$";
            // 
            // labelETHTicker
            // 
            labelETHTicker.AutoSize = true;
            labelETHTicker.BackColor = SystemColors.GradientActiveCaption;
            labelETHTicker.FlatStyle = FlatStyle.Popup;
            labelETHTicker.Font = new Font("Segoe UI", 13.2000008F);
            labelETHTicker.Location = new Point(28, 103);
            labelETHTicker.Name = "labelETHTicker";
            labelETHTicker.Size = new Size(85, 31);
            labelETHTicker.TabIndex = 5;
            labelETHTicker.Text = "TICKER";
            // 
            // labelETH
            // 
            labelETH.AutoSize = true;
            labelETH.BackColor = SystemColors.GradientActiveCaption;
            labelETH.FlatStyle = FlatStyle.Popup;
            labelETH.Font = new Font("Segoe UI", 13F);
            labelETH.Location = new Point(204, 104);
            labelETH.Name = "labelETH";
            labelETH.Size = new Size(25, 30);
            labelETH.TabIndex = 6;
            labelETH.Text = "0";
            // 
            // dollarSymbol2
            // 
            dollarSymbol2.AutoSize = true;
            dollarSymbol2.BackColor = SystemColors.GradientActiveCaption;
            dollarSymbol2.FlatStyle = FlatStyle.Popup;
            dollarSymbol2.Font = new Font("Segoe UI", 13F);
            dollarSymbol2.Location = new Point(176, 104);
            dollarSymbol2.Name = "dollarSymbol2";
            dollarSymbol2.Size = new Size(25, 30);
            dollarSymbol2.TabIndex = 7;
            dollarSymbol2.Text = "$";
            // 
            // labelBNB
            // 
            labelBNB.AutoSize = true;
            labelBNB.BackColor = SystemColors.GradientActiveCaption;
            labelBNB.FlatStyle = FlatStyle.Popup;
            labelBNB.Font = new Font("Segoe UI", 13F);
            labelBNB.Location = new Point(204, 141);
            labelBNB.Name = "labelBNB";
            labelBNB.Size = new Size(25, 30);
            labelBNB.TabIndex = 8;
            labelBNB.Text = "0";
            // 
            // labelBNBTicker
            // 
            labelBNBTicker.AutoSize = true;
            labelBNBTicker.BackColor = SystemColors.GradientActiveCaption;
            labelBNBTicker.FlatStyle = FlatStyle.Popup;
            labelBNBTicker.Font = new Font("Segoe UI", 13.2000008F);
            labelBNBTicker.Location = new Point(28, 140);
            labelBNBTicker.Name = "labelBNBTicker";
            labelBNBTicker.Size = new Size(85, 31);
            labelBNBTicker.TabIndex = 9;
            labelBNBTicker.Text = "TICKER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(176, 141);
            label2.Name = "label2";
            label2.Size = new Size(25, 30);
            label2.TabIndex = 10;
            label2.Text = "$";
            // 
            // labelSOL
            // 
            labelSOL.AutoSize = true;
            labelSOL.BackColor = SystemColors.GradientActiveCaption;
            labelSOL.FlatStyle = FlatStyle.Popup;
            labelSOL.Font = new Font("Segoe UI", 13F);
            labelSOL.Location = new Point(204, 179);
            labelSOL.Name = "labelSOL";
            labelSOL.Size = new Size(25, 30);
            labelSOL.TabIndex = 11;
            labelSOL.Text = "0";
            // 
            // labelSOLTicker
            // 
            labelSOLTicker.AutoSize = true;
            labelSOLTicker.BackColor = SystemColors.GradientActiveCaption;
            labelSOLTicker.Enabled = false;
            labelSOLTicker.FlatStyle = FlatStyle.Popup;
            labelSOLTicker.Font = new Font("Segoe UI", 13.2000008F);
            labelSOLTicker.Location = new Point(28, 178);
            labelSOLTicker.Name = "labelSOLTicker";
            labelSOLTicker.Size = new Size(85, 31);
            labelSOLTicker.TabIndex = 12;
            labelSOLTicker.Text = "TICKER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(176, 179);
            label5.Name = "label5";
            label5.Size = new Size(25, 30);
            label5.TabIndex = 13;
            label5.Text = "$";
            // 
            // labelXRP
            // 
            labelXRP.AutoSize = true;
            labelXRP.BackColor = SystemColors.GradientActiveCaption;
            labelXRP.FlatStyle = FlatStyle.Popup;
            labelXRP.Font = new Font("Segoe UI", 13F);
            labelXRP.Location = new Point(204, 216);
            labelXRP.Name = "labelXRP";
            labelXRP.Size = new Size(25, 30);
            labelXRP.TabIndex = 14;
            labelXRP.Text = "0";
            // 
            // labelXRPTicker
            // 
            labelXRPTicker.AutoSize = true;
            labelXRPTicker.BackColor = SystemColors.GradientActiveCaption;
            labelXRPTicker.FlatStyle = FlatStyle.Popup;
            labelXRPTicker.Font = new Font("Segoe UI", 13.2000008F);
            labelXRPTicker.Location = new Point(28, 215);
            labelXRPTicker.Name = "labelXRPTicker";
            labelXRPTicker.Size = new Size(85, 31);
            labelXRPTicker.TabIndex = 15;
            labelXRPTicker.Text = "TICKER";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientActiveCaption;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Segoe UI", 13F);
            label8.Location = new Point(176, 216);
            label8.Name = "label8";
            label8.Size = new Size(25, 30);
            label8.TabIndex = 16;
            label8.Text = "$";
            // 
            // labelDOGE
            // 
            labelDOGE.AutoSize = true;
            labelDOGE.BackColor = SystemColors.GradientActiveCaption;
            labelDOGE.FlatStyle = FlatStyle.Popup;
            labelDOGE.Font = new Font("Segoe UI", 13F);
            labelDOGE.Location = new Point(204, 254);
            labelDOGE.Name = "labelDOGE";
            labelDOGE.Size = new Size(25, 30);
            labelDOGE.TabIndex = 17;
            labelDOGE.Text = "0";
            // 
            // labelDOGETicker
            // 
            labelDOGETicker.AutoSize = true;
            labelDOGETicker.BackColor = SystemColors.GradientActiveCaption;
            labelDOGETicker.FlatStyle = FlatStyle.Popup;
            labelDOGETicker.Font = new Font("Segoe UI", 13.2000008F);
            labelDOGETicker.Location = new Point(30, 253);
            labelDOGETicker.Name = "labelDOGETicker";
            labelDOGETicker.Size = new Size(85, 31);
            labelDOGETicker.TabIndex = 18;
            labelDOGETicker.Text = "TICKER";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.GradientActiveCaption;
            label11.FlatStyle = FlatStyle.Popup;
            label11.Font = new Font("Segoe UI", 13F);
            label11.Location = new Point(176, 254);
            label11.Name = "label11";
            label11.Size = new Size(25, 30);
            label11.TabIndex = 19;
            label11.Text = "$";
            // 
            // labelADA
            // 
            labelADA.AutoSize = true;
            labelADA.BackColor = SystemColors.GradientActiveCaption;
            labelADA.FlatStyle = FlatStyle.Popup;
            labelADA.Font = new Font("Segoe UI", 13F);
            labelADA.Location = new Point(204, 291);
            labelADA.Name = "labelADA";
            labelADA.Size = new Size(25, 30);
            labelADA.TabIndex = 20;
            labelADA.Text = "0";
            // 
            // labelADATicker
            // 
            labelADATicker.AutoSize = true;
            labelADATicker.BackColor = SystemColors.GradientActiveCaption;
            labelADATicker.FlatStyle = FlatStyle.Popup;
            labelADATicker.Font = new Font("Segoe UI", 13.2000008F);
            labelADATicker.Location = new Point(28, 290);
            labelADATicker.Name = "labelADATicker";
            labelADATicker.Size = new Size(85, 31);
            labelADATicker.TabIndex = 21;
            labelADATicker.Text = "TICKER";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.GradientActiveCaption;
            label14.FlatStyle = FlatStyle.Popup;
            label14.Font = new Font("Segoe UI", 13F);
            label14.Location = new Point(176, 291);
            label14.Name = "label14";
            label14.Size = new Size(25, 30);
            label14.TabIndex = 22;
            label14.Text = "$";
            // 
            // labelAVAX
            // 
            labelAVAX.AutoSize = true;
            labelAVAX.BackColor = SystemColors.GradientActiveCaption;
            labelAVAX.FlatStyle = FlatStyle.Popup;
            labelAVAX.Font = new Font("Segoe UI", 13F);
            labelAVAX.Location = new Point(204, 329);
            labelAVAX.Name = "labelAVAX";
            labelAVAX.Size = new Size(25, 30);
            labelAVAX.TabIndex = 23;
            labelAVAX.Text = "0";
            // 
            // labelAVAXTicker
            // 
            labelAVAXTicker.AutoSize = true;
            labelAVAXTicker.BackColor = SystemColors.GradientActiveCaption;
            labelAVAXTicker.FlatStyle = FlatStyle.Popup;
            labelAVAXTicker.Font = new Font("Segoe UI", 13.2000008F);
            labelAVAXTicker.Location = new Point(28, 328);
            labelAVAXTicker.Name = "labelAVAXTicker";
            labelAVAXTicker.Size = new Size(85, 31);
            labelAVAXTicker.TabIndex = 24;
            labelAVAXTicker.Text = "TICKER";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.GradientActiveCaption;
            label17.FlatStyle = FlatStyle.Popup;
            label17.Font = new Font("Segoe UI", 13F);
            label17.Location = new Point(176, 329);
            label17.Name = "label17";
            label17.Size = new Size(25, 30);
            label17.TabIndex = 25;
            label17.Text = "$";
            // 
            // labelBCH
            // 
            labelBCH.AutoSize = true;
            labelBCH.BackColor = SystemColors.GradientActiveCaption;
            labelBCH.FlatStyle = FlatStyle.Popup;
            labelBCH.Font = new Font("Segoe UI", 13F);
            labelBCH.Location = new Point(204, 367);
            labelBCH.Name = "labelBCH";
            labelBCH.Size = new Size(25, 30);
            labelBCH.TabIndex = 26;
            labelBCH.Text = "0";
            // 
            // labelBCHTicker
            // 
            labelBCHTicker.AutoSize = true;
            labelBCHTicker.BackColor = SystemColors.GradientActiveCaption;
            labelBCHTicker.FlatStyle = FlatStyle.Popup;
            labelBCHTicker.Font = new Font("Segoe UI", 13.2000008F);
            labelBCHTicker.Location = new Point(30, 366);
            labelBCHTicker.Name = "labelBCHTicker";
            labelBCHTicker.Size = new Size(85, 31);
            labelBCHTicker.TabIndex = 27;
            labelBCHTicker.Text = "TICKER";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = SystemColors.GradientActiveCaption;
            label20.FlatStyle = FlatStyle.Popup;
            label20.Font = new Font("Segoe UI", 13F);
            label20.Location = new Point(176, 367);
            label20.Name = "label20";
            label20.Size = new Size(25, 30);
            label20.TabIndex = 28;
            label20.Text = "$";
            // 
            // labelDOT
            // 
            labelDOT.AutoSize = true;
            labelDOT.BackColor = SystemColors.GradientActiveCaption;
            labelDOT.FlatStyle = FlatStyle.Popup;
            labelDOT.Font = new Font("Segoe UI", 13F);
            labelDOT.Location = new Point(204, 405);
            labelDOT.Name = "labelDOT";
            labelDOT.Size = new Size(25, 30);
            labelDOT.TabIndex = 29;
            labelDOT.Text = "0";
            // 
            // labelDOTTicker
            // 
            labelDOTTicker.AutoSize = true;
            labelDOTTicker.BackColor = SystemColors.GradientActiveCaption;
            labelDOTTicker.FlatStyle = FlatStyle.Popup;
            labelDOTTicker.Font = new Font("Segoe UI", 13.2000008F);
            labelDOTTicker.Location = new Point(30, 404);
            labelDOTTicker.Name = "labelDOTTicker";
            labelDOTTicker.Size = new Size(85, 31);
            labelDOTTicker.TabIndex = 30;
            labelDOTTicker.Text = "TICKER";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = SystemColors.GradientActiveCaption;
            label23.FlatStyle = FlatStyle.Popup;
            label23.Font = new Font("Segoe UI", 13F);
            label23.Location = new Point(176, 405);
            label23.Name = "label23";
            label23.Size = new Size(25, 30);
            label23.TabIndex = 31;
            label23.Text = "$";
            // 
            // assetTicker
            // 
            assetTicker.AutoSize = true;
            assetTicker.BackColor = SystemColors.ButtonFace;
            assetTicker.FlatStyle = FlatStyle.Popup;
            assetTicker.Font = new Font("Segoe UI", 13.2000008F);
            assetTicker.Location = new Point(34, 25);
            assetTicker.Margin = new Padding(0);
            assetTicker.Name = "assetTicker";
            assetTicker.Size = new Size(69, 31);
            assetTicker.TabIndex = 32;
            assetTicker.Text = "Asset";
            // 
            // marketRatePanel
            // 
            marketRatePanel.BackColor = SystemColors.GradientActiveCaption;
            marketRatePanel.Controls.Add(actionBtn);
            marketRatePanel.Controls.Add(actionLabel);
            marketRatePanel.Controls.Add(marketCap);
            marketRatePanel.Controls.Add(priceLabel);
            marketRatePanel.Controls.Add(assetTicker);
            marketRatePanel.Controls.Add(label23);
            marketRatePanel.Controls.Add(labelDOTTicker);
            marketRatePanel.Controls.Add(labelDOT);
            marketRatePanel.Controls.Add(label20);
            marketRatePanel.Controls.Add(labelBCHTicker);
            marketRatePanel.Controls.Add(labelBCH);
            marketRatePanel.Controls.Add(label17);
            marketRatePanel.Controls.Add(labelAVAXTicker);
            marketRatePanel.Controls.Add(labelAVAX);
            marketRatePanel.Controls.Add(label14);
            marketRatePanel.Controls.Add(labelADATicker);
            marketRatePanel.Controls.Add(labelADA);
            marketRatePanel.Controls.Add(label11);
            marketRatePanel.Controls.Add(labelDOGETicker);
            marketRatePanel.Controls.Add(labelDOGE);
            marketRatePanel.Controls.Add(label8);
            marketRatePanel.Controls.Add(labelXRPTicker);
            marketRatePanel.Controls.Add(labelXRP);
            marketRatePanel.Controls.Add(label5);
            marketRatePanel.Controls.Add(labelSOLTicker);
            marketRatePanel.Controls.Add(labelSOL);
            marketRatePanel.Controls.Add(label2);
            marketRatePanel.Controls.Add(labelBNBTicker);
            marketRatePanel.Controls.Add(labelBNB);
            marketRatePanel.Controls.Add(dollarSymbol2);
            marketRatePanel.Controls.Add(labelETH);
            marketRatePanel.Controls.Add(labelETHTicker);
            marketRatePanel.Controls.Add(dollarSymbol);
            marketRatePanel.Controls.Add(labelBTCTicker);
            marketRatePanel.Controls.Add(labelBTC);
            marketRatePanel.Location = new Point(118, 149);
            marketRatePanel.Name = "marketRatePanel";
            marketRatePanel.Size = new Size(669, 458);
            marketRatePanel.TabIndex = 33;
            // 
            // actionBtn
            // 
            actionBtn.BackColor = Color.CornflowerBlue;
            actionBtn.Cursor = Cursors.Hand;
            actionBtn.FlatAppearance.BorderSize = 0;
            actionBtn.FlatStyle = FlatStyle.Flat;
            actionBtn.ForeColor = SystemColors.Control;
            actionBtn.Location = new Point(516, 68);
            actionBtn.Name = "actionBtn";
            actionBtn.Size = new Size(69, 30);
            actionBtn.TabIndex = 36;
            actionBtn.Text = "Trade";
            actionBtn.UseVisualStyleBackColor = false;
            actionBtn.Click += Button_Click;
            // 
            // actionLabel
            // 
            actionLabel.AutoSize = true;
            actionLabel.BackColor = SystemColors.ButtonFace;
            actionLabel.FlatStyle = FlatStyle.Popup;
            actionLabel.Font = new Font("Segoe UI", 13.2000008F);
            actionLabel.Location = new Point(512, 25);
            actionLabel.Margin = new Padding(0);
            actionLabel.Name = "actionLabel";
            actionLabel.Size = new Size(80, 31);
            actionLabel.TabIndex = 35;
            actionLabel.Text = "Action";
            // 
            // marketCap
            // 
            marketCap.AutoSize = true;
            marketCap.BackColor = SystemColors.ButtonFace;
            marketCap.FlatStyle = FlatStyle.Popup;
            marketCap.Font = new Font("Segoe UI", 13.2000008F);
            marketCap.Location = new Point(341, 25);
            marketCap.Margin = new Padding(0);
            marketCap.Name = "marketCap";
            marketCap.Size = new Size(132, 31);
            marketCap.TabIndex = 34;
            marketCap.Text = "Market Cap";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = SystemColors.ButtonFace;
            priceLabel.FlatStyle = FlatStyle.Popup;
            priceLabel.Font = new Font("Segoe UI", 13.2000008F);
            priceLabel.Location = new Point(174, 25);
            priceLabel.Margin = new Padding(0);
            priceLabel.Name = "priceLabel";
            priceLabel.Padding = new Padding(20, 0, 0, 0);
            priceLabel.RightToLeft = RightToLeft.No;
            priceLabel.Size = new Size(84, 31);
            priceLabel.TabIndex = 33;
            priceLabel.Text = "Price";
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 646);
            Controls.Add(marketRatePanel);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            marketRatePanel.ResumeLayout(false);
            marketRatePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PrintDialog printDialog1;
        private PrintDialog printDialog2;


        private Label label1;
        public Label labelBTC;
        public Label labelBTCTicker;
        public Label dollarSymbol;
        public Label labelETHTicker;
        public Label labelETH;
        public Label dollarSymbol2;
        public Label labelBNB;
        public Label labelBNBTicker;
        public Label label2;
        public Label labelSOL;
        public Label labelSOLTicker;
        public Label label5;
        public Label labelXRP;
        public Label labelXRPTicker;
        public Label label8;
        public Label labelDOGE;
        public Label labelDOGETicker;
        public Label label11;
        public Label labelADA;
        public Label labelADATicker;
        public Label label14;
        public Label labelAVAX;
        public Label labelAVAXTicker;
        public Label label17;
        public Label labelBCH;
        public Label labelBCHTicker;
        public Label label20;
        public Label labelDOT;
        public Label labelDOTTicker;
        public Label label23;
        public Label assetTicker;
       
        public Label marketCap;
     
        public Label priceLabel;
        private Button actionBtn;
        public Label actionLabel;
        private Panel marketRatePanel;

        //Generate Series of Buttons
        private void CreateActionButtons()
        {
           
        int j = 33;
            for (int i = 0; i < 10; i++)
            {
                actionBtn = new Button(); // Reuse the same variable each time
                actionBtn.Name = "actionBtn" + i;
                actionBtn.Text = "Trade";
                actionBtn.Size = new Size(69, 30);
                actionBtn.Location = new Point(516, j + 68);
                actionBtn.Click += Button_Click;
                actionBtn.FlatStyle = FlatStyle.Flat;
                actionBtn.FlatAppearance.BorderSize = 0;
                actionBtn.ForeColor = Color.White;
                actionBtn.FlatAppearance.BorderColor = Color.CornflowerBlue;
                actionBtn.BackColor = Color.CornflowerBlue;
                actionBtn.Cursor = Cursors.Hand;
                marketRatePanel.Controls.Add(actionBtn);
                j += 33;
            }
        }

        private Button button1;
    }
}
