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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            favoritePanel = new Guna.UI2.WinForms.Guna2Panel();
            SuspendLayout();
            // 
            // favoritePanel
            // 
            favoritePanel.BackColor = Color.DarkGray;
            favoritePanel.CustomizableEdges = customizableEdges1;
            favoritePanel.Location = new Point(1, 1);
            favoritePanel.Name = "favoritePanel";
            favoritePanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            favoritePanel.Size = new Size(612, 579);
            favoritePanel.TabIndex = 0;
            // 
            // UC_Favorites
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(favoritePanel);
            Name = "UC_Favorites";
            Size = new Size(724, 651);
            Load += UC_Favorites_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel favoritePanel;
    }
}
