using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.Blogs.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }   
        [HttpPost]
        public ActionResult NewBlog(Blog P)
        {
            c.Blogs.Add(P);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetBlog(int id)
        {
            var b1 = c.Blogs.Find(id);
            return RedirectToAction("GetBlog", b1);
        }
        public ActionResult UpdateBlog(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Description = b.Description;
            blg.Heading = b.Heading;
            blg.BlogImange = b.BlogImange;
            blg.Date = b.Date;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult RequestList()
        {
            var comment = c.Commentss.ToList(); 
            return View(comment);
        }
		public ActionResult DeleteComment(int id)
		{
			var b = c.Commentss.Find(id);
			c.Commentss.Remove(b);
			c.SaveChanges();
			return RedirectToAction("RequestList");
		}
        public ActionResult GetComment(int id)
		{
			var yr = c.Commentss.Find(id);
			return RedirectToAction("GetComment", yr);
		}
		public ActionResult UpdateComment(Comments y)
		{
			var yrm = c.Commentss.Find(y.ID);
			yrm.UserName = y.UserName;
			yrm.Mail = y.Mail;
			yrm.Comment = y.Comment;
			c.SaveChanges();
			return RedirectToAction("GetComment");
		}
	}
}