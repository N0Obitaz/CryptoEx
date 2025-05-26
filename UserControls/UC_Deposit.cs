using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketStreamingWithUI.Class;

namespace WebSocketStreamingWithUI.UserControls
{
    public partial class UC_Deposit : UserControl
    {
        Userconnection newUser = new Userconnection();
        public UC_Deposit()
        {
            InitializeComponent();
        }

        private void depositConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            if (amountLabel.Text != "" && float.Parse(amountLabel.Text) > 0)
            {
                newUser.UpdateUserBalance(amountLabel.Text.ToString(), "+DEPOSIT", "PHP");
                depositConfirmButton.Text = "Deposit Successful!";                } else
            {
                depositConfirmButton.FillColor = Color.IndianRed;
                depositConfirmButton.Text = "Enter Amount First";
            }
               



            }
            catch (Exception ex)
            {
                
            }


        }

        private void amountLabel_TextChanged(object sender, EventArgs e)
        {
            depositConfirmButton.FillColor = Color.MediumSpringGreen;
            depositConfirmButton.Text = "Deposit";
        }
    }
}
