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
    public partial class TaksitIslemleri : Form
    {
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        int deger;
        decimal tutar = ToplamSatisTutari.tutar;
        public TaksitIslemleri()
        {
            InitializeComponent();
        }

        private void RadioButtons(object sender, EventArgs e)
        {
            char karakter = ((RadioButton)sender).Text.First();
            deger = (int)Char.GetNumericValue(karakter);
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            TaksitValueClass.value = deger;
            this.Close();
        }

        private void TaksitIslemleri_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is RadioButton button)
                {
                    button.Click += new EventHandler(RadioButtons);
                }
            }

            if (tutar < 1000)
            {
                rb_7.Visible = false;
                rb_8.Visible = false;
                rb_9.Visible = false;
                rb_10.Visible = false;
                rb_11.Visible = false;
                rb_12.Visible = false;
                lbl_7tkst.Visible = false;
                lbl_8tkst.Visible = false;
                lbl_9tkst.Visible = false;
                lbl_10tkst.Visible = false;
                lbl_11tkst.Visible = false;
                lbl_12tkst.Visible = false;
            }
            lbl_2tkst.Text = "Toplam Ödenecek: " + (tutar * 1.05m).ToString().Substring(0, 4) + " Taksit Tutarı: " + ((tutar * 1.05m) / 2).ToString().Substring(0, 4);
            lbl_3tkst.Text = "Toplam Ödenecek: " + (tutar * 1.08m).ToString().Substring(0, 4) + " Taksit Tutarı: " + ((tutar * 1.08m) / 3).ToString().Substring(0, 4);
            lbl_4tkst.Text = "Toplam Ödenecek: " + (tutar * 1.10m).ToString().Substring(0, 4) + " Taksit Tutarı: " + ((tutar * 1.10m) / 4).ToString().Substring(0, 4);
            lbl_5tkst.Text = "Toplam Ödenecek: " + (tutar * 1.13m).ToString().Substring(0, 4) + " Taksit Tutarı: " + ((tutar * 1.13m) / 5).ToString().Substring(0, 4);
            lbl_6tkst.Text = "Toplam Ödenecek: " + (tutar * 1.15m).ToString().Substring(0, 4) + " Taksit Tutarı: " + ((tutar * 1.15m) / 6).ToString().Substring(0, 4);
            lbl_7tkst.Text = "Toplam Ödenecek: " + (tutar * 1.20m).ToString().Substring(0, 4) + " Taksit Tutarı: " + ((tutar * 1.20m) / 7).ToString().Substring(0, 4);
            lbl_8tkst.Text = "Toplam Ödenecek: " + (tutar * 1.30m).ToString().Substring(0, 4) + " Taksit Tutarı: " + ((tutar * 1.30m) / 8).ToString().Substring(0, 4);
            lbl_9tkst.Text = "Toplam Ödenecek: " + (tutar * 1.40m).ToString().Substring(0, 4) + " Taksit Tutarı: " + ((tutar * 1.40m) / 9).ToString().Substring(0, 4);
            lbl_10tkst.Text = "Toplam Ödenecek: " + (tutar * 1.50m).ToString().Substring(0, 4) + " Taksit Tutarı: " + ((tutar * 1.50m) / 10).ToString().Substring(0, 4);
            lbl_11tkst.Text = "Toplam Ödenecek: " + (tutar * 1.65m).ToString().Substring(0, 4) + " Taksit Tutarı: " + ((tutar * 1.65m) / 11).ToString().Substring(0, 4);
            lbl_12tkst.Text = "Toplam Ödenecek: " + (tutar * 1.75m).ToString().Substring(0, 4) + " Taksit Tutarı: " + ((tutar * 1.75m) / 12).ToString().Substring(0, 4);
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
