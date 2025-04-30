
using System.Text;

using System.Net.WebSockets;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System;





namespace WebSocketStreamingWithUI


{
    public partial class Form1 : Form
    {
        // faster real time fetching of currency exchanges
        //wss://stream.binance.com:9443/stream?streams=btcusdt@trade

        //for final fetching of exchanges.
        //wss://wsapi.pro.coins.ph/openapi/quote/stream?streams=btcphp@trade

        private static readonly string[] pairs = {
        "btcusdt", "ethusdt", "bnbusdt", "solusdt",
        "xrpusdt", "dogeusdt", "adausdt", "avaxusdt",
        "bchusdt", "dotusdt"
    };


        private readonly string wsUrl;
        private Dictionary<string, string> priceTable;

        public static string pair;
        public static string price;
        private Dictionary<string, Label> priceLabels;
        private Dictionary<string, Label> tickerLabels;

        public Form1()
        {
            InitializeComponent();

            wsUrl = "wss://stream.binance.com:9443/stream?streams=" + string.Join("/", Array.ConvertAll(pairs, pair => $"{pair}@trade"));
            priceTable = new Dictionary<string, string>();
            CreateActionButtons();



            this.Load += Form1_Load_1;

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

        }





        public async Task ConnectAndReceiveAsync()
        {


            try
            {
                using (ClientWebSocket ws = new ClientWebSocket())
                {
                    await ws.ConnectAsync(new Uri(wsUrl), CancellationToken.None);
                    Console.WriteLine("Connected!");

                    byte[] buffer = new byte[4096];

                    // Start ping loop
                    while (ws.State == WebSocketState.Open)
                    {
                        var result = await ws.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                        string message = Encoding.UTF8.GetString(buffer, 0, result.Count);


                        UpdatePriceTable(message);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        private void UpdatePriceTable(string jsonMessage)
        {
            try
            {
                var json = JObject.Parse(jsonMessage);

                //pair = json["s"].ToString().Split('@')[0].ToUpper(); // Extract pair name
                pair = json["data"]["s"].ToString().Split("USDT")[0];


                //coins.ph price format
                //string price = json["p"].ToString();

                //binance price format
                string price = json["data"]["p"].ToString();

                float convertedPrice = (float)Math.Round(float.Parse(price), 2);

                priceTable[pair] = price; // Store latest price



                string labelString = labelBTC.Text;
                float previousPrice = 0;

                // For safety parsing
                float.TryParse(labelString, out previousPrice);

                // Add a tiny threshold to prevent flickering
                if (convertedPrice > previousPrice)
                {   // Price went up
                    labelBTC.ForeColor = Color.PaleGreen;
                    dollarSymbol.ForeColor = Color.PaleGreen;
                }
                else if (convertedPrice < previousPrice)
                {
                    // Price went down
                    dollarSymbol.ForeColor = Color.Red;
                    labelBTC.ForeColor = Color.Red;
                }


                //Update the ticker symbol and price label

                if (labelBTC.Text == "0")
                {

                    labelBTCTicker.Text = json["data"]["s"].ToString();

                    labelBTC.Text = convertedPrice.ToString("0.##");
                }
                string ticker = json["data"]["s"].ToString();
                DisplayPriceTable(pair, ticker, convertedPrice);





            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayPriceTable(string pairSymbol, string ticker, float price)
        {

            foreach (var pair in priceLabels)
            {
                Label label = pair.Value;
                if (float.Parse(label.Text) != 0)
                {
                    priceLabels[pairSymbol].Text = price.ToString();
                    priceLabels[pairSymbol].ForeColor = Color.PaleGreen;
                    tickerLabels[pairSymbol].Text = ticker;


                    //priceLabels[pairSymbol].Text = label.Text;

                }

            }
        }

        private async void labelBTC_Click(object sender, EventArgs e)
        {



        }

        private void labelETH_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load_1(object sender, EventArgs e)
        {
            await ConnectAndReceiveAsync();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show("Clicked: " + clickedButton?.Text);
        }

      
    }
}
