using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TeknolojiMarketim
{
    public class ProductService
    {
        TeknolojiMarketimDBEntities db = new TeknolojiMarketimDBEntities();
        public List<Urunler> GetProducts()
        {
            List<Urunler> urunlers = db.Urunlers.ToList();
            List<Urunler> yeniurunlers = new List<Urunler>();
            foreach (Urunler u in urunlers)
            {
                if (u != null)
                {
                    Urunler urun = new Urunler();
                    urun.ID = u.ID;
                    urun.Kategori_ID = u.Kategori_ID;
                    urun.Marka_ID = u.Marka_ID;
                    urun.Tedarikci_ID = u.Tedarikci_ID;
                    urun.UrunAdi = u.UrunAdi;
                    urun.BirimFiyat = u.BirimFiyat;
                    urun.StokMiktari = u.StokMiktari;
                    urun.Resim = u.Resim;
                    urun.BarkodNo = u.BarkodNo;
                    yeniurunlers.Add(urun);
                }
            }
            return yeniurunlers;

        }

        public void SaveProductsToXml(List<Urunler> products, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Urunler>));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, products);
            }
        }

    }
}
