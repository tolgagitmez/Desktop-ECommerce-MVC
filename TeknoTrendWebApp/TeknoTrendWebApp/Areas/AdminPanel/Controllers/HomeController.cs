using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknoTrendWebApp.Models;

namespace TeknoTrendWebApp.Areas.AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        // GET: AdminPanel/Home
        TeknoTrendDBModel db = new TeknoTrendDBModel();
        public ActionResult Index()
        {
            ViewBag.kategorisayi = db.Categories.Count();
            ViewBag.urunsayi = db.Products.Count();
            ViewBag.uyesayi = 0;
            ViewBag.kazanc = 0;
            return View();
        }
    }
}