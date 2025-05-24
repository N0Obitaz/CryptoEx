
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebSocketStreamingWithUI.TestWebSocket
{
    public class HttpClientPHP
    {
        public float phpPrice;
        private readonly HttpClient _httpClient;
        public  float GetPrice()
        {

            return phpPrice;
        }
        public HttpClientPHP()
        {
            _httpClient = new HttpClient();
        }

        bool hasFetch = false;
        public async Task GetPHPRate()
        {
            if (hasFetch)
            {
                return;
            }
            try
            {
                var response = await _httpClient.GetStringAsync("https://api.coingecko.com/api/v3/simple/price?ids=tether&vs_currencies=php");
                var priceData = JsonSerializer.Deserialize<JsonElement>(response);
                var propertyPrice = priceData.GetProperty("tether").GetProperty("php").GetDecimal();
                
                phpPrice = float.Parse(propertyPrice.ToString());
                await Task.Delay(5000);
                hasFetch = true;
                
            }
            catch (Exception ex)
            {
                // Handle network or parsing errors
                MessageBox.Show("Error fetching PHP rate: " + ex.Message);
            }
        }
        


    }
}
