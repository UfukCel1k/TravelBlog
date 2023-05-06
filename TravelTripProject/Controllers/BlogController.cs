using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {

        Context c = new Context();
        BlogComment bc = new BlogComment();

        public ActionResult Index()
        {
            //var blogs = c.Blogs.ToList();
            bc.value1 = c.Blogs.ToList();
            bc.value3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(bc);
        }


        public ActionResult BlogDetail(int id) 
        {

            //var SearchBlog = c.Blogs.Where(x => x.ID == id).ToList();
            bc.value1 = c.Blogs.Where(x => x.ID == id).ToList();
            bc.value2 = c.Commentss.Where(x => x.BlogID == id).ToList();
            return View(bc);
        }
    }
}