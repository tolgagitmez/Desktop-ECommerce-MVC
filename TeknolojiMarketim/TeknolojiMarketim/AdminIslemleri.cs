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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeknolojiMarketim
{
    public partial class AdminIslemleri : Form
    {
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        int adminID;
        public AdminIslemleri()
        {
            InitializeComponent();
        }

        private void AdminIslemleri_Load(object sender, EventArgs e)
        {
            cb_yetki.ValueMember = "ID";
            cb_yetki.DisplayMember = "Isim";
            cb_yetki.DataSource = db.YoneticiYetkilers.ToList();
            cb_yetki.Text = "Seçiniz...";
            griddoldur();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Yoneticiler yon = new Yoneticiler();
            yon.Yetki_ID = Convert.ToInt32(cb_yetki.SelectedValue);
            yon.Isim = tb_isim.Text;
            yon.Soyisim = tb_soyisim.Text;
            yon.KullaniciAdi = tb_id.Text;
            yon.Sifre = tb_sifre.Text;
            yon.IsActive = cb_aktif.Checked;
            yon.IsDeleted = false;
            try
            {
                db.Yoneticilers.Add(yon);
                db.SaveChanges();
                griddoldur();
                Temizle();
                MessageBox.Show($"Yönetici {adminID} ID ile Eklendi");
            }
            catch
            {

                MessageBox.Show("Hata Oluştu");
            }
        }

        public void griddoldur()
        {
            dgv_admin.Rows.Clear();
            dgv_admin.ColumnCount = 6;
            dgv_admin.Columns[0].Name = "ID";
            dgv_admin.Columns[0].Width = 40;
            dgv_admin.Columns[1].Name = "Statü";
            dgv_admin.Columns[1].Width = 60;
            dgv_admin.Columns[2].Name = "İsim";
            dgv_admin.Columns[2].Width = 60;
            dgv_admin.Columns[3].Name = "Soyisim";
            dgv_admin.Columns[3].Width = 60;
            dgv_admin.Columns[4].Name = "Kullanıcı Adı";
            dgv_admin.Columns[4].Width = 75;
            dgv_admin.Columns[5].Name = "Durum";
            dgv_admin.Columns[5].Width = 40;

            List<Yoneticiler> yoneticilers = db.Yoneticilers.ToList();
            foreach (Yoneticiler yon in yoneticilers)
            {
                ArrayList row = new ArrayList();
                row.Add(yon.ID);
                row.Add(yon.YoneticiYetkiler.Isim);
                row.Add(yon.Isim);
                row.Add(yon.Soyisim);
                row.Add(yon.KullaniciAdi);
                row.Add((bool)yon.IsActive ? "Aktif" : "Pasif");

                dgv_admin.Rows.Add(row.ToArray());
            }
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            if (tb_sifre.PasswordChar == '*')
            {
                tb_sifre.PasswordChar = '\0';
            }
            else
            {
                tb_sifre.PasswordChar = '*';
            }
        }

        private void dgv_admin_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int tiklananSatir = dgv_admin.HitTest(e.X, e.Y).RowIndex;
                if (tiklananSatir != -1)
                {
                    contextMenuStrip1.Show(dgv_admin, new Point(e.X, e.Y));
                    dgv_admin.ClearSelection();
                    dgv_admin.Rows[tiklananSatir].Selected = true;
                    adminID = Convert.ToInt32(dgv_admin.Rows[tiklananSatir].Cells[0].Value);

                }
            }
        }

        private void TSMI_guncelle_Click(object sender, EventArgs e)
        {
            Yoneticiler yon = db.Yoneticilers.Find(adminID);
            if (yon != null)
            {
                cb_yetki.SelectedValue = yon.Yetki_ID;
                tb_isim.Text = yon.Isim;
                tb_soyisim.Text = yon.Soyisim;
                tb_id.Text = yon.KullaniciAdi;
                cb_aktif.Checked = (bool)yon.IsActive;


                btn_ekle.Visible = false;
                btn_guncelle.Visible = true;
            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            Yoneticiler yoneticiler = db.Yoneticilers.Find(adminID);
            if (MessageBox.Show(adminID + " ID'li Yönetici Silinecektir. Devam etmek istiyor musunuz?", "Veri Silinecek", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                db.Yoneticilers.Remove(yoneticiler);
                db.SaveChanges();


                griddoldur();
                MessageBox.Show(adminID + " ID'li Yönetici Silinmiştir", "Başarılı");

            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi", "Bilgi");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cb_yetki.SelectedValue.ToString()))
            {
                Yoneticiler yon = db.Yoneticilers.Find(adminID);
                yon.Yetki_ID = Convert.ToInt32(cb_yetki.SelectedValue);
                yon.Isim = tb_isim.Text;
                yon.Soyisim = tb_soyisim.Text;
                yon.KullaniciAdi = tb_id.Text;
                yon.Sifre = tb_sifre.Text;
                yon.IsActive = cb_aktif.Checked;

                db.Yoneticilers.AddOrUpdate(yon);
                db.SaveChanges();
                Temizle();
                griddoldur();
                MessageBox.Show(adminID + " ID'li Yönetici Güncellendi", "Başarılı");
            }
            else
            {
                MessageBox.Show("Yetki Statüsü Boş Bırakılmamalıdır", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Temizle()
        {
            cb_yetki.DataSource = db.Urunlers.ToList();
            cb_yetki.Text = "Seçiniz...";
            tb_isim.Text = "";
            tb_soyisim.Text = "";
            tb_id.Text = "";
            cb_aktif.Checked = false;
            btn_ekle.Visible = true;
            btn_guncelle.Visible = false;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
