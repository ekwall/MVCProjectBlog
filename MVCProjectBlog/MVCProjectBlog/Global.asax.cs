using System;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BlogClassLibrary.DataAccessLayer;

namespace MVCProjectBlog
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            try
            {
                AreaRegistration.RegisterAllAreas();
                RouteConfig.RegisterRoutes(RouteTable.Routes);
                Database.SetInitializer(new ContextInitializer());
            }
            catch (Exception)
            {
                throw new Exception("Something went bad!");
            }
        }
    }
}