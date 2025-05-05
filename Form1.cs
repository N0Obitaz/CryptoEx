
using System.Text;

using System.Net.WebSockets;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System;

namespace WebSocketStreamingWithUI


{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


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

        private void labelBTC_Click(object sender, EventArgs e)
        {

        }
    }
}
