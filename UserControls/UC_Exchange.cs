using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Org.BouncyCastle.Utilities;
using WebSocketStreamingWithUI.TestWebSocket;

namespace WebSocketStreamingWithUI.UserControls
{
    public partial class UC_Exchange : UserControl
    {

        private Dictionary<string, Label> priceLabels = new();

        private WebSocketPriceClient wsClient;

        public UC_Exchange()
        {
            InitializeComponent();

            this.Load += UC_Exchange_Load;
        }
        private async void UC_Exchange_Load(object sender, EventArgs e)
        {
            wsClient = new WebSocketPriceClient();
            wsClient.OnPriceUpdate += WsClient_OnPriceUpdate;
            await wsClient.ConnectAsync();
        }

        private void WsClient_OnPriceUpdate(string pair, float price)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdatePrice(pair, price)));
            }
            else
            {
                UpdatePrice(pair, price);
            }
        }

        private void UpdatePrice(string pairSymbol, float newPrice)
        {

            if (!priceLabels.ContainsKey(pairSymbol)) return;

            Label priceLabel = priceLabels[pairSymbol];
            float prevPrice = float.TryParse(priceLabel.Text, out float val) ? val : 0;

            priceLabel.ForeColor = newPrice > prevPrice ? Color.Green :
                                   newPrice < prevPrice ? Color.Red : priceLabel.ForeColor;

            priceLabel.Text = newPrice.ToString("N2");
            //priceOfToCurrency.Text = newPrice.ToString("N2");
        }

        public void ChangePlaceHolder(string currency)
        {
            priceLabels[currency] = priceOfFromCurrency;
            //priceOfFromCurrency.Text = livePrice.ToString();
            selectOptionFrom.Text = currency;
            priceOfFromCurrency.Visible = true;
        }
        private void ChangePlaceHolderTo(Guna2Button targetButton, Label targetPrice, string currency)
        {
            priceLabels[currency] = targetPrice;
            targetButton.Text = currency;
            targetPrice.Visible = true;

        }



        private enum CurrencySelectionTarget { None, From, To }
        private CurrencySelectionTarget currentSelection = CurrencySelectionTarget.None;

        private void AddOverLayPanel()
        {

            this.Controls.Add(overlayPanel);
            overlayPanel.Visible = true;
            CreateButtons();
            convertPanel.Controls.Add(overlayPanel);
            overlayPanel.BringToFront();

        }
        private void selectOption_Click(object sender, EventArgs e)
        {
            currentSelection = CurrencySelectionTarget.From;
            AddOverLayPanel();

        }

        //Close overLayPanel

        private void closeButton_Click(object sender, EventArgs e)
        {
            convertPanel.Controls.Remove(overlayPanel);
            
        }

       
        private void selectOptionTo_Click(object sender, EventArgs e)
        {
            currentSelection = CurrencySelectionTarget.To;
            AddOverLayPanel();
        }
        private void currencyBtn_Click(object sender, EventArgs e)
        {
            
            if (sender is Button btn && btn.Tag is string currency)
            {

                switch (currentSelection)
                {
                case CurrencySelectionTarget.From:
                    ChangePlaceHolderTo(selectOptionFrom, priceOfFromCurrency, currency);
                        convertPanel.Controls.Remove(overlayPanel);
                    break;
                case CurrencySelectionTarget.To:
                    ChangePlaceHolderTo(selectOptionTo, priceOfToCurrency, currency);
                        convertPanel.Controls.Remove(overlayPanel);
                        break;
                }
            }

            //MessageBox.Show($"Failed to parse price for {currency}");


            this.Controls.Remove(overlayPanel);
            currentSelection = CurrencySelectionTarget.None;
        }
    }
}
