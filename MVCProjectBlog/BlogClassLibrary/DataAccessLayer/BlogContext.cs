using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLibrary.DataAccessLayer
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Hashtag> Hashtags { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
