﻿using System.Net.WebSockets;
using System.Text;
using Guna.UI2.WinForms;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using WebSocketStreamingWithUI.TestWebSocket;
using WebSocketStreamingWithUI.Class;


namespace WebSocketStreamingWithUI.UserControls
{
    public partial class UC_Market : UserControl, IDisposable
    {

        private CancellationTokenSource _cancellationTokenSource;
        private ClientWebSocket _webSocket;
        private Task _webSocketTask;
        UserDashboard GetFormMethod = new UserDashboard();
        HttpClientPHP phpClient = new HttpClientPHP();
        public Dictionary<int, Guna2Panel> panels;
        public readonly Dictionary<string, string> priceTable = [];


        private string pair;
        public Dictionary<string, Label> priceLabels;
        private Dictionary<string, Label> tickerLabels;

        Userconnection user = new Userconnection();
        UC_Favorites uc_Favorite = new UC_Favorites();
        public UC_Market()
        {
            InitializeComponent();
            this.Load += UC_Market_Load;


            priceLabels = new Dictionary<string, Label>
            {
                { "BTC", labelBTC },
                { "ETH", labelETH },
                { "BNB", labelBNB },
                { "SOL", labelSOL },
                { "XRP", labelXRP },
                { "DOGE", labelDOGE },
                { "ADA", labelADA },
                { "AVAX", labelAVAX },
                { "BCH", labelBCH },
                { "DOT", labelDOT }
            };

            tickerLabels = new Dictionary<string, Label>
            {
                { "BTC", labelBTCTicker },
                { "ETH", labelETHTicker },
                { "BNB", labelBNBTicker },
                { "SOL", labelSOLTicker },
                { "XRP", labelXRPTicker },
                { "DOGE", labelDOGETicker },
                { "ADA", labelADATicker },
                { "AVAX", labelAVAXTicker },
                { "BCH", labelBCHTicker },
                { "DOT", labelDOTTicker }
            };
            panels = new Dictionary<int, Guna2Panel>
            {
                 {0, Panel1 },
                 {1, Panel2 },
                 {2, Panel3 },
                 {3, Panel4 },
                 {4, Panel5 },
                 {5, Panel6 },
                 {6, Panel7 },
                 {7, Panel8 },
                 {8, Panel9 },
                 {9, Panel10 },
            };
        }
        private async void UC_Market_Load(object sender, EventArgs e)
        {

            CreateActionButtons();
            _webSocketTask = ConnectAndReceiveAsync(GetWsUrl());

            GetFormMethod.AddUserControl(uc_Favorite, favoritesPanel);
        }


        // faster real time fetching of currency exchanges
        //wss://stream.binance.com:9443/stream?streams=btcusdt@trade

        //for final fetching of exchanges.
        //wss://wsapi.pro.coins.ph/openapi/quote/stream?streams=btcphp@trade

        private static readonly string[] pairs = {
        "btcusdt", "ethusdt", "bnbusdt", "solusdt",
        "xrpusdt", "dogeusdt", "adausdt", "avaxusdt",
        "bchusdt", "dotusdt"
        };


        private readonly string wsUrl = "wss://stream.binance.com:9443/stream?streams=" + string.Join("/", Array.ConvertAll(pairs, pair => $"{pair}@trade"));
        public string GetWsUrl()
        {
            return wsUrl;
        }

        public async Task ConnectAndReceiveAsync(string Uri)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _webSocket = new ClientWebSocket();

