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
    public partial class UC_Withdraw : UserControl
    {
        Userconnection newUser = new Userconnection();
        UserDashboard form = new UserDashboard();
        public UC_Withdraw()
        {
            InitializeComponent();
        }

        private void withdrawConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (newUser.CheckUserBalance(amountLabel.Text.ToString()))
                {
                    if (amountLabel.Text != "" && float.Parse(amountLabel.Text) > 0)
                    {
                        newUser.UpdateUserBalance(amountLabel.Text.ToString(), "-WITHDRAW", "PHP");
                        withdrawConfirmButton.Text = "Withdraw Successful!";
                        form.GetUser();
                        
                    }
                    else
                    {
                        withdrawConfirmButton.FillColor = Color.IndianRed;
                        withdrawConfirmButton.Text = "Enter Amount First";
                    }
                }else
                {
                    withdrawConfirmButton.FillColor = Color.IndianRed;
                    withdrawConfirmButton.Text = "Insufficient Amount";
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
