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
using WebSocketStreamingWithUI.TestWebSocket;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace WebSocketStreamingWithUI.UserControls
{
    public partial class UC_Buy : UserControl
    {

        private Dictionary<string, Guna2HtmlLabel> priceLabels = new();

        private string currentSelectedPair = null;
        WebSocketPriceClient ws;
        public UC_Buy()
        {
            InitializeComponent();
            this.Load += UC_Buy_Load;
            

        }

        public async void UC_Buy_Load(object sender, EventArgs e)
        {
            ws = new WebSocketPriceClient();
            ws.OnPriceUpdate += WsClient_OnPriceUpdate;
            await ws.ConnectAsync();
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
             
           
                    if (pairSymbol != currentSelectedPair) return;

                    float prevPrice = float.TryParse(priceChanges.Text, out float val) ? val : 0;

                    priceChanges.ForeColor = newPrice > prevPrice ? Color.Green :
                                           newPrice < prevPrice ? Color.Red : priceChanges.ForeColor;

                    priceChanges.Text = newPrice.ToString("N2");




                    //float a = float.Parse(priceOfFromCurrency.Text);
                    //if (amountLabel.Text == "")
                    //{

                    //    return;
                    //}
                    //float b = float.Parse(amountLabel.Text);

                    //float calculated = a * b;
                    //float converted = calculated / float.Parse(priceOfToCurrency.Text);
                    //amountTo.Text = converted.ToString();
                




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }

        }

        private void walletLabel_Click(object sender, EventArgs e)
        {

        }



        private void buy_Click(object sender, EventArgs e)
        {
            separator1.FillColor = Color.White;
            separator2.FillColor = Color.Black;
            buy.ForeColor = Color.White;
            sell.ForeColor = Color.DarkGray;
        }

        private void sell_Click(object sender, EventArgs e)
        {


            sell.ForeColor = Color.White;
            buy.ForeColor = Color.DarkGray;

            separator1.FillColor = Color.Black;
            separator2.FillColor = Color.White;

        }

        private void exchangePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void currencyLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectOption_Click(object sender, EventArgs e)
        {

        }
        private void ChangePlaceHolderFrom(Guna2HtmlLabel targetPrice, string currency)
        {
            priceLabels[currency] = targetPrice;
            targetPrice.Visible = true;

        }

        
        private void dropDownBuy_SelectedIndexChanged(object sender, EventArgs e)
        {

           

            selectOption.Visible = false;
            int selectedIndex = dropDownBuy.SelectedIndex;

            if (selectedIndex < 0 || selectedIndex >= dropDownBuy.Items.Count) return;

             currentSelectedPair = dropDownBuy.Items[selectedIndex].ToString();

           

            ChangePlaceHolderFrom(priceChanges, currentSelectedPair);
        }
    }
}
