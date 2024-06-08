using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknoTrendWebApp.Models;

namespace TeknoTrendWebApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        TeknoTrendDBModel db = new TeknoTrendDBModel();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            int User_ID = 0;
            if (Session["user"] != null)
            {
                User_ID = (Session["user"] as User).ID;

            }
            return View(db.ShoppingCarts.Where(x => x.User_ID == User_ID));
        }

        public ActionResult AddProduct(string id, string quantity)
        {
            int productid = Convert.ToInt32(id);
            if (Session["user"] != null)
            {

                if (db.ShoppingCarts.Count(x => x.Product_ID == productid) == 0)
                {
                    ShoppingCart sc = new ShoppingCart();
                    sc.Product_ID = productid;
                    sc.Quantity = int.Parse(quantity);
                    sc.User_ID = (Session["user"] as User).ID;
                    sc.AddedDate = DateTime.Now;
                    db.ShoppingCarts.Add(sc);
                    db.SaveChanges();
                }
                else
                {
                    int cartid = db.ShoppingCarts.FirstOrDefault(x => x.Product_ID == productid).ID;
                    ShoppingCart sc = db.ShoppingCarts.Find(cartid);
                    sc.Quantity += int.Parse(quantity);
                    db.SaveChanges();
                }
            }
            else
            {
                TempData["controller"] = "Product";
                TempData["action"] = "Detail";
                TempData["id"] = id;
                
                return RedirectToAction("Login", "User");
            }
            bool anasayfa = (bool)TempData["Anasayfa"];
            if (anasayfa)
            {
                return RedirectToAction("index", "home");
            }
            else
            {
                return RedirectToAction("Detail", "Product", new { id = productid });
            }
        }

        public ActionResult Delete(int id)
        {

            if (Session["user"] != null)
            {
                ShoppingCart sp = db.ShoppingCarts.Find(id);
                db.ShoppingCarts.Remove(sp);
                db.SaveChanges();

            }
            return RedirectToAction("index", "ShoppingCart");
        }
    }
}