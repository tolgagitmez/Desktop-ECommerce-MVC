namespace TeknolojiMarketim
{
    partial class AdminIslemleri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminIslemleri));
            this.TSMI_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.cb_aktif = new System.Windows.Forms.CheckBox();
            this.btn_goster = new System.Windows.Forms.Button();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_soyisim = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.cb_yetki = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSMI_sil
            // 
            this.TSMI_sil.Name = "TSMI_sil";
            this.TSMI_sil.Size = new System.Drawing.Size(135, 24);
            this.TSMI_sil.Text = "Sil";
            this.TSMI_sil.Click += new System.EventHandler(this.TSMI_sil_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(260, 130);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(102, 23);
            this.btn_temizle.TabIndex = 14;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(260, 72);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(102, 23);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(260, 101);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(102, 23);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // cb_aktif
            // 
            this.cb_aktif.AutoSize = true;
            this.cb_aktif.Location = new System.Drawing.Point(241, 34);
            this.cb_aktif.Name = "cb_aktif";
            this.cb_aktif.Size = new System.Drawing.Size(54, 20);
            this.cb_aktif.TabIndex = 11;
            this.cb_aktif.Text = "Aktif";
            this.cb_aktif.UseVisualStyleBackColor = true;
            // 
            // btn_goster
            // 
            this.btn_goster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_goster.BackgroundImage")));
            this.btn_goster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_goster.Location = new System.Drawing.Point(187, 159);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(37, 25);
            this.btn_goster.TabIndex = 10;
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(103, 160);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.PasswordChar = '*';
            this.tb_sifre.Size = new System.Drawing.Size(121, 22);
            this.tb_sifre.TabIndex = 9;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(103, 130);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(121, 22);
            this.tb_id.TabIndex = 8;
            // 
            // tb_soyisim
            // 
            this.tb_soyisim.Location = new System.Drawing.Point(104, 93);
            this.tb_soyisim.Name = "tb_soyisim";
            this.tb_soyisim.Size = new System.Drawing.Size(121, 22);
            this.tb_soyisim.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_sil,
            this.TSMI_guncelle});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // TSMI_guncelle
            // 
            this.TSMI_guncelle.Name = "TSMI_guncelle";
            this.TSMI_guncelle.Size = new System.Drawing.Size(135, 24);
            this.TSMI_guncelle.Text = "Güncelle";
            this.TSMI_guncelle.Click += new System.EventHandler(this.TSMI_guncelle_Click);
            // 
            // dgv_admin
            // 
            this.dgv_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin.Location = new System.Drawing.Point(41, 225);
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.RowHeadersWidth = 51;
            this.dgv_admin.RowTemplate.Height = 24;
            this.dgv_admin.Size = new System.Drawing.Size(465, 213);
            this.dgv_admin.TabIndex = 3;
            this.dgv_admin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_admin_MouseClick);
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(104, 61);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(121, 22);
            this.tb_isim.TabIndex = 6;
            // 
            // cb_yetki
            // 
            this.cb_yetki.FormattingEnabled = true;
            this.cb_yetki.Location = new System.Drawing.Point(104, 32);
            this.cb_yetki.Name = "cb_yetki";
            this.cb_yetki.Size = new System.Drawing.Size(121, 24);
            this.cb_yetki.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyisim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yetki Statüsü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.cb_aktif);
            this.groupBox1.Controls.Add(this.btn_goster);
            this.groupBox1.Controls.Add(this.tb_sifre);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.tb_soyisim);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.cb_yetki);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 207);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin İşlemleri";
            // 
            // AdminIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.dgv_admin);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminIslemleri";
            this.Text = "AdminIslemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminIslemleri_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem TSMI_sil;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.CheckBox cb_aktif;
        private System.Windows.Forms.Button btn_goster;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_soyisim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_guncelle;
        private System.Windows.Forms.DataGridView dgv_admin;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.ComboBox cb_yetki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}