namespace WebSocketStreamingWithUI.UserControls
{
    partial class UC_Favorites
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            favoritesPanel = new Guna.UI2.WinForms.Guna2Panel();
            outerPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            favoriteLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            favoritesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // favoritesPanel
            // 
            favoritesPanel.BackColor = Color.Transparent;
            favoritesPanel.BorderRadius = 20;
            favoritesPanel.Controls.Add(outerPanel);
            favoritesPanel.Controls.Add(guna2Separator1);
            favoritesPanel.Controls.Add(favoriteLabel);
            favoritesPanel.CustomizableEdges = customizableEdges3;
            favoritesPanel.FillColor = Color.FromArgb(60, 63, 64);
            favoritesPanel.Location = new Point(0, 0);
            favoritesPanel.Name = "favoritesPanel";
            favoritesPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            favoritesPanel.Size = new Size(322, 518);
            favoritesPanel.TabIndex = 74;
            // 
            // outerPanel
            // 
            outerPanel.AutoScroll = true;
            outerPanel.BackgroundImageLayout = ImageLayout.None;
            outerPanel.CustomizableEdges = customizableEdges1;
            outerPanel.Location = new Point(7, 61);
            outerPanel.Name = "outerPanel";
            outerPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            outerPanel.Size = new Size(303, 401);
            outerPanel.TabIndex = 77;
            outerPanel.Paint += outerPanel_Paint;
            // 
            // guna2Separator1
            // 
            guna2Separator1.BackColor = Color.Transparent;
            guna2Separator1.FillColor = Color.Black;
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(-5, 46);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(324, 10);
            guna2Separator1.TabIndex = 75;
            // 
            // favoriteLabel
            // 
            favoriteLabel.BackColor = Color.Transparent;
            favoriteLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            favoriteLabel.ForeColor = Color.White;
            favoriteLabel.Location = new Point(19, 13);
            favoriteLabel.Name = "favoriteLabel";
            favoriteLabel.Size = new Size(80, 27);
            favoriteLabel.TabIndex = 74;
            favoriteLabel.Text = "Favorites";
            // 
            // UC_Favorites
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(favoritesPanel);
            Name = "UC_Favorites";
            Size = new Size(506, 671);
            Load += UC_Favorites_Load;
            favoritesPanel.ResumeLayout(false);
            favoritesPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel favoritesPanel;
        private Guna.UI2.WinForms.Guna2Panel outerPanel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel favoriteLabel;
    }
}
