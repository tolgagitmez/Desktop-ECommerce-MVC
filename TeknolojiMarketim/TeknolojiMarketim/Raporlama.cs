using System;
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
    public partial class Raporlama : Form
    {
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        public Raporlama()
        {
            InitializeComponent();
        }

        private void Raporlama_Load(object sender, EventArgs e)
        {
            var enCokSatisYapilanUrunler = db.SatisDetaylars
            .GroupBy(sd => sd.Urunler.UrunAdi)
            .Select(g => new
            {
                UrunAdi = g.Key,
                ToplamAdet = g.Sum(sd => sd.Adet),
                ToplamSatisTutar = g.Sum(sd => sd.Adet * sd.Fiyat),
                AylikSatisTutari = g.Where(sd => sd.Satislar.Tarih.Value.Month == DateTime.Now.Month && sd.Satislar.Tarih.Value.Year == DateTime.Now.Year)
                                    .Sum(sd => sd.Adet * sd.Fiyat),
                YillikSatisTutari = g.Where(sd => sd.Satislar.Tarih.Value.Year == DateTime.Now.Year)
                                     .Sum(sd => sd.Adet * sd.Fiyat)
            })
            .OrderByDescending(g => g.ToplamAdet)
            .Take(10)
            .ToList();

            dataGridView1.DataSource = enCokSatisYapilanUrunler;
            dataGridView1.Columns["UrunAdi"].HeaderText = "Ürün Adı";
            dataGridView1.Columns["ToplamAdet"].HeaderText = "Toplam Adet";
            dataGridView1.Columns["ToplamSatisTutar"].HeaderText = "Toplam Satış Tutarı";
            dataGridView1.Columns["AylikSatisTutari"].HeaderText = "Aylık Satış Tutarı";
            dataGridView1.Columns["YillikSatisTutari"].HeaderText = "Yıllık Satış Tutarı";
        }
    }
}
