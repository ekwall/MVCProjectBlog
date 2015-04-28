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

        public void CreatePost(string userName, string blogName, string header, string content)
        {
            List<Blog> listOfBlogs = new List<Blog>();
            int id = 0;
            var query =
                from o in _context.Owners
                where o.UserName == userName
                join b in _context.Blogs on o.Id equals b.Id
                where b.Name == blogName
                select b;

            foreach (var blog in query)
            {
                listOfBlogs.Add(blog);
                id = blog.Id;
            }

            listOfBlogs.ForEach(p => _context.Posts.Add(new Post{ Header = header, Content = content,DateTime = DateTime.Now}));
            
            _context.SaveChanges();


        }

   





        public Blog GetBlogWithId(int Id)
        {
            var bloglist = ReturnBlogs();
            return Id < bloglist.Count ? bloglist[Id] : null;
        }

        public string GetBlogName(string userName)
        {
            return (from b in _context.Owners
                join p in _context.Blogs on b.Id equals p.Id
                where b.UserName == userName
                select p.Name).FirstOrDefault();
        }
        
        public List<string> GetAllUserNames()
        {
            return (from o in _context.Owners
                    orderby o.UserName descending 
                select o.UserName).ToList();
        }

        public List<Owner> GetOwnersForWinForm(string username)
        {
            return (from o in _context.Owners
                where o.UserName == username
                select o).ToList();
        }

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

        public List<Post> GetPostWithBlogName(string blogName)
        {
          

            return (from p in _context.Posts
                    where p.Header == "Drank lagabullin"
                    select p).ToList();

        }

       
    }
}