            try
            {
                await _webSocket.ConnectAsync(new Uri(Uri), _cancellationTokenSource.Token);


                byte[] buffer = new byte[4096];

                // Start ping loop
                while (_webSocket.State == WebSocketState.Open && _webSocket != null)
                {
                    //Used _cancellationTokenSource.Token variable
                    var result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), _cancellationTokenSource.Token);
                    string message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    UpdatePriceTable(message);
                }

            }
            catch (OperationCanceledException ex)
            {
                MessageBox.Show("Error:1" + ex.Message);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error:2" + ex.Message);
            }
            finally
            {
                base.Dispose();
            }
        }
        public void UpdatePriceTable(string jsonMessage)
        {
            try
            {
                var json = JObject.Parse(jsonMessage);

                //pair = json["s"].ToString().Split('@')[0].ToUpper();
                pair = json["data"]["s"].ToString().Split("USDT")[0];


                //coins.ph price format
                //string price = json["p"].ToString();

                //binance price format
                string price = json["data"]["p"].ToString();
                float phpRate = phpClient.GetPrice();
                if (float.TryParse(price, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float parsedPrice))
                {

                    float convertedPrice = (float)Math.Round(parsedPrice, 2) * phpRate;

                    priceTable[pair] = price; // Store latest price

                    //Update the ticker symbol and price label

                    if (labelBTC.Text == "0")
                    {

                        labelBTCTicker.Text = json["data"]["s"].ToString();

                        labelBTC.Text = convertedPrice.ToString("0.##");
                    }

                    string ticker = json["data"]["s"].ToString();
                    DisplayPriceTable(pair, convertedPrice);
                }

            }
            catch
            {
                //MessageBox.Show("d2 ka: " + ex.Message);
                this.Hide();
                Dispose();

            }
        }

        private void DisplayPriceTable(string pairSymbol, float price)
        {
            //pairSymbol is used as a key to access the priceLabels and tickerLabels values
            //ticker is used to store it as a value for tickerLabels
            //price will be assigned to corresponding priceLabels dictionary


            //get the stored value of the priceLabels
            float previousPrice = (float)Math.Round(float.Parse(priceLabels[pairSymbol].Text), 2);


            foreach (var pair in priceLabels)
            {
                Label label = pair.Value;

                if (float.Parse(label.Text) != 0)
                {
                    //If price goes up
                    if (price > previousPrice)
                    {
                        priceLabels[pairSymbol].ForeColor = Color.Green;
                    }//If price goes down
                    else if (price < previousPrice)
                    {
                        priceLabels[pairSymbol].ForeColor = Color.Red;
                    }

                    priceLabels[pairSymbol].Text = price.ToString("N2");


                    tickerLabels[pairSymbol].Text = pairSymbol;

                }

                //access yung price ng ticker
                //convert into float
                //gawing previousprice
                //checking previous to current
                //change colors

            }
        }




        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button btn && btn.Tag is string currency)
            {
                if (priceLabels.TryGetValue(currency, out Label priceLabel))
                {
                    if (float.TryParse(priceLabel.Text, out float livePrice))
                    {

                        UC_Exchange uC_Exchange = new UC_Exchange();
                        uC_Exchange.ChangePlaceHolder(currency);



                        GetFormMethod.AddUserControl(uC_Exchange, marketPanel);


                    }
                    else
                    {
                        MessageBox.Show($"Failed to parse price for {currency}");
                    }
                }
                else
                {
                    MessageBox.Show($"Currency {currency} not found in priceLabels.");
                }
            }
        }

        private void marketPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelBTCTicker_Click(object sender, EventArgs e)
        {

        }

        private void assetTicker_Click(object sender, EventArgs e)
        {

        }

        private void favoriteSwitch_CheckedChanged(object sender, EventArgs e)
        {
            var uC_Favorites = new UC_Favorites();
            UserDashboard form1 = new UserDashboard();
            form1.AddUserControl(uC_Favorites, marketPanel);

        }

        private void UC_Market_Load_1(object sender, EventArgs e)
        {

        }
        private void buyButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button btn && btn.Tag is string operation)
            {
                UC_Buy uC_Buy = new UC_Buy();
                uC_Buy.AssignOperator(operation);
                GetFormMethod.AddUserControl(uC_Buy, marketPanel);
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
            if (sender is Guna2Button btn && btn.Tag is string operation)
            {

                UC_Buy uC_Buy = new UC_Buy();
                uC_Buy.AssignOperator(operation);
                GetFormMethod.AddUserControl(uC_Buy, marketPanel);
            }
        }

        public void Dispose()
        {
            _cancellationTokenSource?.Cancel();

            try
            {
                _webSocket?.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None).Wait();
            }
            catch { /* ignore if already closed */ }

            _webSocket?.Dispose();
            _cancellationTokenSource?.Dispose();

            _webSocket = null;
            _cancellationTokenSource = null;

            base.Dispose();
        }

        private void transactionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddToFavorite(object sender, EventArgs e)
        {
            if (sender is Guna2Button btn && btn.Tag is string currency)
            {
                //Perform Adding Favorite Currency

                user.AddToFavorite(currency, uc_Favorite, favoritesPanel);
            }
            else
            {
                MessageBox.Show("Can't Add To Favorites");
            }
        }

        private void marketPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}