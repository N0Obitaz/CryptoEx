
using System.Windows.Forms;
using Guna.UI2.WinForms;
using WebSocketStreamingWithUI.TestWebSocket;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using WebSocketStreamingWithUI.Class;


namespace WebSocketStreamingWithUI.UserControls
{
    public partial class UC_Buy : UserControl, IDisposable
    {
        private System.Windows.Forms.Timer _updateTimer;

        Userconnection newUser = new Userconnection();
        private Dictionary<string, Guna2HtmlLabel> priceLabels = new();
        public float amountToPass = 0;
        private string currentSelectedPair = null;
        WebSocketPriceClient ws;
        public float epsilon = 0.0000001f;
        private Task _wsTask;

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
            _wsTask =  ws.ConnectAsync();
            StartThrottling();
        }

        private float _latestPrice = 0;
        private string _latestPair = "";
        private void WsClient_OnPriceUpdate(string pair, float price)
        {
            _latestPair = pair;
            _latestPrice = price;

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdatePriceThrottled(pair, price)));
            }
            else
            {
                UpdatePriceThrottled(pair, price);
            }
        }


        private void StartThrottling()
        {
            _updateTimer = new System.Windows.Forms.Timer();
            _updateTimer.Interval = 500; // Update UI every 250ms max
            _updateTimer.Tick += (s, e) =>
            {
                UpdatePriceThrottled(_latestPair, _latestPrice);
            };
            _updateTimer.Start();
        }

        private void UpdatePriceThrottled(string pairSymbol, float newPrice)
        {
            if (pairSymbol != currentSelectedPair) return;

            try
            {
                float prevPrice = float.TryParse(priceChanges.Text, out float val) ? val : 0;

                priceChanges.ForeColor = newPrice > prevPrice ? Color.Green :
                                       newPrice < prevPrice ? Color.Red : priceChanges.ForeColor;

                priceChanges.Text = newPrice.ToString("N2");

                if (string.IsNullOrWhiteSpace(amountLabel.Text))
                {
                    currencyEquiv.Text = "0";
                    return;
                }

                float calculated = float.Parse(amountLabel.Text) * newPrice;
                amountToPass = calculated;
                currencyEquiv.Text = calculated.ToString("N");
                currencyEquiv.Visible = true;

                if (calculated < epsilon)
                {
                    actionButton.Text = "Enter an Amount";
                    actionButton.FillColor = Color.IndianRed;
                }
                //else
                //{
                //    if (newUser.CheckUserBalance(currencyEquiv.Text))
                //    {
                //        actionButton.Text = "Confirm";
                //        actionButton.FillColor = Color.MediumSpringGreen;
                //    }
                //    else
                //    {
                //        actionButton.Text = "Your Balance is Less";
                //        actionButton.FillColor = Color.IndianRed;
                //    }
                //}
            }
            catch (Exception ex)
            {
               
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


        private string operation;
        public void AssignOperator(string ope)
        {
            if (ope == "SELL")
            {
                operation = "+" + ope;
                return;
            }
            operation = "-" + ope;
        }
        
        private void actionButton_Click(object sender, EventArgs e)
        {   
            if (amountLabel.Text == "") return;



            float amount = float.Parse(amountLabel.Text);

            if (amount <= newUser.CheckHoldings(currentSelectedPair))
            {
                ProcessTransaction(amount);
                return;
            }
            else if(newUser.CheckUserBalance(amountToPass.ToString())) 

            {
                ProcessTransaction(amount);
            }else
            {
                actionButton.Text = "You Can't Afford That";
                actionButton.FillColor = Color.IndianRed;
            }

            operation = "";
           
        }

        private void ProcessTransaction(float amount)
        {

            actionButton.Text = "Confirm";
            actionButton.FillColor = Color.MediumSpringGreen;

            if (newUser.CheckHoldings(currentSelectedPair) > epsilon)
            {

                newUser.UpdateHoldings(currentSelectedPair, amount, operation);

                newUser.UpdateBalance(amountToPass, operation, currentSelectedPair);
            }
            else
            {
               
                newUser.InsertToHoldings(currentSelectedPair, amount, operation);
                newUser.UpdateBalance(amountToPass, operation, currentSelectedPair);


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
        private void amountLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
