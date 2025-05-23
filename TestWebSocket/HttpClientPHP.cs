using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebSocketStreamingWithUI.TestWebSocket
{
    public class HttpClientPHP : IDisposable
    {
        private float phpPrice;
        private readonly HttpClient _httpClient;
        public float GetPrice()
        {
           
            return phpPrice;
        }
        public HttpClientPHP()
        {
            _httpClient = new HttpClient();
        }


        public async Task GetPHPRate()
        {
            try
            {
                var response = await _httpClient.GetStringAsync("https://api.coingecko.com/api/v3/simple/price?ids=tether&vs_currencies=php");
                var priceData = JsonSerializer.Deserialize<JsonElement>(response);
                var propertyPrice = priceData.GetProperty("tether").GetProperty("php").GetDecimal();

                phpPrice = float.Parse(propertyPrice.ToString());
            }
            catch (Exception ex)
            {
                // Handle network or parsing errors
                Console.WriteLine("Error fetching PHP rate: " + ex.Message);
            }
        }
        public void Dispose()
        {
            _httpClient?.Dispose();
        }


    }
}
