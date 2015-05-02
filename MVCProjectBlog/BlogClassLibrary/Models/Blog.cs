using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Instrumentation;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BlogClassLibrary
{
    public class Blog
    {
        public Blog()
        {
            Posts = new List<Post>();
            Links = new List<Link>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public string BackgroundImage { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual List<Link> Links { get; set; }
        public virtual Owner Owner { get; set; }

    }
}
