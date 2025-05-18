using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketStreamingWithUI.Data;

namespace WebSocketStreamingWithUI.UserControls
{
    public partial class UC_Withdraw : UserControl
    {
        User newUser = new User();
        public UC_Withdraw()
        {
            InitializeComponent();
        }

        private void withdrawConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (amountLabel.Text != "" && float.Parse(amountLabel.Text) > 0)
                {
                    newUser.UpdateUserBalance(amountLabel.Text.ToString(), "-");
                    withdrawConfirmButton.Text = "Withdraw Successful!";
                }
                else
                {
                    withdrawConfirmButton.FillColor = Color.IndianRed;
                    withdrawConfirmButton.Text = "Enter Amount First";
                }




            }
            catch (Exception ex)
            {

            }
        }

        private void amountLabel_TextChanged(object sender, EventArgs e)
        {
            withdrawConfirmButton.FillColor = Color.MediumSpringGreen;
            withdrawConfirmButton.Text = "Withdraw";
        }
    }
}
