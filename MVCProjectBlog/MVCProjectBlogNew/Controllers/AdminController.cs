using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogClassLibrary;
using BlogClassLibrary.DataAccessLayer;
using Microsoft.AspNet.Identity;

namespace MVCProjectBlogNew.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            var db = new Repository();
            var model = db.ReturnUserLoggedInBlogs(User.Identity.Name);
            return View(model);
        }
    }
}