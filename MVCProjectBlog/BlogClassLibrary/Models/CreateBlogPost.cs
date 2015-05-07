using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BlogClassLibrary;

namespace MVCProjectBlogNew.Models
{
    public class CreateBlogPost
    {
        [Required]
        public string Header { get; set; }
        [Required, MaxLength(1500)]
        public string Content { get; set; }
        [Required, MaxLength(100)]
        public string Hashtags { get; set; }
    }
}