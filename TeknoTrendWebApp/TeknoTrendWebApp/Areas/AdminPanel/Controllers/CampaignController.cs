using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknoTrendWebApp.Models;

namespace TeknoTrendWebApp.Areas.AdminPanel.Controllers
{
    public class CampaignController : Controller
    {
        TeknoTrendDBModel db = new TeknoTrendDBModel();
        // GET: AdminPanel/Campaign
        public ActionResult Index()
        {
            return View(db.Campaigns.Where(x => x.IsDeleted == false).ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Brand_ID = new SelectList(db.Brands, "ID", "Name");
            ViewBag.Category_ID = new SelectList(db.Categories, "ID", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Campaigns model, HttpPostedFileBase Image)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    bool isValidImage = true;
                    FileInfo fi = new FileInfo(Image.FileName);
                    string ImageName = "";
                    if (fi.Extension == ".jpg" || fi.Extension == ".png")
                    {
                        ImageName = Guid.NewGuid().ToString() + fi.Extension;
                        model.ImageUrl = ImageName;
                    }
                    else { isValidImage = false; }
                    if (isValidImage)
                    {
                        Image.SaveAs(Server.MapPath("~/Assets/CampaignImages/" + ImageName));
                        db.SaveChanges();
                    }
                    else
                    {
                        ViewBag.hata = "Resim Formatı Uygun Değil";
                    }

                    db.Campaigns.Add(model);
                    db.SaveChanges();
                    ViewBag.basarili = "Kampanya Başarıyla Eklendi";
                }
                catch
                {
                    ViewBag.hata = "Kampanya eklenirken bir hata oluştu";
                }
            }
            ViewBag.Brand_ID = new SelectList(db.Brands, "ID", "Name");
            ViewBag.Category_ID = new SelectList(db.Categories, "ID", "Name");
            return View(model);
        }
    }
}