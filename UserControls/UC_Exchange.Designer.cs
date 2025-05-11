namespace WebSocketStreamingWithUI.UserControls
{
    partial class UC_Exchange
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
            ExchangeNow = new Label();
            SuspendLayout();
            // 
            // ExchangeNow
            // 
            ExchangeNow.AutoSize = true;
            ExchangeNow.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExchangeNow.Location = new Point(328, 204);
            ExchangeNow.Name = "ExchangeNow";
            ExchangeNow.Size = new Size(213, 34);
            ExchangeNow.TabIndex = 0;
            ExchangeNow.Text = "ExchangeNow";
            // 
            // UC_Exchange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ExchangeNow);
            Name = "UC_Exchange";
            Size = new Size(869, 443);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ExchangeNow;
    }
}
