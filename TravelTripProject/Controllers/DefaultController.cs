﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        public ActionResult About()
        {

            return View();
        }
        public PartialViewResult partial1()
        {
            var values = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult partial2()
        {
            var value = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(value);
        }
    }
}