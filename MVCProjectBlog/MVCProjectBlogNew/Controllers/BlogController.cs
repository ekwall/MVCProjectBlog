using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogClassLibrary;

using BlogClassLibrary.DataAccessLayer;

namespace MVCProjectBlog.Controllers
{
    public class BlogController : Controller
    {

        public ActionResult Post(string PostId)
        {
            var db = new Repository();
            var model = db.ReturnBlogWithOnePost(PostId);
            return View(model);


        }

        public ActionResult Edit(string id)
        {
            var db = new Repository();
            var model = db.ReturnBlogWithOnePost(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Post updated)
        {
            var db = new Repository();
        db.UpdatePost(updated);
        return RedirectToAction("Index", new { BlogId = updated.Blog.Id });
        }

        
        public ActionResult Index(string BlogId)
        {

            var repository = new Repository();
            var model = repository.ReturnBlogs(BlogId);
            return View(model);

        }

        public ActionResult SubmitPost(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitPost(int id, Post createdPost)
        {
            //createdPost.Blog.Id = id;
            var db = new Repository();
            createdPost.DateTime = DateTime.Now;
        
        db.InsertNewBlogPost(createdPost, id);

        return RedirectToAction("Index", new { BlogId = id });
        }

        public ActionResult Insert(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(int id, Post createdPost)
        {

            
            var db = new Repository();
            createdPost.DateTime = DateTime.Now;

            db.InsertNewBlogPost(createdPost, id);

            return RedirectToAction("Index", new { BlogId = id });
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

        public ActionResult GetPostsWithHashtags(string tag)
        {
            Repository DB = new Repository();
            var model = DB.GetAllPostsContainingSpecificHashtag(tag);
            return View(model);
        }
        
    }
}