using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLibrary.DataAccessLayer
{
    public class Repository
    {

        public void CreatePost(string blogName, string header, string content)
        {
            using (var _context = new BlogContext())
            {
                var selectedBlog =
                    (from b in _context.Blogs
                     where b.Name == blogName
                     select b).FirstOrDefault();
                if (selectedBlog != null)
                {
                    selectedBlog.Posts.Add(new Post { Header = header, Content = content, DateTime = DateTime.Now });
                    _context.SaveChanges();
                }
            }
        }

        public Post ReturnBlogWithOnePost(string PostId)
        {
            int postId = Int32.Parse(PostId);
            var _context = new BlogContext();

            return (
                from p in _context.Posts
                where p.Id == postId
                select p).FirstOrDefault();
        }

        public Blog GetBlogWithId(int Id)
        {
            var bloglist = ReturnBlogs();
            return Id < bloglist.Count ? bloglist[Id] : null;
        }

        public string GetBlogName(string userName)
        {
            using (var _context = new BlogContext())
            {
                return (from b in _context.Owners
                        join p in _context.Blogs on b.Id equals p.Id
                        where b.UserName == userName
                        select p.Name).FirstOrDefault();

            }
        }
        public List<string> GetAllUserNames()
        {
            using (var _context = new BlogContext())
            {
                return (from o in _context.Owners
                        orderby o.UserName descending
                        select o.UserName).ToList();

            }
        }
        public List<Owner> GetOwnersForWinForm(string username)
        {
            using (var _context = new BlogContext())
            {
                return (from o in _context.Owners
                        where o.UserName == username
                        select o).ToList();
            }
        }
        public List<string> ReturnBlogName()
        {
            using (var _context = new BlogContext())
            {
                var query =
                    (from u in _context.Owners
                     select u.UserName).ToList();
                return query;
            }
        }

        public List<Owner> ReturnOwners()
        {
            using (var _context = new BlogContext())
            {
                var query =
                    (from o in _context.Owners
                     select o).ToList();

                return query;

            }
        }

        public List<Blog> ReturnBlogs()
        {
            var _context = new BlogContext();
                return (from b in _context.Blogs
                     select b
                         ).ToList();
        }

        public Blog ReturnBlogs(string BlogId)
        {
            int blogId = Int32.Parse(BlogId);
            var returnBlog = new Blog();

            var _context = new BlogContext();
            
                var query =
                    from b in _context.Blogs
                    where b.Id == blogId
                    select b;

                returnBlog = query.FirstOrDefault();
                return returnBlog;
            
}

        public List<Hashtag> ReturnTenHashtags()
        {
            using (var _context = new BlogContext())
            {
                return (
                    from h in _context.Hashtags
                    select h).Take(10).ToList();
            }
        } 
        public List<Post> ReturnPostsToMainCarousell()
        {
            var _context = new BlogContext();
            return (from b in _context.Blogs
                    from p in b.Posts
                    orderby p.DateTime descending
                    select p
                    ).Take(5).ToList();
        }
        public Blog GetPostWithBlogName(string blogName)
        {
            var _context = new BlogContext();
            
                return (from b in _context.Blogs
                    where b.Name == blogName
                    select b).FirstOrDefault();
        }
    }
}
