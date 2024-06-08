namespace TeknolojiMarketim
{
    partial class SatisModulu
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
            this.tb_barkod = new System.Windows.Forms.TextBox();
            this.btn_arttir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_urunFiyat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_satisToplam = new System.Windows.Forms.TextBox();
            this.btn_taksitliSatis = new System.Windows.Forms.Button();
            this.btn_tekcekim = new System.Windows.Forms.Button();
            this.btn_nakit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_urunSil = new System.Windows.Forms.Button();
            this.btn_urunDuzenle = new System.Windows.Forms.Button();
            this.btn_azalt = new System.Windows.Forms.Button();
            this.tb_Adet = new System.Windows.Forms.TextBox();
            this.btn_stokbul = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_barkod
            // 
            this.tb_barkod.BackColor = System.Drawing.SystemColors.Info;
            this.tb_barkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_barkod.ForeColor = System.Drawing.Color.Aquamarine;
            this.tb_barkod.Location = new System.Drawing.Point(251, 3);
            this.tb_barkod.Margin = new System.Windows.Forms.Padding(4);
            this.tb_barkod.Name = "tb_barkod";
            this.tb_barkod.Size = new System.Drawing.Size(425, 45);
            this.tb_barkod.TabIndex = 20;
            this.tb_barkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_barkod_KeyDown);
            // 
            // btn_arttir
            // 
            this.btn_arttir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arttir.Location = new System.Drawing.Point(301, 173);
            this.btn_arttir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_arttir.Name = "btn_arttir";
            this.btn_arttir.Size = new System.Drawing.Size(77, 54);
            this.btn_arttir.TabIndex = 25;
            this.btn_arttir.Text = "+";
            this.btn_arttir.UseVisualStyleBackColor = true;
            this.btn_arttir.Click += new System.EventHandler(this.btn_arttir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(245, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "₺";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(11, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Satış Toplam";
            // 
            // tb_urunFiyat
            // 
            this.tb_urunFiyat.BackColor = System.Drawing.SystemColors.Window;
            this.tb_urunFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_urunFiyat.ForeColor = System.Drawing.Color.Black;
            this.tb_urunFiyat.Location = new System.Drawing.Point(16, 50);
            this.tb_urunFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.tb_urunFiyat.Name = "tb_urunFiyat";
            this.tb_urunFiyat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_urunFiyat.Size = new System.Drawing.Size(220, 36);
            this.tb_urunFiyat.TabIndex = 1;
            this.tb_urunFiyat.Text = "0,00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_arttir);
            this.panel1.Controls.Add(this.tb_satisToplam);
            this.panel1.Controls.Add(this.btn_taksitliSatis);
            this.panel1.Controls.Add(this.btn_urunSil);
            this.panel1.Controls.Add(this.btn_tekcekim);
            this.panel1.Controls.Add(this.btn_urunDuzenle);
            this.panel1.Controls.Add(this.btn_stokbul);
            this.panel1.Controls.Add(this.btn_nakit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_azalt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_Adet);
            this.panel1.Controls.Add(this.tb_urunFiyat);
            this.panel1.Location = new System.Drawing.Point(3, 491);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 242);
            this.panel1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(247, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 39);
            this.label7.TabIndex = 4;
            this.label7.Text = "₺";
            // 
            // tb_satisToplam
            // 
            this.tb_satisToplam.BackColor = System.Drawing.SystemColors.Window;
            this.tb_satisToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_satisToplam.ForeColor = System.Drawing.Color.Black;
            this.tb_satisToplam.Location = new System.Drawing.Point(17, 132);
            this.tb_satisToplam.Margin = new System.Windows.Forms.Padding(4);
            this.tb_satisToplam.Name = "tb_satisToplam";
            this.tb_satisToplam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_satisToplam.Size = new System.Drawing.Size(220, 36);
            this.tb_satisToplam.TabIndex = 5;
            this.tb_satisToplam.Text = "0,00";
            // 
            // btn_taksitliSatis
            // 
            this.btn_taksitliSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_taksitliSatis.Location = new System.Drawing.Point(289, 93);
            this.btn_taksitliSatis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_taksitliSatis.Name = "btn_taksitliSatis";
            this.btn_taksitliSatis.Size = new System.Drawing.Size(178, 28);
            this.btn_taksitliSatis.TabIndex = 3;
            this.btn_taksitliSatis.Text = "TAKSİTLİ SATIŞ";
            this.btn_taksitliSatis.UseVisualStyleBackColor = true;
            this.btn_taksitliSatis.Click += new System.EventHandler(this.btn_taksitliSatis_Click);
            // 
            // btn_tekcekim
            // 
            this.btn_tekcekim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tekcekim.Location = new System.Drawing.Point(289, 53);
            this.btn_tekcekim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tekcekim.Name = "btn_tekcekim";
            this.btn_tekcekim.Size = new System.Drawing.Size(178, 32);
            this.btn_tekcekim.TabIndex = 3;
            this.btn_tekcekim.Text = "TEK ÇEKİM";
            this.btn_tekcekim.UseVisualStyleBackColor = true;
            this.btn_tekcekim.Click += new System.EventHandler(this.btn_tekcekim_Click);
            // 
            // btn_nakit
            // 
            this.btn_nakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_nakit.Location = new System.Drawing.Point(289, 16);
            this.btn_nakit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nakit.Name = "btn_nakit";
            this.btn_nakit.Size = new System.Drawing.Size(178, 32);
            this.btn_nakit.TabIndex = 3;
            this.btn_nakit.Text = "NAKİT";
            this.btn_nakit.UseVisualStyleBackColor = true;
            this.btn_nakit.Click += new System.EventHandler(this.btn_nakit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Fiyat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(673, 430);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-5, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "BARKOD NO:";
            // 
            // btn_urunSil
            // 
            this.btn_urunSil.BackColor = System.Drawing.Color.Red;
            this.btn_urunSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urunSil.ForeColor = System.Drawing.Color.Snow;
            this.btn_urunSil.Location = new System.Drawing.Point(475, 66);
            this.btn_urunSil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_urunSil.Name = "btn_urunSil";
            this.btn_urunSil.Size = new System.Drawing.Size(198, 42);
            this.btn_urunSil.TabIndex = 26;
            this.btn_urunSil.Text = "Ürün Sil";
            this.btn_urunSil.UseVisualStyleBackColor = false;
            this.btn_urunSil.Click += new System.EventHandler(this.btn_urunSil_Click);
            // 
            // btn_urunDuzenle
            // 
            this.btn_urunDuzenle.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_urunDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urunDuzenle.ForeColor = System.Drawing.Color.Lavender;
            this.btn_urunDuzenle.Location = new System.Drawing.Point(475, 16);
            this.btn_urunDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_urunDuzenle.Name = "btn_urunDuzenle";
            this.btn_urunDuzenle.Size = new System.Drawing.Size(198, 42);
            this.btn_urunDuzenle.TabIndex = 27;
            this.btn_urunDuzenle.Text = "Ürün Düzenle";
            this.btn_urunDuzenle.UseVisualStyleBackColor = false;
            this.btn_urunDuzenle.Click += new System.EventHandler(this.btn_urunDuzenle_Click);
            // 
            // btn_azalt
            // 
            this.btn_azalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_azalt.Location = new System.Drawing.Point(381, 173);
            this.btn_azalt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_azalt.Name = "btn_azalt";
            this.btn_azalt.Size = new System.Drawing.Size(77, 54);
            this.btn_azalt.TabIndex = 24;
            this.btn_azalt.Text = "-";
            this.btn_azalt.UseVisualStyleBackColor = true;
            this.btn_azalt.Click += new System.EventHandler(this.btn_azalt_Click);
            // 
            // tb_Adet
            // 
            this.tb_Adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Adet.Location = new System.Drawing.Point(291, 129);
            this.tb_Adet.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Adet.Name = "tb_Adet";
            this.tb_Adet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_Adet.Size = new System.Drawing.Size(176, 36);
            this.tb_Adet.TabIndex = 23;
            this.tb_Adet.Text = "1";
            // 
            // btn_stokbul
            // 
            this.btn_stokbul.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_stokbul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_stokbul.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_stokbul.Location = new System.Drawing.Point(475, 116);
            this.btn_stokbul.Margin = new System.Windows.Forms.Padding(4);
            this.btn_stokbul.Name = "btn_stokbul";
            this.btn_stokbul.Size = new System.Drawing.Size(198, 49);
            this.btn_stokbul.TabIndex = 28;
            this.btn_stokbul.Text = "Stok Bul";
            this.btn_stokbul.UseVisualStyleBackColor = false;
            this.btn_stokbul.Click += new System.EventHandler(this.btn_stokbul_Click);
            // 
            // SatisModulu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 730);
            this.Controls.Add(this.tb_barkod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "SatisModulu";
            this.Text = "SatisModulu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_barkod;
        private System.Windows.Forms.Button btn_arttir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_urunFiyat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_satisToplam;
        private System.Windows.Forms.Button btn_taksitliSatis;
        private System.Windows.Forms.Button btn_tekcekim;
        private System.Windows.Forms.Button btn_nakit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_urunSil;
        private System.Windows.Forms.Button btn_urunDuzenle;
        private System.Windows.Forms.Button btn_azalt;
        private System.Windows.Forms.TextBox tb_Adet;
        private System.Windows.Forms.Button btn_stokbul;
    }
}