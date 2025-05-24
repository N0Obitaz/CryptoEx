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
    public partial class UC_Buy : UserControl, IDisposable
    {
        User newUser = new User();
        private Dictionary<string, Guna2HtmlLabel> priceLabels = new();
        public float amountToPass = 0;
        private string currentSelectedPair = null;
        WebSocketPriceClient ws;
        HttpClientPHP _phpClient = new HttpClientPHP();

        private string operation;
        public UC_Buy()
        {
            InitializeComponent();
            this.Load += UC_Buy_Load;


        }
        

        public async void UC_Buy_Load(object sender, EventArgs e)
        {
            ws = new WebSocketPriceClient();
            ws.OnPriceUpdate += WsClient_OnPriceUpdate;
            //await _phpClient.GetPHPRate();
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
                amountToPass = calculated;
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


        public void AssignOperator(string ope)
        {
            if (ope == "SELL")
            {
                operation = "-" + ope;
                return;
            }
            operation = "+" + ope;
            

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

            if (newUser.CheckHoldings(selectedIndex.ToString()))
            {
                MessageBox.Show("true");
            }
            currentSelectedPair = dropDownBuy.Items[selectedIndex].ToString();



            ChangePlaceHolderFrom(priceChanges, currentSelectedPair);
        }

        
        private void SellAction(string pair, float amount, string oper2)
        {
            if (oper2 == "-SELL")
            {
                oper2 = "+SELL";
            }
            if (newUser.CheckHoldings(pair))
            {
                newUser.UpdateHoldings(pair, amount, oper2);
                newUser.UpdateBalance(amountToPass, oper2, pair);
            }
        }
        private void actionButton_Click(object sender, EventArgs e)
        {
            if (operation == "-SELL")
            {
                SellAction(currentSelectedPair, float.Parse(amountLabel.Text), operation);
                return;
            }
            if (newUser.CheckHoldings(currentSelectedPair))
            {
                MessageBox.Show(operation);
                newUser.UpdateHoldings(currentSelectedPair, float.Parse(amountLabel.Text), operation);
                
                newUser.UpdateBalance(amountToPass, operation, currentSelectedPair);
            }else
            {
                newUser.InsertToHoldings(currentSelectedPair, float.Parse(amountLabel.Text), operation);
                newUser.UpdateBalance(amountToPass, $"-{operation}", currentSelectedPair);


            }
            operation = "";
           
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
        private void amountLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
