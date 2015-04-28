using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlogClassLibrary;
using BlogClassLibrary.DataAccessLayer;

namespace AddBlogsAndUsersWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCountries.Text = "";
            var repository = new Repository();
            var user = repository.GetOwnersForWinForm(comboBoxUserNames.Text);
            foreach (var owner in user)
            {
                textBoxUserName.Text = owner.UserName;
                textBoxBlogName.Text = repository.GetBlogName(owner.UserName);
                textBoxFirstName.Text = owner.FirstName;
                textBoxLastName.Text = owner.LastName;
                textBoxEmail.Text = owner.Email;
                textBoxDescription.Text = owner.Description;
                textBoxCountry.Text = owner.Country;
                comboBoxCountries.SelectedText = owner.Country;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var _context = new BlogContext();
            comboBoxUserNames.DataSource = _context.Owners.ToList();
            comboBoxUserNames.DisplayMember = "UserName";
            comboBoxUserNames.Invalidate();
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            var lista = new Post();
            var repository = new Repository();
            var user = repository.GetOwnersForWinForm(comboBoxUserNames.Text);
            var _context = new BlogContext();
            if (textBoxPostHeader.Text == "" || textBoxPostContent.Text == "")
            {
                MessageBox.Show(
                    "You are missing either a header or content in your post, both text boxes must be populated!");
            }
            else
            {
                var post = new Post
                {
                    Content = "content, blal bla bla bla",
                    DateTime = DateTime.Now,
                    Header = "Min CoOla Post",
                    
                };


                repository.CreatePost(textBoxUserName.Text,textBoxBlogName.Text,textBoxPostHeader.Text,textBoxPostContent.Text);
                //foreach (var owner in user)
                //{
                //    owner.Blogs.ForEach(p => _context.Posts.Add(new Post { Header = textBoxPostHeader.Text, Content = textBoxPostContent.Text }));
                //}
                //foreach (var blog in _context.Blogs)
                //{
                //    if (blog.Name == textBoxBlogName.Text)
                //    {
                //        blog.Posts.Add(new Post{ Header = textBoxPostHeader.Text, Content = textBoxPostContent.Text });
                //    }
                //}
                //foreach (var owner in _context.Owners)
                //{
                //    foreach (var blog in owner.Blogs)
                //    {
                //        blog.Posts.Add(new Post { Header = textBoxPostHeader.Text, Content = textBoxPostContent.Text });
                //    }
                //}
                //_context.Posts.Add(new Post {Header = textBoxPostHeader.Text, Content = textBoxPostContent.Text});
                textBoxPostHeader.Text = "";
                textBoxPostContent.Text = "";
                //_context.SaveChanges();
            }
        }
    }
}
