using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCProjcetBlogWithLogin.Startup))]
namespace MVCProjcetBlogWithLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
