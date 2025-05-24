using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Org.BouncyCastle.Utilities;
using WebSocketStreamingWithUI.TestWebSocket;
using WebSocketStreamingWithUI.Data;

namespace WebSocketStreamingWithUI.UserControls
{
    public partial class UC_Exchange : UserControl
    {
        private string selectedFromPair = null;
        private string selectedToPair = null;

        private Dictionary<string, Label> priceLabels = new();
        HttpClientPHP phpClient = new HttpClientPHP();

        private WebSocketPriceClient wsClient;
        public float epsilon = 0.0000001f;
        public UC_Exchange()
        {
            InitializeComponent();
            //phpClient.GetPHPRate();
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
                    amountTo.Text = "0";
                    return;

                }


                float a = float.Parse(priceOfFromCurrency.Text);
                float b = float.Parse(amountLabel.Text);
                float c = float.Parse(priceOfToCurrency.Text);


                float calculated = a * b;
                float converted = calculated / c;
                phpEquiv.Text = $"PHP {((converted * c)).ToString("N5")}";


                phpEquiv.Visible = true;
                amountTo.Text = converted.ToString();





            }
            catch (Exception ex)
            {
                exchangeButton.Text = "Invalid Input";

                InitializeComponent();
            }

        }

        public void ChangePlaceHolder(string currency)
        {
            selectedFromPair = currency;
            ChangePlaceHolderFrom(priceOfFromCurrency, selectedFromPair);

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

        private void SelectedLabelFrom_Click(object sender, EventArgs e)
        {

        }

        private void SelectedLabelFrom_Click_1(object sender, EventArgs e)
        {

        }

        private void exchangeButton_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            int selectedIndex = dropDownFrom.SelectedIndex;
            int indexTo = dropDownTo.SelectedIndex;
            if (dropDownTo.SelectedIndex >=0 && selectedLabelTo.Visible == false)
            {
                if (newUser.CheckHoldings(dropDownFrom.Items[selectedIndex].ToString()) > epsilon)
                {

                    if (amountLabel.Text != "0" && amountLabel.Text != string.Empty)
                    {
                        exchangeButton.Text = "Exchange";
                        if (float.Parse(amountLabel.Text) <= newUser.CheckHoldings(dropDownFrom.Items[selectedIndex].ToString()))
                        {
                            // Perform the Exchange Function
                            if (newUser.CheckHoldings(dropDownTo.Items[indexTo].ToString()) > epsilon)
                            {

                                newUser.UpdateHoldings(dropDownTo.Items[indexTo].ToString(), float.Parse(amountTo.Text), "+SWAP");

                            }
                            else
                            {
                                newUser.InsertToHoldings(dropDownTo.Items[indexTo].ToString(), float.Parse(amountTo.Text), "+SWAP");

                            }

                            newUser.UpdateHoldings(dropDownFrom.Items[selectedIndex].ToString(), float.Parse(amountLabel.Text), "-SWAP");
                        } else
                        {
                            exchangeButton.Text = "Insufficient Amount";
                        }
                    }
                    else
                    {
                        exchangeButton.Text = "Enter Amount First";
                    }
                    
                }else
                {
                    exchangeButton.Text = "You Dont Have that Currency";
                }
                

            }
            else
            {
                exchangeButton.Text= "Please Select Currency First";
                
            }
        }
    }
}
