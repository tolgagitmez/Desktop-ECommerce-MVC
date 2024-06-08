using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknoTrendWebApp.Models;

namespace TeknoTrendWebApp.Controllers
{
    public class ProfileController : Controller
    {
        TeknoTrendDBModel db = new TeknoTrendDBModel();
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            User u = Session["user"] as User;
            return View(u);
        }

        [HttpPost]
        public ActionResult Edit(User model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    ViewBag.basarili = "Güncellendi";
                }
                catch
                {
                    ViewBag.hata = "Bir hata oluştu";
                }
            }
            return View();
        }


        [HttpGet]
        public ActionResult Orders()
        {
            User u = Session["user"] as User;
            if (u == null)
            {
                return RedirectToAction("Login", "User");
            }

            var satislar = db.Satislar.Where(x => x.User_ID == u.ID).ToList();

            var orderViewModels = new List<OrderViewModel>();

            foreach (var item in satislar)
            {
                var satisDetaylar = db.SatisDetaylar.Where(x => x.Satis_ID == item.ID).ToList();

                var orderDetails = new List<OrderDetailViewModel>();
                foreach (var sd in satisDetaylar)
                {
                    var product = db.Products.SingleOrDefault(x => x.ID == sd.Urun_ID);
                    if (product != null)
                    {
                        orderDetails.Add(new OrderDetailViewModel
                        {
                            ProductName = product.Name,
                            Quantity = sd.Adet,
                            Price = sd.Fiyat
                        });
                    }
                }

                orderViewModels.Add(new OrderViewModel
                {
                    OrderID = item.ID,
                    OrderDate = item.Tarih,
                    InvoiceNumber = item.FaturaNo,
                    OrderDetails = orderDetails
                });
            }

            return View(orderViewModels);
        }


        


    }
}