﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BlogClassLibrary.DataAccessLayer;

namespace MVCProjectBlog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {


            var blogEntities = new BlogContext();
            var repository = new Repository();
            var model = repository.ReturnBlogs();
            return View(model);

        }

        //public ActionResult Index(int Id)
        //{
        //    var repository = new Repository();
        //    var model = repository.GetBlogWithId(Id);

        //    if (model != null)
        //        return View(model);
        //    else
        //        return HttpNotFound();
        //}

        
    }
}