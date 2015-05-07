using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLibrary
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public string Author { get; set; }
        public string AuthorEmail { get; set; }
        public DateTime DateTime { get; set; }
        public virtual Post Post { get; set; }
    }
}
