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
    public partial class AnaForm : Form
    {
        private ProductService productService;
        public AnaForm()
        {
            KullaniciGiris frm = new KullaniciGiris();
            frm.ShowDialog();
            InitializeComponent();
            productService = new ProductService();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            TSSL_kullanici.Text = Helpers.GirisYapanYonetici.KullaniciAdi + "(" + Helpers.GirisYapanYonetici.YetkiIsim + ")";
        }

        private void TSMI_KategoriForm_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;

            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(KategoriIslemleri))
                {
                    item.Activate();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                KategoriIslemleri frm = new KategoriIslemleri();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_UrunForm_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;

            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(UrunIslemleri))
                {
                    item.Activate();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                UrunIslemleri frm = new UrunIslemleri();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_Markalar_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;

            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(MarkaIslemleri))
                {
                    item.Activate();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                MarkaIslemleri frm = new MarkaIslemleri();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_TedarikciForm_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;

            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(TedarikciIslemleri))
                {
                    item.Activate();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                TedarikciIslemleri frm = new TedarikciIslemleri();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_satis_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;

            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(SatislarForm))
                {
                    item.Activate();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                SatislarForm frm = new SatislarForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_AlisIslemleri_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;

            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(AlisIslemleri))
                {
                    item.Activate();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                AlisIslemleri frm = new AlisIslemleri();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_admin_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;

            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(AdminIslemleri))
                {
                    item.Activate();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                AdminIslemleri frm = new AdminIslemleri();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_SatisModul_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;

            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(SatisModulu))
                {
                    item.Activate();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                SatisModulu frm = new SatisModulu();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_siparisYonetimi_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;

            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(SiparisYonetimi))
                {
                    item.Activate();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                SiparisYonetimi frm = new SiparisYonetimi();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_Raporlama_Click(object sender, EventArgs e)
        {
            Form[] acikformlar = this.MdiChildren;

            bool acikmi = false;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(Raporlama))
                {
                    item.Activate();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                Raporlama frm = new Raporlama();
                frm.MdiParent = this;
                frm.Show();
            }
        }

    }
}
