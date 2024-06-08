namespace TeknolojiMarketim
{
    partial class AnaForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TSMI_kullanici = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Raporlama = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_siparisYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AlisIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_satis = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SatisModul = new System.Windows.Forms.ToolStripMenuItem();
            this.satışModülüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TedarikciForm = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UrunForm = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Markalar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategoriForm = new System.Windows.Forms.ToolStripMenuItem();
            this.urunİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSL_kullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSMI_kullanici
            // 
            this.TSMI_kullanici.Name = "TSMI_kullanici";
            this.TSMI_kullanici.Size = new System.Drawing.Size(208, 26);
            this.TSMI_kullanici.Text = "Kullanıcı İşlemleri";
            // 
            // TSMI_admin
            // 
            this.TSMI_admin.Name = "TSMI_admin";
            this.TSMI_admin.Size = new System.Drawing.Size(208, 26);
            this.TSMI_admin.Text = "Admin İşlemleri";
            this.TSMI_admin.Click += new System.EventHandler(this.TSMI_admin_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_admin,
            this.TSMI_kullanici});
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // TSMI_Raporlama
            // 
            this.TSMI_Raporlama.Name = "TSMI_Raporlama";
            this.TSMI_Raporlama.Size = new System.Drawing.Size(198, 26);
            this.TSMI_Raporlama.Text = "Raporlama";
            this.TSMI_Raporlama.Click += new System.EventHandler(this.TSMI_Raporlama_Click);
            // 
            // TSMI_siparisYonetimi
            // 
            this.TSMI_siparisYonetimi.Name = "TSMI_siparisYonetimi";
            this.TSMI_siparisYonetimi.Size = new System.Drawing.Size(198, 26);
            this.TSMI_siparisYonetimi.Text = "Sipariş Yönetimi";
            this.TSMI_siparisYonetimi.Click += new System.EventHandler(this.TSMI_siparisYonetimi_Click);
            // 
            // TSMI_AlisIslemleri
            // 
            this.TSMI_AlisIslemleri.Name = "TSMI_AlisIslemleri";
            this.TSMI_AlisIslemleri.Size = new System.Drawing.Size(198, 26);
            this.TSMI_AlisIslemleri.Text = "Alış";
            this.TSMI_AlisIslemleri.Click += new System.EventHandler(this.TSMI_AlisIslemleri_Click);
            // 
            // TSMI_satis
            // 
            this.TSMI_satis.Name = "TSMI_satis";
            this.TSMI_satis.Size = new System.Drawing.Size(198, 26);
            this.TSMI_satis.Text = "Satışlar";
            this.TSMI_satis.Click += new System.EventHandler(this.TSMI_satis_Click);
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_satis,
            this.TSMI_AlisIslemleri,
            this.TSMI_siparisYonetimi,
            this.TSMI_Raporlama});
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.satışİşlemleriToolStripMenuItem.Text = "Satış ve Alış İşlemleri";
            // 
            // TSMI_SatisModul
            // 
            this.TSMI_SatisModul.Name = "TSMI_SatisModul";
            this.TSMI_SatisModul.Size = new System.Drawing.Size(135, 26);
            this.TSMI_SatisModul.Text = "Modül";
            this.TSMI_SatisModul.Click += new System.EventHandler(this.TSMI_SatisModul_Click);
            // 
            // satışModülüToolStripMenuItem
            // 
            this.satışModülüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_SatisModul});
            this.satışModülüToolStripMenuItem.Name = "satışModülüToolStripMenuItem";
            this.satışModülüToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.satışModülüToolStripMenuItem.Text = "Satış Modülü";
            // 
            // TSMI_TedarikciForm
            // 
            this.TSMI_TedarikciForm.Name = "TSMI_TedarikciForm";
            this.TSMI_TedarikciForm.Size = new System.Drawing.Size(168, 26);
            this.TSMI_TedarikciForm.Text = "Tedarikçiler";
            this.TSMI_TedarikciForm.Click += new System.EventHandler(this.TSMI_TedarikciForm_Click);
            // 
            // TSMI_UrunForm
            // 
            this.TSMI_UrunForm.Name = "TSMI_UrunForm";
            this.TSMI_UrunForm.Size = new System.Drawing.Size(168, 26);
            this.TSMI_UrunForm.Text = "Ürünler";
            this.TSMI_UrunForm.Click += new System.EventHandler(this.TSMI_UrunForm_Click);
            // 
            // TSMI_Markalar
            // 
            this.TSMI_Markalar.Name = "TSMI_Markalar";
            this.TSMI_Markalar.Size = new System.Drawing.Size(168, 26);
            this.TSMI_Markalar.Text = "Markalar";
            this.TSMI_Markalar.Click += new System.EventHandler(this.TSMI_Markalar_Click);
            // 
            // TSMI_KategoriForm
            // 
            this.TSMI_KategoriForm.Name = "TSMI_KategoriForm";
            this.TSMI_KategoriForm.Size = new System.Drawing.Size(168, 26);
            this.TSMI_KategoriForm.Text = "Kategoriler";
            this.TSMI_KategoriForm.Click += new System.EventHandler(this.TSMI_KategoriForm_Click);
            // 
            // urunİşlemleriToolStripMenuItem
            // 
            this.urunİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_KategoriForm,
            this.TSMI_Markalar,
            this.TSMI_UrunForm,
            this.TSMI_TedarikciForm});
            this.urunİşlemleriToolStripMenuItem.Name = "urunİşlemleriToolStripMenuItem";
            this.urunİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.urunİşlemleriToolStripMenuItem.Text = "Urun İşlemleri";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.urunİşlemleriToolStripMenuItem,
            this.satışModülüToolStripMenuItem,
            this.satışİşlemleriToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // TSSL_kullanici
            // 
            this.TSSL_kullanici.Name = "TSSL_kullanici";
            this.TSSL_kullanici.Size = new System.Drawing.Size(0, 16);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_kullanici});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1244, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 610);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Text = "Teknoloji Marketim";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem TSMI_kullanici;
        private System.Windows.Forms.ToolStripMenuItem TSMI_admin;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Raporlama;
        private System.Windows.Forms.ToolStripMenuItem TSMI_siparisYonetimi;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AlisIslemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_satis;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SatisModul;
        private System.Windows.Forms.ToolStripMenuItem satışModülüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TedarikciForm;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunForm;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Markalar;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriForm;
        private System.Windows.Forms.ToolStripMenuItem urunİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_kullanici;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

