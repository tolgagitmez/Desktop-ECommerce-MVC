using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknolojiMarketim
{
    public partial class SatisModulu : Form
    {

        SatisDetaylar degisecek = new SatisDetaylar();
        SatisDetaylar sd = new SatisDetaylar();
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        List<SatisDetaylar> satilacaklar = new List<SatisDetaylar>();

        public SatisModulu()
        {
            InitializeComponent();
        }

        private void Lbl_UrunAd_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            HizliUrun hu = lbl.Parent as HizliUrun;
            HizliEkle(hu.id);
        }

        private void Pb_resim_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            HizliUrun hu = pb.Parent as HizliUrun;
            HizliEkle(hu.id);
        }

        private void Hu_Click(object sender, EventArgs e)
        {
            HizliUrun hu = sender as HizliUrun;
            HizliEkle(hu.id);
        }

        private void HizliEkle(int id)
        {
            Urunler u = db.Urunlers.Find(id);
            tb_urunFiyat.Text = u.BirimFiyat.ToString();
            bool varmi = false;
            foreach (SatisDetaylar item in satilacaklar)
            {
                if (item.Urun_ID == u.ID)
                {
                    item.Adet += Convert.ToInt32(tb_Adet.Text);
                    varmi = true;
                    tb_Adet.Text = "1";
                }
            }
            if (varmi == false)
            {
                SatisDetaylar sd = new SatisDetaylar();
                sd.Adet = 0;
                sd.Urunler = u;
                sd.Adet += Convert.ToInt32(tb_Adet.Text);
                sd.Urun_ID = u.ID;
                sd.Fiyat = u.BirimFiyat;
                satilacaklar.Add(sd);
            }
            GridDoldur();
        }

        private void GridDoldur()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Barkod";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Name = "Ürün Adı";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Name = "Fiyat";
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Name = "Adet";
            dataGridView1.Columns[3].Width = 60;

            foreach (SatisDetaylar item in satilacaklar)
            {
                ArrayList row = new ArrayList();
                row.Add(item.Urunler.BarkodNo);
                row.Add(item.Urunler.UrunAdi);
                row.Add(item.Urunler.BirimFiyat);
                row.Add(item.Adet);
                dataGridView1.Rows.Add(row.ToArray());
            }

            tb_satisToplam.Text = satilacaklar.Sum(x => x.Adet * x.Urunler.BirimFiyat).ToString();
        }

        private void tb_barkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Urunler u = db.Urunlers.FirstOrDefault(x => x.BarkodNo == tb_barkod.Text);
                if (u != null)
                {
                    tb_urunFiyat.Text = u.BirimFiyat.ToString();
                    bool varmi = false;
                    foreach (SatisDetaylar item in satilacaklar)
                    {
                        if (item.Urun_ID == u.ID)
                        {
                            item.Adet += Convert.ToInt32(tb_Adet.Text);
                            varmi = true;
                        }
                    }
                    if (varmi == false)
                    {
                        SatisDetaylar sd = new SatisDetaylar();
                        sd.Adet = 0;
                        sd.Urunler = u;
                        sd.Adet += 1;
                        sd.Urun_ID = u.ID;
                        sd.Fiyat = u.BirimFiyat;
                        satilacaklar.Add(sd);
                    }
                    GridDoldur();
                    tb_Adet.Text = "1";
                }
                else
                {
                    MessageBox.Show("Urun Bulunamadı. Barkod Tanımsız", "Tanımsız Ürün", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tb_barkod.Clear();
            }
        }

        private void btn_nakit_Click(object sender, EventArgs e)
        {
            try
            {
                if (satilacaklar != null && satilacaklar.Any())
                {
                    Satislar satis = new Satislar();
                    satis.Kasiyer_ID = Helpers.GirisYapanYonetici.ID;
                    satis.Tarih = DateTime.Now;
                    satis.FaturaNo = Guid.NewGuid().ToString().Substring(0, 10);
                    satis.KrediKarti = false;
                    db.Satislars.Add(satis);
                    db.SaveChanges();

                    foreach (SatisDetaylar item in satilacaklar)
                    {
                        item.Satis_ID = satis.ID;
                        db.SatisDetaylars.Add(item);
                    }
                    db.SaveChanges();
                    MessageBox.Show("Satış Tamamlandı", "Satış Kapatıldı");

                    dataGridView1.Rows.Clear();
                    tb_satisToplam.Text = "0,00";
                    tb_urunFiyat.Text = "0,00";
                    satilacaklar.Clear();
                }
                else
                {
                    MessageBox.Show("Ürün Giriniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış tamamlanırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int tiklananSatir = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (tiklananSatir != -1)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[tiklananSatir].Selected = true;
                    sd = satilacaklar.FirstOrDefault(x => x.Urunler.BarkodNo == dataGridView1.Rows[tiklananSatir].Cells[0].Value.ToString());
                    degisecek = sd;
                }
            }
        }

        private void btn_urunDuzenle_Click(object sender, EventArgs e)
        {
            if (degisecek != null)
            {
                satilacaklar.Remove(sd);
                degisecek.Adet = Convert.ToInt32(tb_Adet.Text);
                satilacaklar.Add(degisecek);
                GridDoldur();
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Değiştirilecek Ürünü Seçiniz");
            }
        }

        private void btn_urunSil_Click(object sender, EventArgs e)
        {
            if (sd != null)
            {
                satilacaklar.Remove(sd);
                GridDoldur();
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Silinecek Ürünü Seçiniz");
            }
        }

        private void btn_arttir_Click(object sender, EventArgs e)
        {
            int urunAdet = Convert.ToInt32(tb_Adet.Text);
            urunAdet++;
            tb_Adet.Text = urunAdet.ToString();
        }

        private void btn_azalt_Click(object sender, EventArgs e)
        {
            int urunAdet = Convert.ToInt32(tb_Adet.Text);
            urunAdet--;
            tb_Adet.Text = urunAdet.ToString();
        }

        private void btn_stokbul_Click(object sender, EventArgs e)
        {
            if (sd != null)
            {
                MessageBox.Show($"Stok Miktarı: {sd.Urunler.StokMiktari.ToString()}");
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Stoğu Bulunacak Ürünü Seçiniz");
            }
        }


        private void btn_sayisil_Click(object sender, EventArgs e)
        {
            tb_barkod.Text = tb_barkod.Text.Substring(0, tb_barkod.TextLength - 1);
            if (tb_barkod.Text == "")
            {
                tb_barkod.Text = "0";
            }
        }

        private void btn_taksitliSatis_Click(object sender, EventArgs e)
        {
            if (satilacaklar != null && satilacaklar.Any())
            {
                ToplamSatisTutari.tutar = Convert.ToDecimal(tb_satisToplam.Text);
                TaksitIslemleri tkst = new TaksitIslemleri();
                tkst.ShowDialog();
                int deger = TaksitValueClass.value;
                if (deger >= 2 && deger <= 12)
                {

                    Satislar satis = new Satislar();
                    satis.Kasiyer_ID = Helpers.GirisYapanYonetici.ID;
                    satis.Tarih = DateTime.Now;
                    satis.FaturaNo = Guid.NewGuid().ToString().Substring(0, 10);
                    satis.KrediKarti = true;
                    db.Satislars.Add(satis);
                    TaksitliSatislar ts = new TaksitliSatislar();
                    ts.ToplamTaksitSayisi = deger;
                    db.TaksitliSatislars.Add(ts);
                    TaksitDetaylar td = new TaksitDetaylar();
                    td.SatisID = ts.SatisID;
                    td.SatislarID = satis.ID;
                    td.TaksitTarihi = DateTime.Now;
                    if (deger == 2)
                    {
                        decimal s = Convert.ToDecimal(tb_satisToplam.Text.ToString());
                        decimal yuzde = s * 1.05m;
                        decimal taksit = yuzde / deger;
                        td.TaksitMiktari = taksit;
                    }
                    if (deger == 3)
                    {
                        decimal s = Convert.ToDecimal(tb_satisToplam.Text.ToString());
                        decimal yuzde = s * 1.08m;
                        decimal taksit = yuzde / deger;
                        td.TaksitMiktari = taksit;
                    }
                    if (deger == 4)
                    {
                        decimal s = Convert.ToDecimal(tb_satisToplam.Text.ToString());
                        decimal yuzde = s * 1.10m;
                        decimal taksit = yuzde / deger;
                        td.TaksitMiktari = taksit;
                    }
                    if (deger == 5)
                    {
                        decimal s = Convert.ToDecimal(tb_satisToplam.Text.ToString());
                        decimal yuzde = s * 1.13m;
                        decimal taksit = yuzde / deger;
                        td.TaksitMiktari = taksit;
                    }
                    if (deger == 6)
                    {
                        decimal s = Convert.ToDecimal(tb_satisToplam.Text.ToString());
                        decimal yuzde = s * 1.15m;
                        decimal taksit = yuzde / deger;
                        td.TaksitMiktari = taksit;
                    }
                    if (deger == 7)
                    {
                        decimal s = Convert.ToDecimal(tb_satisToplam.Text.ToString());
                        decimal yuzde = s * 1.20m;
                        decimal taksit = yuzde / deger;
                        td.TaksitMiktari = taksit;
                    }
                    if (deger == 8)
                    {
                        decimal s = Convert.ToDecimal(tb_satisToplam.Text.ToString());
                        decimal yuzde = s * 1.30m;
                        decimal taksit = yuzde / deger;
                        td.TaksitMiktari = taksit;
                    }
                    if (deger == 9)
                    {
                        decimal s = Convert.ToDecimal(tb_satisToplam.Text.ToString());
                        decimal yuzde = s * 1.40m;
                        decimal taksit = yuzde / deger;
                        td.TaksitMiktari = taksit;
                    }
                    if (deger == 10)
                    {
                        decimal s = Convert.ToDecimal(tb_satisToplam.Text.ToString());
                        decimal yuzde = s * 1.50m;
                        decimal taksit = yuzde / deger;
                        td.TaksitMiktari = taksit;
                    }
                    if (deger == 11)
                    {
                        decimal s = Convert.ToDecimal(tb_satisToplam.Text.ToString());
                        decimal yuzde = s * 1.65m;
                        decimal taksit = yuzde / deger;
                        td.TaksitMiktari = taksit;
                    }
                    if (deger == 12)
                    {
                        decimal s = Convert.ToDecimal(tb_satisToplam.Text.ToString());
                        decimal yuzde = s * 1.75m;
                        decimal taksit = yuzde / deger;
                        td.TaksitMiktari = taksit;
                    }
                    td.OdendiMi = false;
                    db.TaksitDetaylars.Add(td);
                    db.SaveChanges();
                    List<SatisDetaylar> list = satilacaklar.ToList();
                    foreach (SatisDetaylar item in list)
                    {

                        item.Satis_ID = satis.ID;
                        db.SatisDetaylars.Add(item);
                    }
                    db.SaveChanges();
                    satilacaklar.Clear();
                    dataGridView1.Rows.Clear();
                    tb_satisToplam.Text = "0,00";
                    tb_urunFiyat.Text = "0,00";
                    MessageBox.Show("Satış Tamamlandı", "Satış Kapatıldı");
                }
            }
            else
            {
                MessageBox.Show("Ürün Giriniz");
            }
        }

        private void btn_tekcekim_Click(object sender, EventArgs e)
        {
            try
            {
                if (satilacaklar != null && satilacaklar.Any())
                {
                    Satislar satis = new Satislar();
                    satis.Kasiyer_ID = Helpers.GirisYapanYonetici.ID;
                    satis.Tarih = DateTime.Now;
                    satis.FaturaNo = Guid.NewGuid().ToString().Substring(0, 10);
                    satis.KrediKarti = true;
                    db.Satislars.Add(satis);
                    db.SaveChanges();

                    foreach (SatisDetaylar item in satilacaklar)
                    {
                        item.Satis_ID = satis.ID;
                        db.SatisDetaylars.Add(item);
                    }
                    db.SaveChanges();
                    MessageBox.Show("Satış Tamamlandı", "Satış Kapatıldı");

                    dataGridView1.Rows.Clear();
                    tb_satisToplam.Text = "0,00";
                    tb_urunFiyat.Text = "0,00";
                    satilacaklar.Clear();
                }
                else
                {
                    MessageBox.Show("Ürün Giriniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış tamamlanırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
