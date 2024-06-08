﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknoTrendWebApp.Models;

namespace TeknoTrendWebApp.Controllers
{
    public class ProductController : Controller
    {
        TeknoTrendDBModel db = new TeknoTrendDBModel();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Product p = db.Products.Find(id);
            List<ProductImage> images = db.ProductImages.Where(x => x.Product_ID == id).ToList();
            ViewBag.Images = images;
            ViewBag.CoverImage = images.FirstOrDefault(x => x.isListImage == true).ImageUrl;
            return View(p);
        }
    }
}