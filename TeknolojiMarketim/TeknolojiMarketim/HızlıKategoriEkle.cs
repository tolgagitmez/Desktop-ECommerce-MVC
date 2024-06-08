using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace TeknolojiMarketim
{
    
    public partial class HızlıKategoriEkle : Form
    {
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        public HızlıKategoriEkle()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.Isim = tb_ekle.Text;
            k.IsActive = IsActive.Checked;
            k.Aciklama = "";
            k.IsDeleted = false;
            db.Kategorilers.Add(k);
            db.SaveChanges();
            KategoriIslemleri kat = new KategoriIslemleri();
            kat.guncelle();
            MessageBox.Show("Kategori Başarıyla Eklendi");
            this.Close();
        }
    }
}
