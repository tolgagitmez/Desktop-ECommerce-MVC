using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknoTrendWebApp.Models;

namespace TeknoTrendWebApp.Controllers
{
    public class MenuController : Controller
    {
        TeknoTrendDBModel db = new TeknoTrendDBModel();
        // GET: Menu
        public ActionResult _menuView()
        {
            return PartialView(db.Categories.Where(x => x.IsActive).ToList());
        }
    }
}