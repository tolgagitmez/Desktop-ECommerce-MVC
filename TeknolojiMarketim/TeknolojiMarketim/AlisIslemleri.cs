using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace TeknolojiMarketim
{
    public partial class AlisIslemleri : Form
    {
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        DataModel dm = new DataModel();
        int alimID;
        public AlisIslemleri()
        {
            InitializeComponent();
            dtp_alim.Visible = false;
            GridDoldur();
        }

        private void AlisIslemleri_Load(object sender, EventArgs e)
        {
            cb_urunadi.ValueMember = "ID";
            cb_urunadi.DisplayMember = "UrunAdi";
            cb_urunadi.DataSource = db.Urunlers.ToList();
            cb_urunadi.Text = "Seçiniz...";
            GridDoldur();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Alimlar a = new Alimlar();
            a.Urun_ID = Convert.ToInt32(cb_urunadi.SelectedValue);
            a.Adet = Convert.ToInt32(nu_adet.Value);
            a.AlisFiyat = Convert.ToInt32(nu_alisFiyat.Value);
            a.Tarih = DateTime.Now;

            try
            {
                db.Alimlars.Add(a);
                db.SaveChanges();
                GridDoldur();
                Temizle();
                MessageBox.Show($"Ürün alımı {a.ID} id ile eklenmiştir");
            }
            catch
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        public void GridDoldur()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Name = "Ürün";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Name = "Talep Miktarı";
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Name = "Alış Fiyatı";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Name = "Tarih";
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Name = "Stok Miktarı";
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].Name = "Toplam Maliyet";
            dataGridView1.Columns[6].Width = 100;



            List<AlimlarAdo> s = dm.AlisListele();
            foreach (AlimlarAdo item in s)
            {
                ArrayList row = new ArrayList();
                row.Add(item.ID);
                row.Add(item.UrunAdi);
                row.Add(item.Adet);
                row.Add(item.AlisFiyat + "₺");
                row.Add(item.Tarih);
                row.Add(item.StokMiktari);
                row.Add(item.Adet * item.AlisFiyat + "₺");

                dataGridView1.Rows.Add(row.ToArray());
            }
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
                    alimID = Convert.ToInt32(dataGridView1.Rows[tiklananSatir].Cells[0].Value);

                }
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cb_urunadi.SelectedValue.ToString()))
            {
                Alimlar a = db.Alimlars.Find(alimID);

                a.Urun_ID = Convert.ToInt32(cb_urunadi.SelectedValue);
                a.Adet = Convert.ToInt32(nu_adet.Value);
                a.AlisFiyat = nu_alisFiyat.Value;
                a.Tarih = dtp_alim.Value;
                db.Alimlars.AddOrUpdate(a);
                db.SaveChanges();
                Temizle();
                GridDoldur();
                MessageBox.Show(alimID + " ID'li Talep Edilen Ürün Güncellendi", "Başarılı");
            }
            else
            {
                MessageBox.Show("Talep Edilen Ürün Adı Boş Bırakılmamalıdır", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            Alimlar alimlar = db.Alimlars.Find(alimID);

            if (MessageBox.Show(alimID + " ID'li Talep Edilen Ürün Silinecektir. Devam etmek istiyor musunuz?", "Veri Silinecek", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                db.Alimlars.Remove(alimlar);
                db.SaveChanges();


                GridDoldur();
                MessageBox.Show(alimID + " ID'li Talep Edilen Ürün Silinmiştir", "Başarılı");

            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi", "Bilgi");
            }
        }

        private void TSMI_guncelle_Click(object sender, EventArgs e)
        {
            Alimlar a = db.Alimlars.Find(alimID);
            if (a != null)
            {
                cb_urunadi.SelectedValue = a.Urun_ID;
                nu_adet.Value = a.Adet.Value;
                nu_alisFiyat.Value = a.AlisFiyat.Value;
                dtp_alim.Value = a.Tarih.Value;

                dtp_alim.Visible = true;
                btn_ekle.Visible = false;
                btn_guncelle.Visible = true;
            }
        }

        private void Temizle()
        {
            cb_urunadi.DataSource = db.Urunlers.ToList();
            cb_urunadi.Text = "Seçiniz...";
            nu_adet.Value = 0;
            nu_alisFiyat.Value = 0;
            dtp_alim.Visible = false;
            btn_guncelle.Visible = false;
            btn_ekle.Visible = true;
            GridDoldur();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
