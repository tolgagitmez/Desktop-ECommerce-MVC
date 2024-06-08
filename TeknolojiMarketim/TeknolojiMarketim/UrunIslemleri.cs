using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknolojiMarketim
{
    public partial class UrunIslemleri : Form
    {
        private ProductService productService;
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        string imagePath;
        int urunID;
        public UrunIslemleri()
        {
            InitializeComponent();
            openFileDialog1.Filter = "jpeg Resmi|*.jpg|png Resmi|*.png";
            GridDoldur();
            productService = new ProductService();
        }

        private void UrunIslemleri_Load(object sender, EventArgs e)
        {
            cb_kategori.ValueMember = "ID";
            cb_kategori.DisplayMember = "Isim";
            cb_kategori.DataSource = db.Kategorilers.Where(x => x.IsDeleted == false).ToList();
            cb_kategori.Text = "Seçiniz...";


            cb_marka.ValueMember = "ID";
            cb_marka.DisplayMember = "Isim";
            cb_marka.DataSource = db.Markalars.Where(x => x.IsDeleted == false).ToList();
            cb_marka.Text = "Seçiniz...";

            cb_Tedarikci.ValueMember = "ID";
            cb_Tedarikci.DisplayMember = "FirmaIsim";
            cb_Tedarikci.DataSource = db.Tedarikcilers.Where(x => x.IsDeleted == false).ToList();
            cb_Tedarikci.Text = "Seçiniz...";

            //dataGridView1.DataSource = db.urunlerviews.ToList();
            GridDoldur();
        }

        private void btn_resimSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = imagePath;
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.BarkodNo = tb_barkod.Text;
            u.BirimFiyat = nu_fiyat.Value;
            u.GuvenlikStogu = Convert.ToInt32(nu_GuvenlikStok.Value)-50;
            u.IsActive = cb_aktif.Checked;
            u.IsDeleted = false;
            u.Kategori_ID = Convert.ToInt32(cb_kategori.SelectedValue);
            u.Marka_ID = Convert.ToInt32(cb_marka.SelectedValue);
            if (!string.IsNullOrEmpty(imagePath))
            {
                FileInfo fi = new FileInfo(imagePath);
                string isim = Guid.NewGuid().ToString() + fi.Extension;
                fi.CopyTo("../../UrunResim/" + isim);
                u.Resim = isim;
            }
            else
            {
                u.Resim = "none.gif";
            }
            u.StokMiktari = Convert.ToInt32(nu_GuvenlikStok.Value);
            u.Tedarikci_ID = Convert.ToInt32(cb_Tedarikci.SelectedValue);
            u.UrunAdi = tb_urunAdi.Text;
            try
            {
                db.Urunlers.Add(u);
                db.SaveChanges();
                GridDoldur();
                Temizle();
                MessageBox.Show($"Ürün {u.ID} id ile eklenmiştir");
            }
            catch
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        public void GridDoldur()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Name = "Kategori";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Name = "Marka";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Name = "Tedarikçi";
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Name = "Barkod No";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Name = "Ürün Adı";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Name = "Ürün Fiyatı";
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Name = "Güvenlik Stoğu";
            dataGridView1.Columns[7].Width = 60;
            dataGridView1.Columns[8].Name = "Resim";
            dataGridView1.Columns[8].Width = 100;
            dataGridView1.Columns[9].Name = "Ürün Durum";
            dataGridView1.Columns[9].Width = 60;


            List<Urunler> uruns = db.Urunlers.ToList();
            foreach (Urunler item in uruns)
            {
                ArrayList row = new ArrayList();
                row.Add(item.ID);
                row.Add(item.Kategoriler.Isim);
                row.Add(item.Markalar.Isim);
                row.Add(item.Tedarikciler.FirmaIsim);
                row.Add(item.BarkodNo);
                row.Add(item.UrunAdi);
                row.Add(item.BirimFiyat);
                row.Add(item.GuvenlikStogu);
                row.Add(item.Resim);
                row.Add((bool)item.IsActive ? "Aktif" : "Pasif");

                dataGridView1.Rows.Add(row.ToArray());
            }
        }

        private void btn_kat_ekle_Click(object sender, EventArgs e)
        {
            HızlıKategoriEkle hke = new HızlıKategoriEkle();
            hke.Show();
        }

        private void btn_marka_ekle_Click(object sender, EventArgs e)
        {
            HızlıMarkaEkle hme = new HızlıMarkaEkle();
            hme.Show();
        }

        private void btn_ted_ekle_Click(object sender, EventArgs e)
        {
            HızlıTedarikciEkle hte = new HızlıTedarikciEkle();
            hte.Show();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int tiklananSatir = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (tiklananSatir != -1)
                {
                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[tiklananSatir].Selected = true;
                    urunID = Convert.ToInt32(dataGridView1.Rows[tiklananSatir].Cells[0].Value);

                }
            }
        }

        private void TSMI_guncelle_Click(object sender, EventArgs e)
        {
            if (urunID != 0)
            {
                Urunler u = db.Urunlers.Find(urunID);
                if (u.Kategoriler == null)
                {
                    cb_kategori.DataSource = db.Kategorilers.ToList();
                }
                else
                {
                    cb_kategori.SelectedValue = u.Kategori_ID;
                }
                if (u.Markalar == null)
                {

                    cb_marka.DataSource = db.Markalars.ToList();
                }
                else
                {
                    cb_marka.SelectedValue = u.Marka_ID;
                }
                if (u.Tedarikciler == null)
                {

                    cb_Tedarikci.DataSource = db.Tedarikcilers.ToList();
                }
                else
                {
                    cb_Tedarikci.SelectedValue = u.Tedarikci_ID;
                }
                tb_barkod.Text = u.BarkodNo;
                tb_urunAdi.Text = u.UrunAdi;
                nu_fiyat.Value = Convert.ToDecimal(u.BirimFiyat);
                nu_GuvenlikStok.Value = Convert.ToDecimal(u.GuvenlikStogu);
                pictureBox1.ImageLocation = "../../UrunResim/" + u.Resim;
                cb_aktif.Checked = (bool)u.IsActive;
                btn_ekle.Visible = false;
                btn_duzenle.Visible = true;
            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            Urunler u = db.Urunlers.Find(urunID);


            if (MessageBox.Show(urunID + " ID'li Ürün Silinecektir. Devam etmek istiyor musunuz?", "Veri Silinecek", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                db.Urunlers.Remove(u);
                db.SaveChanges();


                GridDoldur();
                MessageBox.Show(urunID + " ID'li Ürün Silinmiştir", "Başarılı");

            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi", "Bilgi");
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_urunAdi.Text))
            {

                Urunler u = db.Urunlers.Find(urunID);
                u.ID = u.ID;
                u.Kategori_ID = Convert.ToInt32(cb_kategori.SelectedValue.ToString());
                u.Marka_ID = Convert.ToInt32(cb_marka.SelectedValue.ToString());
                u.Tedarikci_ID = Convert.ToInt32(cb_Tedarikci.SelectedValue.ToString());
                u.BarkodNo = tb_barkod.Text;
                u.UrunAdi = tb_urunAdi.Text;
                u.BirimFiyat = nu_fiyat.Value;
                u.StokMiktari = Convert.ToInt32(nu_GuvenlikStok.Value);
                if (!string.IsNullOrEmpty(imagePath))
                {
                    FileInfo fi = new FileInfo(imagePath);
                    string isim = Guid.NewGuid().ToString() + fi.Extension;
                    fi.CopyTo("../../UrunResim/" + isim);
                    u.Resim = isim;
                }
                else
                {
                    u.Resim = "none.gif";
                }
                u.IsActive = cb_aktif.Checked;
                u.IsDeleted = false;

                db.Urunlers.AddOrUpdate(u);
                db.SaveChanges();
                GridDoldur();
                Temizle();
                MessageBox.Show(urunID + " ID'li Ürün Güncellendi", "Başarılı");
            }
            else
            {
                MessageBox.Show("Ürün adı boş bırakılmamalıdır", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            cb_kategori.DataSource = db.Kategorilers.Where(x => x.IsDeleted == false).ToList();
            cb_kategori.Text = "Seçiniz...";
            cb_marka.DataSource = db.Markalars.Where(x => x.IsDeleted == false).ToList();
            cb_marka.Text = "Seçiniz...";
            cb_Tedarikci.DataSource = db.Tedarikcilers.Where(x => x.IsDeleted == false).ToList();
            cb_Tedarikci.Text = "Seçiniz...";
            tb_barkod.Text = tb_urunAdi.Text = "";
            nu_fiyat.Value = 0;
            nu_GuvenlikStok.Value = 0;
            pictureBox1.ImageLocation = "";
            cb_aktif.Checked = false;
        }

        private void btnExportToXml_Click(object sender, EventArgs e)
        {
            var products = productService.GetProducts();
            string filePath = @"C:\Users\teteg\Masaüstü\proje\TeknoTrendWebApp\TeknoTrendWebApp\Uploads\products.xml";
            productService.SaveProductsToXml(products, filePath);
            MessageBox.Show("Ürünler başarıyla XML dosyasına kaydedildi.");
        }
    }
}
