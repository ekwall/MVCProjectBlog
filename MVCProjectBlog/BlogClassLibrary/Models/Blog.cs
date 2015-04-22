using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Instrumentation;

namespace BlogClassLibrary
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public string BackgroundImage { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual List<Link> Links { get; set; }
    }
}
