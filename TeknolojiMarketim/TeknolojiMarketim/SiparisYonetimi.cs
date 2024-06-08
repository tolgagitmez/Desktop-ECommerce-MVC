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
    public partial class SiparisYonetimi : Form
    {
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        public SiparisYonetimi()
        {
            InitializeComponent();
            GridDoldur();
        }


        public void GridDoldur()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Barkod";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Name = "Ürün Adı";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Name = "Fiyat";
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Name = "Stok Miktarı";
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Name = "Güvenlik Stoğu";
            dataGridView1.Columns[4].Width = 60;


            List<Urunler> stok = db.Urunlers.Where(x => x.StokMiktari <= x.GuvenlikStogu).ToList();
            foreach (Urunler item in stok)
            {
                ArrayList row = new ArrayList();
                row.Add(item.BarkodNo);
                row.Add(item.UrunAdi);
                row.Add(item.BirimFiyat);
                row.Add(item.StokMiktari);
                row.Add(item.GuvenlikStogu);
                dataGridView1.Rows.Add(row.ToArray());
            }
        }
    }
}
