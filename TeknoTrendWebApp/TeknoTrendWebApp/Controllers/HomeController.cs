using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknoTrendWebApp.Models;

namespace TeknoTrendWebApp.Controllers
{
    public class HomeController : Controller
    {
        TeknoTrendDBModel db = new TeknoTrendDBModel();
        // GET: Home

        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                string categoryName = db.Categories.Find(id).Name;
                ViewBag.Title = categoryName;
                return View(db.Products.Where(x => x.IsActive && x.Category_ID == id).ToList());
            }
            else
            {
                ViewBag.Title = "Anasayfa";
                return View(db.Products.Where(x => x.IsActive).ToList());
            }

        }

        public ActionResult Search(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                var matchedProducts = db.Products
                                        .Where(x => x.Name.Contains(str) && x.IsActive)
                                        .ToList();
                ViewBag.SearchQuery = str;
                return View(matchedProducts);

            }
            else
            {
                ViewBag.Title = "Anasayfa";
                return View(db.Products.Where(x => x.IsActive).ToList());
            }

        }

        //public ActionResult CategoryProducts(int id)
        //{
        //    return View(db.Products.Where(x => x.IsActive && x.Category_ID == id).ToList());
        //}
    }
}