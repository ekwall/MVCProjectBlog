using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BlogClassLibrary;
using BlogClassLibrary.DataAccessLayer;
using Microsoft.AspNet.Identity;
using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using WebApplication6.Models;

using Microsoft.Owin.Security;
using Microsoft.Owin.Host.SystemWeb;



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