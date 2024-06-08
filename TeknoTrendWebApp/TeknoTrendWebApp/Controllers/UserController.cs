using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknoTrendWebApp.Data;
using TeknoTrendWebApp.Models;

namespace TeknoTrendWebApp.Controllers
{
    public class UserController : Controller
    {
        TeknoTrendDBModel db = new TeknoTrendDBModel();      
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    User u = db.Users.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
                    if (u != null)
                    {
                        if (u.IsActive == true)
                        {
                            Session["user"] = u;
                            if (TempData["controller"] != null)
                            {
                                return RedirectToAction(TempData["action"].ToString(), TempData["controller"].ToString(), new { id = Convert.ToInt32(TempData["id"]) });
                            }
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            ViewBag.hataMesaj = "Hesabınız askıya alınmıştır";
                        }
                    }
                    else
                    {
                        ViewBag.hataMesaj = "Kullanıcı bulunamadı";
                    }
                }
                catch
                {
                    ViewBag.hataMesaj = "Bir hata oluştu";
                }
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    User u = model;

                    if (u != null)
                    {
                        u.CreationDate = DateTime.Now;
                        db.Users.Add(u);
                        db.SaveChanges();
                        ViewBag.IslemBasarili = "İşlem Başarılı";
                        return RedirectToAction("index", "home");
                    }
                    
                }
                catch
                {
                    ViewBag.hataMesaj = "Bir hata oluştu";
                }
            }
            return View(model);
        }

        public ActionResult LogOut()
        {
            Session["user"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}