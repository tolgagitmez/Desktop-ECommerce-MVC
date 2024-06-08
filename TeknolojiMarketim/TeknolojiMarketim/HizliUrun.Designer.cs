namespace TeknolojiMarketim
{
    partial class HizliUrun
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
            this.lbl_UrunAd = new System.Windows.Forms.Label();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_UrunAd
            // 
            this.lbl_UrunAd.AutoSize = true;
            this.lbl_UrunAd.Location = new System.Drawing.Point(4, 113);
            this.lbl_UrunAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UrunAd.Name = "lbl_UrunAd";
            this.lbl_UrunAd.Size = new System.Drawing.Size(44, 16);
            this.lbl_UrunAd.TabIndex = 5;
            this.lbl_UrunAd.Text = "label1";
            // 
            // pb_resim
            // 
            this.pb_resim.Location = new System.Drawing.Point(4, 4);
            this.pb_resim.Margin = new System.Windows.Forms.Padding(4);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(167, 106);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_resim.TabIndex = 4;
            this.pb_resim.TabStop = false;
            // 
            // HizliUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_UrunAd);
            this.Controls.Add(this.pb_resim);
            this.Name = "HizliUrun";
            this.Size = new System.Drawing.Size(175, 145);
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_UrunAd;
        public System.Windows.Forms.PictureBox pb_resim;
    }
}
