using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TeknoTrendWebApp.Models;

namespace TeknoTrendWebApp.Controllers
{
    public class PayController : Controller
    {
        TeknoTrendDBModel db = new TeknoTrendDBModel();

        [HttpGet]

        public ActionResult Index()
        {
            int User_ID = 0;
            if (Session["user"] != null)
            {
                User_ID = (Session["user"] as User).ID;
            }
            return View(db.ShoppingCarts.Where(x => x.User_ID == User_ID));
        }
        [HttpPost]
        public ActionResult Index(string name, string cardnumber, string reqmonth, string reqyear, string cvv)
        {
            int User_ID = 0;
            if (Session["user"] != null)
            {
                User_ID = (Session["user"] as User).ID;
            }
            List<ShoppingCart> list = db.ShoppingCarts.Where(x => x.User_ID == User_ID).ToList();
            double total = list.Sum(x => x.Product.Price * x.Quantity);
            string fiyatstr = total.ToString().Replace(",", ".");
            string apiurl = "https://localhost:44394/API/Pay?kartno=" + cardnumber + "&sonkullanmaAy=" + reqmonth + "&sonkullanmayil=" + reqyear + "&CVV=" + cvv + "&fiyat=" + fiyatstr;
            //using System.Net.Http;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(apiurl).Result;
            var strinResp = response.Content.ReadAsStringAsync();
            if (strinResp.Result == "\"201\"")
            {
                return RedirectToAction("PaymentSuccess");
            }
            else if (strinResp.Result == "\"901\"")
            {
                ViewBag.message = "Kart Numarası Hatalı Girildi";
            }
            else if (strinResp.Result == "\"801\"")
            {
                ViewBag.message = "Kart Tarihi Eşleşmesi";
            }
            else if (strinResp.Result == "\"701\"")
            {
                ViewBag.message = "Banka Mesajı = Kart Tarihi Geçersiz";
            }
            else if (strinResp.Result == "\"601\"")
            {
                ViewBag.message = "Banka Mesajı =Cvv Hatalı";
            }
            else if (strinResp.Result == "\"501\"")
            {
                ViewBag.message = "Banka Mesajı = Kart Aktif Değil";
            }
            else if (strinResp.Result == "\"401\"")
            {
                ViewBag.message = "Banka Mesajı = Kart Bakiyesi yetersiz";
            }
            else if (strinResp.Result == "\"301\"")
            {
                ViewBag.message = "Banka Mesajı = Bir Hata oluştu";
            }
            return View(db.ShoppingCarts.Where(x => x.User_ID == User_ID));
        }

        public ActionResult PaymentSuccess()
        {


            try
            {

                int User_ID = 0;
                if (Session["user"] != null)
                {
                    User_ID = (Session["user"] as User).ID;
                }

                List<ShoppingCart> sc = db.ShoppingCarts.Where(x => x.User_ID == User_ID).ToList();

                Satislar s = new Satislar
                {
                    User_ID = User_ID,
                    Tarih = DateTime.Now,
                    FaturaNo = Guid.NewGuid().ToString().Substring(0, 10)
                };
                db.Satislar.Add(s);
                db.SaveChanges();
                foreach (var item in sc)
                {
                    Product product = db.Products.SingleOrDefault(x => x.ID == item.Product_ID);
                    if (product != null)
                    {
                        SatisDetaylar sd = new SatisDetaylar
                        {
                            Satis_ID = s.ID,
                            Urun_ID = item.Product_ID,
                            Adet = item.Quantity,
                            Fiyat = (decimal)(product.Price * item.Quantity)
                        };
                        db.SatisDetaylar.Add(sd);
                    }
                }
                db.SaveChanges();

                ViewBag.OrderNumber = s.FaturaNo;
                ViewBag.OrderDate = s.Tarih;

                db.ShoppingCarts.RemoveRange(sc);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return View("Error"); 
            }


            return View();
        }



    }
}