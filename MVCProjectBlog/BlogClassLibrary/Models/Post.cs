using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BlogClassLibrary
{
    public class Post
    {
        public Post()
        {
            Hashtags = new List<Hashtag>();
            Comments = new List<Comment>();
        }
        public int Id { get; set; }
        public string Header { get; set; }

        [Required]
        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        [Display(Name = "Content")]
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public string Postimage { get; set; }
        public virtual List<Hashtag> Hashtags { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual Blog Blog { get; set; }
        //public virtual Blog BlogId { get; set; }
    }
}
