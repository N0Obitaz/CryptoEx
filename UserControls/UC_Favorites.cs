using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.Logging;
using System.Windows.Forms.Design;
using WebSocketStreamingWithUI.Data;


namespace WebSocketStreamingWithUI.UserControls
{
    
    public partial class UC_Favorites : UserControl
    {
        User user = new User();
       
        public UC_Favorites()
        {
            InitializeComponent();

          
        }

        private void UC_Favorites_Load(object sender, EventArgs e)
        {
            List<string> currencyList = user.FetchFavorites();

            List<FavoriteItems> items = new List<FavoriteItems>();
           

            foreach (string currency in currencyList)
           {

                var btn = new Guna2Button()
                {
                    Size = new Size(50,50),
                    Font = new Font("Segoe UI", 10),
                    FillColor = Color.Transparent,
                    
                    Margin = new Padding(5),
                    Location = new Point(180, 6),
                    ImageSize = new Size(50,50),
                    Cursor = Cursors.Hand,
                    Tag = currency
                };
                btn.Click += RemoveFavoriteClick;

                Image defaultImage = Image.FromFile("Resources/closeHeart.png");
                Image hoverImage = Image.FromFile("Resources/tooApart.png");

                btn.Image = defaultImage;

                btn.MouseEnter += (s, args) =>
                {
                    btn.FillColor = Color.Transparent;
                    btn.Image = hoverImage;
                };

                btn.MouseLeave += (s, args) =>
                {
                    btn.Image = defaultImage;
                };


                var logo = new Guna2PictureBox()
                {
                    Size = new Size(30, 30),
                    Location = new Point(7, 6),
                    FillColor = Color.Transparent,
                    Image = Image.FromFile($"Resources/CurrencyImages/{currency}.png"),
                    
                    SizeMode = PictureBoxSizeMode.StretchImage

                };

                var label = new Label()
                {
                    Text = currency,
                    ForeColor = Color.White,
                    Font = new Font("Times New Roman", 12f, FontStyle.Bold),
                    Size = new Size(80, 25),
                    Location = new Point(60, 12)
                };
                items.Add(new FavoriteItems
                {
                    Logo = logo,
                    Currency = label,
                    Button = btn,
                   
                });
            }


            int innerYOffset = 15;
            foreach (var item in items)
            {
                Guna2Panel holdingsBox = new Guna2Panel
                {
                    Size = new Size(240, 50),
                    Location = new Point(32, innerYOffset),
                    FillColor = Color.Transparent,
                    BackColor = Color.Transparent
                    
                };
                holdingsBox.Controls.Add(item.Logo);
                holdingsBox.Controls.Add(item.Currency);
                holdingsBox.Controls.Add(item.Button);

                innerYOffset += holdingsBox.Height;
                outerPanel.BringToFront();
                outerPanel.Controls.Add(holdingsBox);
            }

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void RemoveFavoriteClick(object sender, EventArgs e)
        {
            if (sender is Guna2Button btn && btn.Tag is string currency)
            {
                UC_Favorites uc = new UC_Favorites();
                //Perform Removing Logic
                user.RemoveToFavorite(currency, uc , favoritesPanel);
            }
        }
    }
    public class FavoriteItems
    {

        public Guna2PictureBox Logo { get; set; }
        public Label Currency { get; set; }
        public Guna2Button Button { get; set; }

    }
}
