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
using WebSocketStreamingWithUI.Data;
namespace WebSocketStreamingWithUI.UserControls
{
    public partial class UC_Buy : UserControl
    {
        User newUser = new User();
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


                if (amountLabel.Text == "")
                {
                    currencyEquiv.Text = "0";
                    return;

                }

                float calculated = (float.Parse(amountLabel.Text) * float.Parse(priceChanges.Text));

                currencyEquiv.Text = calculated.ToString("N");
                currencyEquiv.Visible = true;
              
                float epsilon = 0.00001f;

                if (float.Parse(currencyEquiv.Text.ToString()) < epsilon || currencyEquiv.Text.ToString() == "")
                {
                    actionButton.Text = "Enter an Amount";
                    actionButton.FillColor = Color.IndianRed;
                }
                else
                {
                    if (newUser.CheckUserBalance(currencyEquiv.Text.ToString()))
                    {
                        actionButton.Text = "Confirm";
                        actionButton.FillColor = Color.MediumSpringGreen;
                    }
                    else
                    {
                        actionButton.Text = "Your Balance is Less";
                        actionButton.FillColor = Color.IndianRed;
                    }
                }







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

            actionButton.FillColor = Color.MediumSpringGreen;
        }

        private void sell_Click(object sender, EventArgs e)
        {


            sell.ForeColor = Color.White;
            buy.ForeColor = Color.DarkGray;

            separator1.FillColor = Color.Black;
            separator2.FillColor = Color.White;


            actionButton.FillColor = Color.IndianRed;

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

        private void amountLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            if (newUser.CheckHoldings(currentSelectedPair))
            {
                newUser.UpdateHoldings(currentSelectedPair, float.Parse(amountLabel.Text), "+");
            }else
            {
                newUser.InsertToHoldings(currentSelectedPair, float.Parse(amountLabel.Text));
            }
           
        }

        private void amountLabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as Guna.UI2.WinForms.Guna2TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
