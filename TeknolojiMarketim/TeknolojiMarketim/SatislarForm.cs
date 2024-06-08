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
    public partial class SatislarForm : Form
    {
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        public static class Satis
        {
            public static int SatisID { get; set; }
        }
        public SatislarForm()
        {
            InitializeComponent();
            GridDoldur();
        }

        public void GridDoldur()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Name = "Kasiyer Adı";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Name = "Tarih";
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Name = "Fatura No";
            dataGridView1.Columns[3].Width = 100;

            List<Satislar> list = db.Satislars.ToList();
            foreach (Satislar sat in list)
            {
                ArrayList row = new ArrayList();
                row.Add(sat.ID);
                row.Add(sat.Yoneticiler.Isim);
                row.Add(sat.Tarih);
                row.Add(sat.FaturaNo);
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
                    int v = Convert.ToInt32(dataGridView1.Rows[tiklananSatir].Cells[0].Value);
                    Satis.SatisID = v;
                }
            }
        }

        private void TSMI_incele_Click(object sender, EventArgs e)
        {
            SatisDetayIslemleri frm = new SatisDetayIslemleri();
            frm.ShowDialog();
        }
    }
}
