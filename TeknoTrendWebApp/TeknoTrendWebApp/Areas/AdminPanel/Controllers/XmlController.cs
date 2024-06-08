using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknoTrendWebApp;
using TeknoTrendWebApp.Areas.AdminPanel.Services;
using TeknoTrendWebApp.Models;

namespace TeknoTrendWebApp.Areas.AdminPanel.Controllers
{
    public class XmlController : Controller
    {
        TeknoTrendDBModel db = new TeknoTrendDBModel();
        XmlService _xmlService = new XmlService();


        [HttpGet]
        public ActionResult PreviewXml()
        {
            string filePath = Server.MapPath("~/uploads/products.xml");

            var (products, productImages) = _xmlService.ReadXmlFile(filePath);
            var model = new ConfirmXmlViewModel
            {
                Products = products,
                ProductImages = productImages
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult ImportProducts(ConfirmXmlViewModel model)
        {
            if (model != null && model.Products != null && model.ProductImages != null)
            {
                foreach (Product product in model.Products)
                {
                    var existingProduct = db.Products.FirstOrDefault(p => p.ID == product.ID);
                    if (existingProduct != null)
                    {
                        existingProduct.Name = product.Name;
                        existingProduct.Price = product.Price;
                    }
                    else
                    {
                        db.Products.Add(product);
                    }
                }

                foreach (ProductImage productImage in model.ProductImages)
                {
                    db.ProductImages.Add(productImage);
                }

                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }


    }
}