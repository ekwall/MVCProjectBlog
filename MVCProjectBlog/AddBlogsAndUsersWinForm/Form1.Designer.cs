namespace AddBlogsAndUsersWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxUserNames = new System.Windows.Forms.ComboBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelUsernames = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelChooseCountry = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.buttonAddPost = new System.Windows.Forms.Button();
            this.labelBlogName = new System.Windows.Forms.Label();
            this.textBoxBlogName = new System.Windows.Forms.TextBox();
            this.labelPostHeader = new System.Windows.Forms.Label();
            this.textBoxPostHeader = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.textBoxPostContent = new System.Windows.Forms.TextBox();
            this.repositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxUserNames
            // 
            this.comboBoxUserNames.FormattingEnabled = true;
            this.comboBoxUserNames.Items.AddRange(new object[] {
            "Username"});
            this.comboBoxUserNames.Location = new System.Drawing.Point(145, 12);
            this.comboBoxUserNames.Name = "comboBoxUserNames";
            this.comboBoxUserNames.Size = new System.Drawing.Size(148, 21);
            this.comboBoxUserNames.TabIndex = 0;
            this.comboBoxUserNames.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(145, 39);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.ReadOnly = true;
            this.textBoxUserName.Size = new System.Drawing.Size(148, 20);
            this.textBoxUserName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(145, 94);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(148, 20);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(145, 120);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(148, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(145, 146);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(148, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // labelUsernames
            // 
            this.labelUsernames.AutoSize = true;
            this.labelUsernames.Location = new System.Drawing.Point(43, 15);
            this.labelUsernames.Name = "labelUsernames";
            this.labelUsernames.Size = new System.Drawing.Size(63, 13);
            this.labelUsernames.TabIndex = 6;
            this.labelUsernames.Text = "Usernames:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(48, 42);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(58, 13);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "Username:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(51, 97);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(55, 13);
            this.labelFirstName.TabIndex = 8;
            this.labelFirstName.Text = "Firstname:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(48, 123);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 9;
            this.labelLastName.Text = "Lastname:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(66, 149);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelChooseCountry
            // 
            this.labelChooseCountry.AutoSize = true;
            this.labelChooseCountry.Location = new System.Drawing.Point(10, 301);
            this.labelChooseCountry.Name = "labelChooseCountry";
            this.labelChooseCountry.Size = new System.Drawing.Size(96, 13);
            this.labelChooseCountry.TabIndex = 11;
            this.labelChooseCountry.Text = "Choose country -->";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(43, 201);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(145, 198);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(199, 79);
            this.textBoxDescription.TabIndex = 13;
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Items.AddRange(new object[] {
            "Albania",
            "Andorra",
            "Armenia",
            "Austria",
            "Azerbaijan",
            "Belarus",
            "Belgium",
            "Bosnia and Herzegovina",
            "Bulgaria",
            "Croatia",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Estonia",
            "Finland",
            "France",
            "Georgia",
            "Germany",
            "Greece",
            "Hungary",
            "Iceland",
            "Ireland",
            "Italy",
            "Kazakhstan",
            "Kosovo",
            "Latvia",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Malta",
            "Moldova",
            "Monaco",
            "Montenegro",
            "Netherlands",
            "Norway",
            "Poland",
            "Portugal",
            "Romania",
            "Russia",
            "San Marino",
            "Serbia",
            "Slovakia",
            "Slovenia",
            "Spain",
            "Sweden",
            "Switzerland",
            "Turkey",
            "Ukraine",
            "United Kingdom"});
            this.comboBoxCountries.Location = new System.Drawing.Point(145, 298);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(148, 21);
            this.comboBoxCountries.TabIndex = 5;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(145, 172);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.ReadOnly = true;
            this.textBoxCountry.Size = new System.Drawing.Size(148, 20);
            this.textBoxCountry.TabIndex = 14;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(58, 175);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(46, 13);
            this.labelCountry.TabIndex = 15;
            this.labelCountry.Text = "Country:";
            // 
            // buttonAddPost
            // 
            this.buttonAddPost.Location = new System.Drawing.Point(402, 283);
            this.buttonAddPost.Name = "buttonAddPost";
            this.buttonAddPost.Size = new System.Drawing.Size(325, 36);
            this.buttonAddPost.TabIndex = 16;
            this.buttonAddPost.Text = "Add post";
            this.buttonAddPost.UseVisualStyleBackColor = true;
            this.buttonAddPost.Click += new System.EventHandler(this.buttonAddPost_Click);
            // 
            // labelBlogName
            // 
            this.labelBlogName.AutoSize = true;
            this.labelBlogName.Location = new System.Drawing.Point(46, 71);
            this.labelBlogName.Name = "labelBlogName";
            this.labelBlogName.Size = new System.Drawing.Size(60, 13);
            this.labelBlogName.TabIndex = 17;
            this.labelBlogName.Text = "Blog name:";
            // 
            // textBoxBlogName
            // 
            this.textBoxBlogName.Location = new System.Drawing.Point(145, 68);
            this.textBoxBlogName.Name = "textBoxBlogName";
            this.textBoxBlogName.ReadOnly = true;
            this.textBoxBlogName.Size = new System.Drawing.Size(148, 20);
            this.textBoxBlogName.TabIndex = 18;
            // 
            // labelPostHeader
            // 
            this.labelPostHeader.AutoSize = true;
            this.labelPostHeader.Location = new System.Drawing.Point(343, 15);
            this.labelPostHeader.Name = "labelPostHeader";
            this.labelPostHeader.Size = new System.Drawing.Size(45, 13);
            this.labelPostHeader.TabIndex = 19;
            this.labelPostHeader.Text = "Header:";
            // 
            // textBoxPostHeader
            // 
            this.textBoxPostHeader.Location = new System.Drawing.Point(402, 12);
            this.textBoxPostHeader.Name = "textBoxPostHeader";
            this.textBoxPostHeader.Size = new System.Drawing.Size(325, 20);
            this.textBoxPostHeader.TabIndex = 20;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(357, 42);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(31, 13);
            this.labelPost.TabIndex = 21;
            this.labelPost.Text = "Post:";
            // 
            // textBoxPostContent
            // 
            this.textBoxPostContent.Location = new System.Drawing.Point(402, 39);
            this.textBoxPostContent.Multiline = true;
            this.textBoxPostContent.Name = "textBoxPostContent";
            this.textBoxPostContent.Size = new System.Drawing.Size(325, 238);
            this.textBoxPostContent.TabIndex = 22;
            // 
            // repositoryBindingSource
            // 
            this.repositoryBindingSource.DataSource = typeof(BlogClassLibrary.DataAccessLayer.Repository);
            // 
            // repositoryBindingSource1
            // 
            this.repositoryBindingSource1.DataSource = typeof(BlogClassLibrary.DataAccessLayer.Repository);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 342);
            this.Controls.Add(this.textBoxPostContent);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.textBoxPostHeader);
            this.Controls.Add(this.labelPostHeader);
            this.Controls.Add(this.textBoxBlogName);
            this.Controls.Add(this.labelBlogName);
            this.Controls.Add(this.buttonAddPost);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelChooseCountry);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelUsernames);
            this.Controls.Add(this.comboBoxCountries);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.comboBoxUserNames);
            this.Name = "Form1";
            this.Text = "Add post";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUserNames;
        private System.Windows.Forms.BindingSource repositoryBindingSource;
        private System.Windows.Forms.BindingSource repositoryBindingSource1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelUsernames;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelChooseCountry;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Button buttonAddPost;
        private System.Windows.Forms.Label labelBlogName;
        private System.Windows.Forms.TextBox textBoxBlogName;
        private System.Windows.Forms.Label labelPostHeader;
        private System.Windows.Forms.TextBox textBoxPostHeader;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.TextBox textBoxPostContent;
    }
}

