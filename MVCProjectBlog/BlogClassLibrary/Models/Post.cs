using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLibrary
{
    public class Post
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public virtual List<Hashtag> Hashtag { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
