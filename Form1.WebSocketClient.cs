/*
This section of the source code handles the real-time fetching of 
currency prices via websocket


*/

using System.Net.WebSockets;
using System.Text;
using Newtonsoft.Json.Linq;

namespace WebSocketStreamingWithUI
{
    public partial class Form1 : Form

    {

        private readonly Dictionary<string, string> priceTable = [];

        private string pair;
        private static string price;
        private Dictionary<string, Label> priceLabels;
        private Dictionary<string, Label> tickerLabels;
        private Dictionary<string, float> previousPrices = [];

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
        public string GetWsUrl()
        {
            return "wss://stream.binance.com:9443/stream?streams=" + string.Join("/", Array.ConvertAll(pairs, pair => $"{pair}@trade"));
        }
        
       
        public async Task ConnectAndReceiveAsync()
        {


            try
            {
                using (ClientWebSocket ws = new ClientWebSocket())
                {
                    await ws.ConnectAsync(new Uri(GetWsUrl()), CancellationToken.None);
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

                //pair = json["s"].ToString().Split('@')[0].ToUpper();
                pair = json["data"]["s"].ToString().Split("USDT")[0];


                //coins.ph price format
                //string price = json["p"].ToString();

                //binance price format
                string price = json["data"]["p"].ToString();

                float convertedPrice = (float)Math.Round(float.Parse(price), 2);

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayPriceTable(string pairSymbol, float price)
        {
            //pairSymbol is used as a key to access the priceLabels and tickerLabels values
            //ticker is used to store it as a value for tickerLabels
            //price will be assigned to corresponding priceLabels dictionary


            float previousPrice = (float)Math.Round(float.Parse(priceLabels[pairSymbol].Text), 2);


           
            foreach (var pair in priceLabels)
            {
                
                Label label = pair.Value;
                
                if (float.Parse(label.Text) != 0)
                {

                    if (price > previousPrice)
                    {
                        priceLabels[pairSymbol].ForeColor = Color.Green;
                    }
                    else if (price < previousPrice) 
                    {
                        priceLabels[pairSymbol].ForeColor = Color.Red;
                    }

                    priceLabels[pairSymbol].Text = price.ToString();
                    
                   
                    tickerLabels[pairSymbol].Text = pairSymbol;


                    //priceLabels[pairSymbol].Text = label.Text;

                }

                //access yung price ng ticker
                //convert into float
                //gawing previousprice
                //i-store sa dictionary?
                //checking previous to current
                //change colors



            }
        }


        private void CheckPrices(float previousPrice, float currentPrice)
        {

        }
        private async void labelBTC_Click(object sender, EventArgs e)
        {



        }

        private void labelETH_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load_1(object sender, EventArgs e)
        {
            CreateActionButtons();
            await ConnectAndReceiveAsync();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show("Clicked: " + clickedButton?.Text);
        }


    }

}
