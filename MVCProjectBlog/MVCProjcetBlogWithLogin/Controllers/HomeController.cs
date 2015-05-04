﻿using System;
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
        public ActionResult Register()
        {

            return View();
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
    }
}