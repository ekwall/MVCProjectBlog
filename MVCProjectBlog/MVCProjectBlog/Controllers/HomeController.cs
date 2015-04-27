using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogClassLibrary.DataAccessLayer;

namespace MVCProjectBlog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var owner = new Repository();
            //var listOfOwners = owner.ReturnBlogName();
            //ViewBag.Name = listOfOwners[0];
            //ViewBag.Description = "A delightful Trappistbeer.";
            

            var blogEntities = new BlogContext();
            var repository = new Repository();
            return View(repository.ReturnBlogs());

            
        }

        public ActionResult Register()
        {

            return View();
        }
    }
}