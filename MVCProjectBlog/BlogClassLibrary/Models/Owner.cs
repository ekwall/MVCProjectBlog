using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLibrary
{
    public class Owner
    {
        public Owner()
        {
            Blogs = new List<Blog>();
        }
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual List<Blog> Blogs { get; set; }
        
    }
}
