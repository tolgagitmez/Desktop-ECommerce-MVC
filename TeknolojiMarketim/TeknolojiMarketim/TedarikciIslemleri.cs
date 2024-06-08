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

namespace TeknolojiMarketim
{
    public partial class TedarikciIslemleri : Form
    {
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        int tedarikciID;
        public TedarikciIslemleri()
        {
            InitializeComponent();
            GridDoldur();
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            GridDoldur();
        }

        public void GridDoldur()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "Tedarikçi No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Name = "Firma Adı";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Name = "Firma Ünvanı";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Name = "Sorumlu";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Name = "Şehir";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Name = "İlçe";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Name = "Adres";
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Name = "Telefon";
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Name = "E-Mail";
            dataGridView1.Columns[8].Width = 100;
            dataGridView1.Columns[9].Name = "Durum";
            dataGridView1.Columns[9].Width = 100;


            List<Tedarikciler> teds = db.Tedarikcilers.ToList();
            foreach (Tedarikciler item in teds)
            {
                ArrayList row = new ArrayList();
                row.Add(item.ID);
                row.Add(item.FirmaIsim);
                row.Add(item.TicariUnvan);
                row.Add(item.Sorumlu);
                if (item != null && item.Sehirler != null)
                {
                    row.Add(item.Sehirler.Isim);
                }
                else
                {
                    row.Add("Belirli bir değer yok");
                }
                if (item != null && item.Ilceler != null)
                {
                    row.Add(item.Ilceler.Isim);
                }
                else
                {
                    row.Add("Belirli bir değer yok");
                }
                row.Add(item.Adres);
                row.Add(item.Telefon);
                row.Add(item.MailAdresi);
                row.Add(item.IsActive == true ? "Aktif" : "Pasif");
                dataGridView1.Rows.Add(row.ToArray());
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Tedarikciler ted = new Tedarikciler();
            ted.FirmaIsim = tb_firmaAdi.Text;
            ted.TicariUnvan = tb_firmaUnvani.Text;
            ted.Sorumlu = tb_sorumlu.Text;
            ted.Sehir_ID = Convert.ToInt32(cb_sehir.SelectedValue.ToString());
            ted.Ilce_ID = Convert.ToInt32(cb_ilce.SelectedValue.ToString());
            ted.Adres = tb_adres.Text;
            ted.Telefon = tb_telefon.Text;
            ted.MailAdresi = tb_mail.Text;
            ted.IsActive = (bool)IsActive.Checked;
            ted.IsDeleted = false;
            db.Tedarikcilers.Add(ted);
            try
            {
                db.SaveChanges();
                GridDoldur();
                MessageBox.Show("Tedarikçi " + ted.ID + " ile başarıyla eklenmiştir");
            }
            catch
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void cb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenid = Convert.ToInt32(cb_sehir.SelectedValue.ToString());
            cb_ilce.DataSource = db.Ilcelers.Where(i => secilenid == i.Sehir_ID).ToList();
        }

        private void TedarikciIslemleri_Load(object sender, EventArgs e)
        {
            cb_sehir.DisplayMember = "Isim";
            cb_sehir.ValueMember = "ID";
            cb_sehir.DataSource = db.Sehirlers.ToList();
            cb_sehir.Text = "Seçiniz...";
            cb_ilce.DisplayMember = "Isim";
            cb_ilce.ValueMember = "ID";
            cb_ilce.Text = "Seçiniz...";

            GridDoldur();
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
                    tedarikciID = Convert.ToInt32(dataGridView1.Rows[tiklananSatir].Cells[0].Value);

                }
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_firmaAdi.Text))
            {
                Tedarikciler ted = new Tedarikciler();
                ted.ID = Convert.ToInt32(tb_tedarikciID.Text);
                ted.FirmaIsim = tb_firmaAdi.Text;
                ted.TicariUnvan = tb_firmaUnvani.Text;
                ted.Sorumlu = tb_sorumlu.Text;
                ted.Sehir_ID = Convert.ToInt32(cb_sehir.SelectedValue.ToString());
                ted.Ilce_ID = Convert.ToInt32(cb_ilce.SelectedValue.ToString());
                ted.Adres = tb_adres.Text;
                ted.Telefon = tb_telefon.Text;
                ted.MailAdresi = tb_mail.Text;
                ted.IsActive = (bool)IsActive.Checked;
                ted.IsDeleted = false;
                db.Tedarikcilers.AddOrUpdate(ted);
                db.SaveChanges();
                Temizle();
                GridDoldur();
                MessageBox.Show(tedarikciID + " ID'li Tedarikçi Güncellendi", "Başarılı");
            }
            else
            {
                MessageBox.Show("Kategori adı boş bırakılmamalıdır", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            tb_tedarikciID.Text = tb_firmaAdi.Text = tb_firmaUnvani.Text = tb_sorumlu.Text = tb_adres.Text = tb_telefon.Text = tb_mail.Text = "";
            cb_sehir.DisplayMember = "Isim";
            cb_sehir.ValueMember = "ID";
            cb_sehir.DataSource = db.Sehirlers.ToList();
            cb_sehir.Text = "Seçiniz...";
            cb_ilce.DisplayMember = "Isim";
            cb_ilce.ValueMember = "ID";
            cb_ilce.Text = "Seçiniz...";
            IsActive.Checked = false;
            btn_guncelle.Visible = false;
            btn_ekle.Visible = true;
        }

        private void TSMI_guncelle_Click(object sender, EventArgs e)
        {
            if (tedarikciID != 0)
            {
                Tedarikciler ted = db.Tedarikcilers.Find(tedarikciID);
                tb_tedarikciID.Text = ted.ID.ToString();
                tb_firmaAdi.Text = ted.FirmaIsim;
                tb_firmaUnvani.Text = ted.TicariUnvan;
                tb_sorumlu.Text = ted.Sorumlu;
                if (ted.Sehirler == null)
                {
                    cb_sehir.DataSource = db.Sehirlers.ToList();
                }
                else
                {
                    cb_sehir.SelectedValue = ted.Sehir_ID;
                }
                if (ted.Ilceler == null)
                {
                    int secilenid = Convert.ToInt32(cb_sehir.SelectedValue.ToString());
                    cb_ilce.DataSource = db.Ilcelers.Where(i => secilenid == i.Sehir_ID).ToList();
                }
                else
                {
                    cb_ilce.SelectedValue = ted.Ilce_ID;
                }
                tb_adres.Text = ted.Adres;
                tb_telefon.Text = ted.Telefon;
                tb_mail.Text = ted.MailAdresi;
                IsActive.Checked = (bool)ted.IsActive;
                btn_guncelle.Visible = true;
                btn_ekle.Visible = false;



            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            Tedarikciler teds = db.Tedarikcilers.Find(tedarikciID);


            if (MessageBox.Show(tedarikciID + " ID'li Tedarikçi Silinecektir. Devam etmek istiyor musunuz?", "Veri Silinecek", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                db.Tedarikcilers.Remove(teds);
                db.SaveChanges();


                GridDoldur();
                MessageBox.Show(tedarikciID + " ID'li Tedarikçi Silinmiştir", "Başarılı");

            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi", "Bilgi");
            }
        }
    }
}
