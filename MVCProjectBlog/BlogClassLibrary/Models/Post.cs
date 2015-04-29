using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public virtual List<Hashtag> Hashtags { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
