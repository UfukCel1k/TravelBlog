using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var values = c.Admins.FirstOrDefault(x => x.UserName == ad.UserName && x.Password == ad.Password);

            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["UserName"] = values.UserName.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View(); 
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Login");
        }
    }
}