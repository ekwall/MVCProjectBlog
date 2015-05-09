using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BlogClassLibrary;
using BlogClassLibrary.DataAccessLayer;




namespace MVCProjectBlogNew.Controllers
{
    public class LoginController : Controller
    {
        
      
        
        public ActionResult Login()
        {
            return View(new Owner());
        }

        [HttpPost]
        public ActionResult Login(Owner owner)
        {
            if (owner != null)
            {
                var db = new Repository();
                int userId = db.CheckLogin(owner);

                if (userId > 0)
                {
                   
                    FormsAuthentication.SetAuthCookie(owner.UserName, createPersistentCookie: false);
                    return RedirectToAction("Index", "Home");
                    
                }
                else
                {
                    ModelState.AddModelError("", "Login Data is incorrect");
                    return View(new Owner()); 
                }

            }
            else
            {
                return View(new Owner()); 
            }
            
        }
    }
    
    
}