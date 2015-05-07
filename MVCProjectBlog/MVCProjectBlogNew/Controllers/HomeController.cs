using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogClassLibrary;
using BlogClassLibrary.DataAccessLayer;

namespace MVCProjectBlog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var repository = new Repository();
            var model = repository.ReturnBlogs();
            return View(model);
        }

        public ActionResult CarousellPosts()
        {
            var repository = new Repository();
            var model = repository.ReturnPostsToMainCarousell();
            model = model.Take(4).ToList();
            return PartialView("CarousellPosts",model);
        }
        [HttpPost]
        public ActionResult Register(Owner owner)
        {
            var Db = new Repository();
            Db.AddNewOwnerAccount(owner);
            

            return View(owner);
        }
        public ActionResult Register()
        {
            var model = new Owner();
            return View(model);
        }



        public ActionResult Login()
        {
           
            return PartialView("_Login");
        }

        public ActionResult _HashTags()
        {
            var repository = new Repository();
            var model = repository.ReturnTenHashtags();
            return PartialView("_Hashtags",model);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Search(string term)
        {
            var db = new Repository();

            //List<Hashtag> hasttaglist = db.GetHashtagsThatContainString(term);
            return PartialView("_SearchResult", db.GetHashtagsThatContainString(term));
        }

        public JsonResult SearchAutoComplete(string term)
        {
            var db = new Repository();
            return Json(db.GetHashtagsThatContainString(term), JsonRequestBehavior.AllowGet);
        }
    }
}