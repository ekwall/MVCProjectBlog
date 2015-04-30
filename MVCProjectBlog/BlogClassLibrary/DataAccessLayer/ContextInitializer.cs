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
                 new Post{DateTime = DateTime.Now, Postimage = "http://deverespub.com/wp-content/uploads/2011/06/whiskey-banner-1.jpg",Content = "Today I drank a lot of whiskey, lagabullin! Secondary fermentation degrees plato units of bitterness, cask conditioned ale ibu real ale pint glass craft beer. krausen goblet grainy ibu brewhouse lagering finishing hops. Trappist, black malt chocolate malt balthazar gravity dextrin saccharification trappist final gravity. Aau scotch ale, adjunct. hops bung infusion, cask conditioning pitching malt extrac",Header = "Drank lagabullin",Hashtags = hashtags,Comments = comments},

                new Post{DateTime = DateTime.Now, Postimage = "http://deverespub.com/wp-content/uploads/2011/06/whiskey-banner-1.jpg", Content = "Lucas ipsum dolor sit amet dagobah hutt skywalker wookiee gonk calrissian calamari jango sith luke. Antilles leia antilles windu lobot darth coruscant solo. Palpatine qui-gonn moff lando padmé droid. Organa aayla windu kenobi mara ackbar. Owen skywalker solo fisto mace kashyyyk. Darth sith qui-gonn naboo dantooine dooku kenobi windu. Boba hutt solo dantooine fett vader thrawn padmé darth. Moff fett vader organa solo jar. Coruscant obi-wan solo moff skywalker anakin bespin. Twi'lek hutt qui-gonn jango droid moff.", Header = "Nothing to drink, watching Star wars",  Comments = new List<Comment>{new Comment
                            {
                                Author = "Robin",
                                AuthorEmail = "aaa@eee.com",
                                Content = "I love star wars!!",
                                DateTime = new DateTime(2015,04,01)
                            }},Hashtags = new List<Hashtag>
                            {
                                new Hashtag
                                {
                                    Tag = "#StarWars"
                                },
                                new Hashtag
                                {
                                    Tag = "Wookie"
                                }
                            } }
               
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
                },
                new Blog
                {
                    Name = "Atari shall rule once more",
                    Description = "Bloggin about the upcoming Atari invasion!",
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
                            Header = "Rise of the old machines", 
                            Content = "Atari skall crush yer all!",
                            DateTime = new DateTime(2015,03,03),
                            Postimage = "http://www.klennerit.de/wp-content/uploads/2013/04/Slide_3-918x349.jpg ",
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
                                    Tag = "#Atari"
                                },
                                new Hashtag
                                {
                                    Tag = "#worldOrder"
                                }
                            }
                        }
                    }
                }
            };
            owners = new List<Owner>
            {
                new Owner{UserName = "FreedomFighter", Password = "123", FirstName = "Neil",LastName = "Kirkpatrick",Country = "Scotland",Email = "neil@angryscottsman.uk",Blogs = blogs,Description = "I'm a guy with 37 earthspins, who lives in Edinburgh with my wifey(wi-fi)!"}
            };
        }




        public override void InitializeDatabase(BlogContext context)
        {
            owners.ForEach(o => context.Owners.Add(o));
            base.InitializeDatabase(context);
        }
    }
}
