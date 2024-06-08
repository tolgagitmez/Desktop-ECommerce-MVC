using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using TeknoTrendWebApp.Models;

namespace TeknoTrendWebApp.Areas.AdminPanel.Services
{
    public class XmlService
    {

        public (List<Product>, List<ProductImage>) ReadXmlFile(string filePath)
        {
            List<Product> products = new List<Product>();
            List<ProductImage> productImages = new List<ProductImage>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            XmlNodeList productNodes = xmlDoc.SelectNodes("//Urunler");

            foreach (XmlNode productNode in productNodes)
            {
                int productId = int.Parse(productNode.SelectSingleNode("ID").InnerText);
                int Category_ID = int.Parse(productNode.SelectSingleNode("Kategori_ID").InnerText);
                int Brand_ID = int.Parse(productNode.SelectSingleNode("Marka_ID").InnerText);
                string Name = productNode.SelectSingleNode("UrunAdi").InnerText;
                double Price = double.Parse(productNode.SelectSingleNode("BirimFiyat").InnerText);
                int Stock = int.Parse(productNode.SelectSingleNode("StokMiktari").InnerText);

                Product product = new Product
                {
                    ID = productId,
                    Category_ID = Category_ID,
                    Brand_ID = Brand_ID,
                    Name = Name,
                    Price = Price,
                    Stock = Stock
                };

                products.Add(product);

                string resimUrl = productNode.SelectSingleNode("Resim").InnerText;

                ProductImage productImage = new ProductImage
                {
                    Product_ID = productId,
                    ImageUrl = resimUrl,
                    isListImage = true
                };

                productImages.Add(productImage);
            }

            return (products, productImages);
        }


    }
}
