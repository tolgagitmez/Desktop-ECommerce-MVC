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
    public partial class MarkaIslemleri : Form
    {
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        int markaID;
        public MarkaIslemleri()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Markalar m = new Markalar();
            m.Isim = tb_isim.Text;
            m.IsActive = cb_aktif.Checked;
            m.IsDeleted = false;
            db.Markalars.Add(m);
            try
            {
                db.SaveChanges();
                GridDoldur();
                MessageBox.Show("Marka " + m.ID + " ile başarıyla eklenmiştir");
            }
            catch
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                Markalar m = db.Markalars.Find(markaID);
                m.Isim = tb_isim.Text;
                m.IsActive = cb_aktif.Checked;

                Temizle();
                GridDoldur();
                MessageBox.Show(markaID + " ID'li Marka Güncellendi", "Başarılı");

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

        private void MarkaIslemleri_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void TSMI_guncelle_Click(object sender, EventArgs e)
        {
            if (markaID != 0)
            {
                Markalar m = db.Markalars.Find(markaID);
                tb_ID.Text = m.ID.ToString();
                tb_isim.Text = m.Isim;
                cb_aktif.Checked = (bool)m.IsActive;
                btn_guncelle.Visible = true;

            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(markaID + " ID'li Marka Silinecektir. Devam etmek istiyor musunuz?", "Veri Silinecek", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                Markalar m = db.Markalars.Find(markaID);
                db.Markalars.Remove(m);
                db.SaveChanges();
                GridDoldur();
                MessageBox.Show(markaID + " ID'li Marka Silinmiştir", "Başarılı");

            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi", "Bilgi");
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
                    markaID = Convert.ToInt32(dataGridView1.Rows[tiklananSatir].Cells[0].Value);
                }
            }
        }

        public void GridDoldur()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "No";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Name = "İsim";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Name = "Durum";
            dataGridView1.Columns[2].Width = 80;

            List<Markalar> markalars = db.Markalars.ToList();
            foreach (Markalar item in markalars)
            {
                ArrayList row = new ArrayList();
                row.Add(item.ID);
                row.Add(item.Isim);
                row.Add(item.IsActive == true ? "Aktif" : "Pasif");
                dataGridView1.Rows.Add(row.ToArray());
            }
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            GridDoldur();
            Temizle();
        }

        private void Temizle()
        {
            tb_isim.Text = tb_ID.Text = "";
            cb_aktif.Checked = false;
            btn_guncelle.Visible = false;
        }
    }
}
