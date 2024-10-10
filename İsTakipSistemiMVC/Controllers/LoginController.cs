using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using İsTakipSistemiMVC.Controllers;
using İsTakipSistemiMVC.Models;

namespace İsTakipSistemiMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        IsTakipDBEntities entity = new IsTakipDBEntities();
        public ActionResult Index()
        {
            ViewBag.mesaj = null;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string kullaniciAd, string parola)
        {

            var personel = (from p in entity.Personeller where p.personelKullaniciAd == kullaniciAd && p.personelParola == parola select p).FirstOrDefault();

            if (personel != null)
            {
                //giriş yapıp yapmadığımızı bu session bilgisine göre sağlıyoruz
                Session["PersonelAdSoyad"] = personel.personelAdSoyad;
                Session["PersonelId"] = personel.personelId;
                Session["PersonelBirimId"] = personel.personelBirimId;
                Session["PersonelYetkiTurId"] = personel.personelYetkiTurId;

                switch (personel.personelYetkiTurId)
                {
                    case 1:
                        return RedirectToAction("Index", "Yonetici");
                    case 2:
                        return RedirectToAction("Index", "Calisan");

                    default:
                        return View();

                }
            }
            else
            {
                ViewBag.mesaj = "Kullanıcı adı ya da parola yanlış";
                return View();
            }

            
        }
    }
}