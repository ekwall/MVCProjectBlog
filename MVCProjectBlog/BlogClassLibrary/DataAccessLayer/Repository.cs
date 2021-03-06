﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.WebPages;
using MVCProjectBlogNew.Models;

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
                    targetPost.DateTime = DateTime.Now;

                    _context.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("No such post!");
                }
            }
        }

        public void InsertNewBlogPost(CreateBlogPost newPost, int blogId)
        {
            using (var _context = new BlogContext())
            {


                var convertToPost = new Post();

                convertToPost.Hashtags = ConvertStringToHashtagList(newPost.Hashtags);
                convertToPost.DateTime = DateTime.Now;
                convertToPost.Header = newPost.Header;
                convertToPost.Content = newPost.Content;
                

                var blog =
                    (from b in _context.Blogs
                     where b.Id == blogId
                        select b).FirstOrDefault();

                if (blog != null)
                {
                    blog.Posts.Add(convertToPost);
                    _context.SaveChanges();
                }
            }
        }

        private List<Hashtag> ConvertStringToHashtagList(string hashtags)
        {
            var hashtagList = new List<Hashtag>();
            
            string[] stringList = hashtags.Split(' ');
            foreach (var hastagValue in stringList)
            {
                hashtagList.Add(new Hashtag() { Tag = hastagValue });
            }
            return hashtagList;
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

        public int GetBlogIdFromPostId(int postId)
        {
            using (var _context = new BlogContext())
            {
                var id =
                    (from b in _context.Blogs
                        from p in b.Posts
                        where p.Id == postId
                        select b.Id).FirstOrDefault();
                return id;
            }
        }
        public Blog GetBlogWithId(int Id)
        {
            //var bloglist = ReturnBlogs();
            //return Id < bloglist.Count ? bloglist[Id] : null;
            var _context = new BlogContext();
            var blog =
                (from b in _context.Blogs
                    where b.Id == Id
                    select b).FirstOrDefault();
            return blog;
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
                    (from b in _context.Blogs
                    where b.Id == blogId
                    select b).FirstOrDefault();

                
                return query;
            
}

        public List<Hashtag> ReturnTenHashtags()
        {
            using (var _context = new BlogContext())
            {
                return (
                    from h in _context.Hashtags
                    orderby h.Post.DateTime descending
                    select h).Take(25).ToList();
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
            owner.Password = owner.Password.GetHashCode().ToString();
            _context.Owners.Add(owner);
            _context.SaveChanges();
        }

        public int CheckLogin(Owner owner)
        {
            using (var _context = new BlogContext())
            {
                owner.Password = owner.Password.GetHashCode().ToString();
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

        public Owner ReturnLoggedInOwner(string userName)
        {
            var _context = new BlogContext();
                return (from o in _context.Owners
                    where o.UserName == userName
                    select o).FirstOrDefault();
            
        }

        public List<int> ReturnAllHashtagsFromPostId(int postId)
        {
            using (var _context = new BlogContext())
            {
                return (from h in _context.Hashtags
                    where h.Post.Id == postId
                    select h.Id).ToList();
            }
        }

        public void AddCommentToPost(Comment comment, int Id)
        {
            using (var _context = new BlogContext())
            {
                var post =
                    (from p in _context.Posts
                        where p.Id == Id
                        select p).FirstOrDefault();

                if (post != null)
                {
                    if (comment.Author.IsEmpty())
                        comment.Author = "Guest";

                    comment.DateTime = DateTime.Now;
                    post.Comments.Add(comment);
                    _context.SaveChanges();
                }

            }
        }

        public void DeleteHashtags(int id) // <--Get Post ID
        {
            using (var _context = new BlogContext())
            {
                var hashtags =
                    (from h in _context.Hashtags
                        where h.Id == id
                        select h).ToList();
                int count = hashtags.Count;
                for (int i = 0; i <= count-1; i++)
                {
                    
                    _context.Hashtags.Remove(hashtags[i]);
                }
                _context.SaveChanges();
            }
        }
        public void DeleteLinks(int id) // <--Get Blog ID
        {
            using (var _context = new BlogContext())
            {
                var links =
                    (from l in _context.Links
                     where l.Id == id
                     select l).ToList();
                int count = links.Count;
                for (int i = 0; i <= count; i++)
                {
                    links.Remove(links[i]);
                }
                _context.SaveChanges();
            }
        }
        public void DeleteComments(int id) // <--Get Post ID
        {
            using (var _context = new BlogContext())
            {
                var comments =
                    (from l in _context.Comments
                     where l.Id == id
                     select l).ToList();
                int count = comments.Count;
                for (int i = 0; i <= count-1; i++)
                {
                    
                    _context.Comments.Remove(comments[i]);

                        
                }
                _context.SaveChanges();
            }
        }
        public void DeletePost(int id) // <--Get Blog ID
        {
            var hashtagIdList = ReturnAllHashtagsFromPostId(id);
            foreach (var hashtag in hashtagIdList)
            {
                DeleteHashtags(hashtag);
            }
            var commentsIdList = ReturnAllCommentsFromPostId(id);
            foreach (var comment in commentsIdList)
            {
                DeleteComments(comment);
            }
            
            using (var _context = new BlogContext())
            {
                var query =
                    (from p in _context.Posts
                        where p.Id == id
                        select p).ToList();
                int count = query.Count;
                for (int i = 0; i <= count-1; i++)
                {
                    _context.Posts.Remove(query[i]);
                }

                _context.SaveChanges();
            }
        }

        private List<int> ReturnAllCommentsFromPostId(int postId)
        {
            using (var _context = new BlogContext())
            {
                return (from c in _context.Comments
                        where c.Post.Id == postId
                        select c.Id).ToList();
            }
        }

        public void DeleteBlogs(int blogId) // <--Get Blog ID
        {
            using (var _context = new BlogContext())
            {
                var posts =
                    (from p in _context.Posts
                        where p.Blog.Id == blogId
                        select p).ToList();
                int count = posts.Count;
                for (int i = 0; i <= count; i++)
                {
                    DeletePost(posts[i].Id);
                }
                _context.SaveChanges();
            }
            
            //using (var _context = new BlogContext())
            //{
            //    var blogs =
            //        (from l in _context.Blogs
            //         where l.Owner.Id == id
            //         select l).ToList();
            //    int count = blogs.Count;
            //    for (int i = 0; i < count; i++)
            //    {
            //        blogs.Remove(blogs[i]);
            //    }
            //    _context.SaveChanges();
            //}
        }

        

        public List<string> GetHashtagsThatContainString(string term)
        {
            using (var db = new BlogContext())
            {
                return(from b in db.Hashtags
                       where b.Tag.ToLower().Contains(term.ToLower())
                       select b.Tag).ToList();
            }
        }

        public void AddBlogToDatabase(Blog blog,int ownerId)
        {
            using (var _context = new BlogContext())
            {
                var owner =
                    (from o in _context.Owners
                     where o.Id == ownerId
                     select o).FirstOrDefault();

                if (owner != null)
                {
                    blog.DateTime = DateTime.Now;
                    owner.Blogs.Add(blog);
                    _context.SaveChanges();
                }
            }
        }

        public int ReturnOwnerId(string ownerName)
        {
            using (var _context = new BlogContext())
            {
                return (from o in _context.Owners
                        where o.UserName == ownerName
                        select o.Id).FirstOrDefault();
            }
        }

        public List<Post> GetPostHeaderByDate()
        {
            var _context = new BlogContext();
            var query =
                (from h in _context.Posts
                 orderby h.DateTime descending 
                 select h).Take(5).ToList();
            return query;
        }
    }
}
