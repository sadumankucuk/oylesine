using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oylesine.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            Session["kullaniciAdi"] = "";
            Session["kullaniciIsim"] = "";
            Session["kullaniciSoyisim"] = "";
            Session["kullaniciMail"] = "";
            Session["kullaniciFoto"] = "";
            Session["dogunTarihi"] = "";
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Profil()
        {
            return View();
        }

        public ActionResult Ayarlar()
        {
            return View();
        }

        public ActionResult Arkadaslar()
        {
            return View();
        }

        public JsonResult SessionRegister(string kullaniciadi, string ad, string soyad, string email, string fotograf, string dogumtarihi)
        {
            Session["kullaniciadi"] = kullaniciadi;
            Session["kullaniciısim"] = ad;
            Session["kullanicisoyisim"] = soyad;
            Session["kullanicimail"] = email;
            Session["kullanicifoto"] = fotograf;
            Session["doguntarihi"] = dogumtarihi;
            var dd = new { islem = Session["kullanicimail"].ToString() };
            return Json(dd);
        }
    }
}