using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLibrary.DataAccessLayer
{
    public class Repository
    {
        private BlogContext _context;

        public Repository()
        {
            _context = new BlogContext();
        }

        public List<string> ReturnBlogName()
        {

            var query =
                (from u in _context.Owners
                    select u.UserName).ToList();

            return query;
        }

        public List<Owner> ReturnOwners()
        {
            var query =
                (from o in _context.Owners
                    select o).ToList();

            return query;
        }

        public List<Blog> ReturnBlogs()
        {
            var query =
                (from b in _context.Blogs
                     select b
                     ).ToList();

            return query;
        }
    }
}
