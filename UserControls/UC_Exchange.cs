using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSocketStreamingWithUI.UserControls
{
    public partial class UC_Exchange : UserControl
    {
        public UC_Exchange()
        {
            InitializeComponent();
            
        }
        private void UpdatePrices(string pairSymbol)
        {
            //Update Price of the selected symbol then feature it in the exchange panels (NOT WORKING)
            UC_Market uc = new UC_Market();
            foreach (var pair in uc.priceLabels)
            {
                Label label = pair.Value;
                MessageBox.Show(uc.priceLabels[pairSymbol].Text);
                priceOfFromCurrency.Text = uc.priceLabels[pairSymbol].Text;

            }
        }

        private void fromCurrency_TextChanged(object sender, EventArgs e)
        {

        }
        public void ChangePlaceHolder(string currency, float livePrice)
        {
            selectOptionFrom.Text = currency;
           
            UpdatePrices(currency);
            
            //fromAmountLabel.Text = livePrice.ToString("N2");
        }

        private void selectOption_Click(object sender, EventArgs e)
        {

        }
    }
}
