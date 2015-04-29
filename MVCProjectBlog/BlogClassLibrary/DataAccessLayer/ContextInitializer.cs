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
                new Post{DateTime = DateTime.Now, Postimage = "http://deverespub.com/wp-content/uploads/2011/06/whiskey-banner-1.jpg",Content = "Today I drank a lot of whiskey, lagavullin!",Header = "Drank lagavullin",Hashtags = hashtags,Comments = comments}
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
                },
                new Blog
                {
                    Name = "Kittens drinkin Whiskey",
                    Description = "This blog is about kittens drinking whiskey, please join me´",
                    DateTime = DateTime.Now,Links = new List<Link>
                    {
                        new Link()
                        {
                            HyperLink = "www.lolcats.com"
                        }
                    },Posts = new List<Post>
                    {
                        new Post()
                        {
                            Header = "This is Hilarious", 
                            Content = "omg omg omg I just saw a frikkin walish kitten drink melk. Walish kittens are such bunch of ol' wankeeeeeeeerss",
                            DateTime = new DateTime(2015,03,03),
                            Postimage = "http://www.2naturalhealers.co.uk/image/root/slide-3/918/349/",
                            Comments = new List<Comment>{new Comment
                            {
                                Author = "Jakob",
                                AuthorEmail = "aaa@eee.com",
                                Content = "Hahahaha true dat dawgh!!",
                                DateTime = new DateTime(2015,04,01)
                            }},Hashtags = new List<Hashtag>
                            {
                                new Hashtag
                                {
                                    Tag = "#Walish"
                                },
                                new Hashtag
                                {
                                    Tag = "Kitten"
                                }
                            }
                        }
                    }
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
