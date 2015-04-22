using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace BlogClassLibrary.DataAccessLayer
{
    public class ContextInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        private List<Owner> owners;
        private List<Blog> blogs;
        private List<Link> links;
        private List<Post> posts;
        private List<Hashtag> hashtags;
        private List<Comment> comments;

        public ContextInitializer()
        {
            comments = new List<Comment>
            {
                new Comment{Author = "Robin",AuthorEmail = "nibor@sdrowkcab.es",Content = "You're my Hero! I love u Neil (L)",DateTime = DateTime.Now}
            };
            hashtags= new List<Hashtag>
            {
                new Hashtag{Tag = "#lagabullin"},
                new Hashtag{Tag = "#whiskey"}
            };
            posts = new List<Post>
            {
                new Post{DateTime = DateTime.Now,Content = "Today I drank a lot of whiskey, lagabullin!",Header = "Drank lagabullin",Hashtag = hashtags,Comments = comments}
            };
            links = new List<Link>
            {
                new Link{HyperLink = "www.whiskey.uk"},
                new Link{HyperLink = "www.whiskey4u.uk"},
                new Link{HyperLink = "www.systembolaget.se"}
            };
            blogs = new List<Blog>
            {
                new Blog
                {
                    Name = "Whiskey",
                    Description = "This blog is about drinking whiskey, please join me´",
                    DateTime = DateTime.Now,Links = links,Posts = posts
                }
            };
            owners = new List<Owner>
            {
                new Owner{UserName = "FreedomFighter",FirstName = "Neil",LastName = "Kirkpatrick",Country = "Scotland",Email = "neil@angryscottsman.uk",Blogs = blogs,Description = "I'm a guy with 37 earthspins, who lives in Edinburgh with my wifey(wi-fi)!"}
            };
        }




        public override void InitializeDatabase(BlogContext context)
        {
            owners.ForEach(o => context.Owners.Add(o));
            base.InitializeDatabase(context);
        }
    }
}
