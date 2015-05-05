﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLibrary.DataAccessLayer
{
    public class Repository
    {

        public void UpdatePost(Post updatedPost)
        {
            using (var _context = new BlogContext())
            {
                if (updatedPost.Id >= 0 && updatedPost.Id < _context.Posts.Count())
                {
                    var targetPost =
                        (from p in _context.Posts
                            where p.Id == updatedPost.Id
                            select p).FirstOrDefault();

                    targetPost.Header = updatedPost.Header;
                    targetPost.Content = updatedPost.Content;
                    

                    _context.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("No such post!");
                }
            }
        }

        public void InsertNewBlogPost(Post newPost, int blogId)
        {
            using (var _context = new BlogContext())
            {
                var blog =
                    (from b in _context.Blogs
                     where b.Id == blogId
                        select b).FirstOrDefault();

                if (blog != null)
                {
                    blog.Posts.Add(newPost);
                    _context.SaveChanges();
                }
            }
        }

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
                    ).Take(4).ToList();
        }
        public Blog GetPostWithBlogName(string blogName)
        {
            var _context = new BlogContext();
            
                return (from b in _context.Blogs
                    where b.Name == blogName
                    select b).FirstOrDefault();
        }

        public void AddNewOwnerAccount(Owner owner)
        {
            var _context = new BlogContext();
            _context.Owners.Add(owner);
            _context.SaveChanges();
        }

        public int CheckLogin(Owner owner)
        {
            using (var _context = new BlogContext())
            {
                var query =
                    (from o in _context.Owners
                        where o.UserName == owner.UserName && o.Password == owner.Password
                        select o.Id).FirstOrDefault();
                return query;
            }
            return 0;

        }

        public List<Post> GetAllPostsContainingSpecificHashtag(string hashtag)
        {
            using (var _context = new BlogContext())
            {
                return (from p in _context.Posts
                        from h in p.Hashtags
                        where h.Tag == hashtag
                        select p).ToList();
            }
        }

        public List<Blog> ReturnUserLoggedInBlogs(string userName)
        {
            using (var _context = new BlogContext())
            {
                return (from b in _context.Blogs
                    where b.Owner.UserName == userName
                    select b).ToList();
            }
        }
    }
}
