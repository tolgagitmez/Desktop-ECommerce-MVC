using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknoTrendWebApp.Models;

namespace TeknoTrendWebApp.Controllers
{
    public class CampaignController : Controller
    {
        TeknoTrendDBModel db = new TeknoTrendDBModel();
        // GET: Campaign
        public ActionResult Index()
        {
            return View(db.Campaigns.Where(x => x.IsActive).ToList());
        }
    }
}