using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace WebSocketStreamingWithUI.TestWebSocket
{
    public class WebSocketPriceClient: IDisposable
    {



        private CancellationTokenSource _cancellationTokenSource;
        private ClientWebSocket _webSocket;

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
            _webSocket = new ClientWebSocket();
            _cancellationTokenSource = new CancellationTokenSource();
            try
            {

                await _webSocket.ConnectAsync(new Uri(wsUrl), _cancellationTokenSource.Token);

                byte[] buffer = new byte[4096];
                while (_webSocket.State == WebSocketState.Open)
                {
                    var result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), _cancellationTokenSource.Token);
                    string message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    HandleMessage(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("WebSocket Error: " + ex.Message);
            }
            finally
            {
                Dispose();
            }
        }

        private void HandleMessage(string jsonMessage)
        {
            
            try
            {
                var json = JObject.Parse(jsonMessage);
                string pair = json["data"]["s"].ToString().Split("USDT")[0];
                
                //Change to real price of PHP(it's not yet implemented)
                float price = float.Parse(json["data"]["p"].ToString()) * HttpClientPHP.phpPrice ;
                //MessageBox.Show(phpClient.phpPrice.ToString());

                OnPriceUpdate?.Invoke(pair, price);
            }
            catch { /* Ignore malformed messages */ }
            
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

        }
    }

}
