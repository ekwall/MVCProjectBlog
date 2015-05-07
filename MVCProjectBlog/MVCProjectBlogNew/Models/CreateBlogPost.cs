using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogClassLibrary;

namespace MVCProjectBlogNew.Models
{
    public class CreateBlogPost
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public string Postimage { get; set; }
        public string Hashtags { get; set; }
    }
}