namespace TeknolojiMarketim
{
    partial class AlisIslemleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nu_alisFiyat = new System.Windows.Forms.NumericUpDown();
            this.nu_adet = new System.Windows.Forms.NumericUpDown();
            this.cb_urunadi = new System.Windows.Forms.ComboBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dtp_alim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_alisFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nu_alisFiyat);
            this.groupBox1.Controls.Add(this.nu_adet);
            this.groupBox1.Controls.Add(this.cb_urunadi);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.dtp_alim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 204);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alış işlemleri";
            // 
            // nu_alisFiyat
            // 
            this.nu_alisFiyat.DecimalPlaces = 2;
            this.nu_alisFiyat.Location = new System.Drawing.Point(111, 136);
            this.nu_alisFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nu_alisFiyat.Name = "nu_alisFiyat";
            this.nu_alisFiyat.Size = new System.Drawing.Size(120, 22);
            this.nu_alisFiyat.TabIndex = 9;
            // 
            // nu_adet
            // 
            this.nu_adet.Location = new System.Drawing.Point(111, 91);
            this.nu_adet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nu_adet.Name = "nu_adet";
            this.nu_adet.Size = new System.Drawing.Size(120, 22);
            this.nu_adet.TabIndex = 8;
            // 
            // cb_urunadi
            // 
            this.cb_urunadi.FormattingEnabled = true;
            this.cb_urunadi.Location = new System.Drawing.Point(111, 43);
            this.cb_urunadi.Name = "cb_urunadi";
            this.cb_urunadi.Size = new System.Drawing.Size(121, 24);
            this.cb_urunadi.TabIndex = 7;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(285, 88);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(110, 23);
            this.btn_temizle.TabIndex = 6;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(285, 59);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(110, 23);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Visible = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(285, 59);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(110, 23);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dtp_alim
            // 
            this.dtp_alim.Location = new System.Drawing.Point(285, 132);
            this.dtp_alim.Name = "dtp_alim";
            this.dtp_alim.Size = new System.Drawing.Size(200, 22);
            this.dtp_alim.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alış Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 216);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_guncelle,
            this.TSMI_sil});
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
            // TSMI_sil
            // 
            this.TSMI_sil.Name = "TSMI_sil";
            this.TSMI_sil.Size = new System.Drawing.Size(135, 24);
            this.TSMI_sil.Text = "Sil";
            this.TSMI_sil.Click += new System.EventHandler(this.TSMI_sil_Click);
            // 
            // AlisIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AlisIslemleri";
            this.Text = "AlisIslemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AlisIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_alisFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nu_alisFiyat;
        private System.Windows.Forms.NumericUpDown nu_adet;
        private System.Windows.Forms.ComboBox cb_urunadi;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DateTimePicker dtp_alim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_guncelle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_sil;
    }
}