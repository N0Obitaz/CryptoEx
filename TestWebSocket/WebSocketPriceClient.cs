using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WebSocketStreamingWithUI.TestWebSocket
{
    public class WebSocketPriceClient: IDisposable
    {
        HttpClientPHP phpClient = new HttpClientPHP();


        private float phpRate;
        
        public delegate void PriceUpdateHandler(string pair, float price);
        public event PriceUpdateHandler OnPriceUpdate;

        


        public readonly string[] pairs = {
        "btcusdt", "ethusdt", "bnbusdt", "solusdt",
        "xrpusdt", "dogeusdt", "adausdt", "avaxusdt",
        "bchusdt", "dotusdt"
    };

        private string wsUrl => "wss://stream.binance.com:9443/stream?streams=" +
            string.Join("/", pairs.Select(p => $"{p}@trade"));

        public async Task ConnectAsync()
        {
            
            try
            {
                using var ws = new ClientWebSocket();
                await ws.ConnectAsync(new Uri(wsUrl), CancellationToken.None);

                byte[] buffer = new byte[4096];
                while (ws.State == WebSocketState.Open)
                {
                    var result = await ws.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    string message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    HandleMessage(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("WebSocket Error: " + ex.Message);
            }
        }

        private void HandleMessage(string jsonMessage)
        {
            
            try
            {
                var json = JObject.Parse(jsonMessage);
                string pair = json["data"]["s"].ToString().Split("USDT")[0];
                
                //Change to real price of PHP(it's not yet implemented)
                float price = float.Parse(json["data"]["p"].ToString()) * 55.50f ;
                //MessageBox.Show(phpClient.phpPrice.ToString());

                OnPriceUpdate?.Invoke(pair, price);
            }
            catch { /* Ignore malformed messages */ }
        }
        public new void Dispose()
        {

        }
    }

}
