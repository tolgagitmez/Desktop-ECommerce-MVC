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
    public partial class SatisDetayIslemleri : Form
    {
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        public SatisDetayIslemleri()
        {
            InitializeComponent();
            GridDoldur();
        }

        public void GridDoldur()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Name = "Satış ID";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Name = "Ürün Adı";
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Name = "Adet";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Name = "Fiyat";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Name = "Toplam Tutar";
            dataGridView1.Columns[5].Width = 100;

            int satisID = SatislarForm.Satis.SatisID;

            List<SatisDetaylar> list = db.SatisDetaylars.Where(x => x.Satis_ID == satisID).ToList();
            foreach (SatisDetaylar item in list)
            {
                ArrayList row = new ArrayList();
                row.Add(item.ID);
                row.Add(item.Satis_ID);
                row.Add(item.Urunler.UrunAdi);
                row.Add(item.Adet);
                row.Add(item.Fiyat);
                row.Add(item.Adet * item.Fiyat);
                dataGridView1.Rows.Add(row.ToArray());
            }
        }
    }
}
