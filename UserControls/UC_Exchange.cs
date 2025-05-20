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
        private string selectedFromPair = null;
        private string selectedToPair = null;

        private Dictionary<string, Label> priceLabels = new();
        

        private WebSocketPriceClient wsClient;

        public UC_Exchange()
        {
            InitializeComponent();

            this.Load += UC_Exchange_Load;
        }
        public async void UC_Exchange_Load(object sender, EventArgs e)
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
            try
            {
                

                if (pairSymbol == selectedFromPair)
                {
                    float prev = float.TryParse(priceOfFromCurrency.Text, out float val) ? val : 0;
                    priceOfFromCurrency.ForeColor = newPrice > prev ? Color.Green :
                                               newPrice < prev ? Color.Red : priceOfFromCurrency.ForeColor;
                    priceOfFromCurrency.Text = newPrice.ToString("N2");
                }

                if (pairSymbol == selectedToPair)
                {
                    float prev = float.TryParse(priceOfToCurrency.Text, out float val) ? val : 0;
                    priceOfToCurrency.ForeColor = newPrice > prev ? Color.Green :
                                             newPrice < prev ? Color.Red : priceOfToCurrency.ForeColor;
                    priceOfToCurrency.Text = newPrice.ToString("N2");
                }

                if (amountLabel.Text == "")
                {
                    return;
                }


                float a = float.Parse(priceOfFromCurrency.Text);
                float b = float.Parse(amountLabel.Text);

                float calculated = a * b;
                float converted = calculated / float.Parse(priceOfToCurrency.Text);
                amountTo.Text = converted.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }

        }

        public void ChangePlaceHolder(string currency)
        {
            selectedFromPair = currency;
            ChangePlaceHolderFrom(priceOfFromCurrency, selectedFromPair);
            //priceOfFromCurrency.Text = livePrice.ToString();
            dropDownFrom.Text = currency;
            SelectedLabelFrom.Visible = false;
            dropDownTo.Text = "Select Option";
            priceOfFromCurrency.Visible = true;
        }

        private void ChangePlaceHolderFrom(Label targetPrice, string currency)
        {
          
            priceLabels[currency] = targetPrice;
            targetPrice.Visible = true;

        }
        private void ChangePlaceHolderTo(Label targetPrice, string currency)
        {
            priceLabels[currency] = targetPrice;
            targetPrice.Visible = true;

        }
        
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedLabelFrom.Visible = false;
            int selectedIndex = dropDownFrom.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= dropDownFrom.Items.Count) return;

            selectedFromPair = dropDownFrom.Items[selectedIndex].ToString();
            ChangePlaceHolderTo(priceOfFromCurrency, selectedFromPair);

        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedLabelTo.Visible = false;
            int selectedIndex = dropDownTo.SelectedIndex;
            selectedToPair = dropDownTo.Items[selectedIndex].ToString();
            ChangePlaceHolderFrom(priceOfToCurrency, selectedToPair);

        }
    }
}
