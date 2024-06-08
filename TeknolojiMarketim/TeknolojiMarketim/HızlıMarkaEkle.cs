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
    public partial class HızlıMarkaEkle : Form
    {
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        public HızlıMarkaEkle()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Markalar m = new Markalar();
            m.Isim = tb_ekle.Text;
            m.IsActive = IsActive.Checked;
            m.IsDeleted = false;
            db.Markalars.Add(m);
            db.SaveChanges();
            MessageBox.Show("Marka Eklendi");
        }
    }
}
