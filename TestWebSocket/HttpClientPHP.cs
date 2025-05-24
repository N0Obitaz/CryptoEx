
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
        public static float phpPrice;
        private readonly HttpClient _httpClient;
        public  float GetPrice()
        {

            return phpPrice;
        }
        public HttpClientPHP()
        {
            _httpClient = new HttpClient();
        }

        public static bool hasFetch = false;
        public static void GetPHPRate()
        {
            if (hasFetch)
                return;

            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.GetAsync("https://api.coingecko.com/api/v3/simple/price?ids=tether&vs_currencies=php").Result;
                    var json = response.Content.ReadAsStringAsync().Result;
                    var priceData = JsonSerializer.Deserialize<JsonElement>(json);
                    var price = priceData.GetProperty("tether").GetProperty("php").GetDecimal();

                    phpPrice = float.Parse(price.ToString());
                    hasFetch = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching PHP rate: " + ex.Message);
            }
        }



    }
}
