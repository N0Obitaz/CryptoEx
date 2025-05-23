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
        private float phpPrice;
        public float GetPrice()
        {
           
            return phpPrice;
        }
       
       
        public async Task GetPHPRate()
        {
            var httpClient = new HttpClient();

            
                var response = await httpClient.GetStringAsync("https://api.coingecko.com/api/v3/simple/price?ids=tether&vs_currencies=php");
                var priceData = JsonSerializer.Deserialize<JsonElement>(response);
                var propertyPrice = priceData.GetProperty("tether").GetProperty("php").GetDecimal();

                phpPrice = float.Parse(propertyPrice.ToString());
                

                
            
        }
        
        
    }
}
