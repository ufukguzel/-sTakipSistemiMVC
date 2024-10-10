using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace İsTakipSistemiMVC.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Index()
        {
            //çıkış yapma session iptali
            Session.Abandon();

            return RedirectToAction("Index", "Login");
        }
    }
}