using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using BlogClassLibrary.DataAccessLayer;
using MVCProjectBlogNew.Models;

namespace MVCProjectBlogNew.Migrations

{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCProjectBlogNew.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        /*
         * add-migration namnetpåmigrationen
         * 
         * Update-Database -Script
         * 
         * */

        protected override void Seed(MVCProjectBlogNew.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //var manager = new UserManager<ApplicationUser,int>(
            //    new UserStore<ApplicationUser>(
            //        new ApplicationDbContext()));

            //// Create 4 test users:
            //for (int i = 0; i < 4; i++)
            //{
            //    var user = new ApplicationUser()
            //    {
            //        UserName = string.Format("User{0}", i.ToString())
            //    };
            //    manager.Create(user, string.Format("Password{0}", i.ToString()));
            //}
        }
    }
}
