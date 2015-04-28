using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogClassLibrary.DataAccessLayer;

namespace MVCProjectBlog.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index(string blogName)
        {
            var DB = new Repository();
           var model =  DB.GetPostWithBlogName(blogName);

            return View(model);
        }
    }
}