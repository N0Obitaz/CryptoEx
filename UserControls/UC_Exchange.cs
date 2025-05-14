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

        private void fromCurrency_TextChanged(object sender, EventArgs e)
        {

        }
        public void ChangePlaceHolder(string currency, float livePrice)
        {
            fromCurrency.Text = currency;
            fromAmountLabel.Text = livePrice.ToString("N2");
        }
    }
}
