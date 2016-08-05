using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PenthiumProject.Startup))]
namespace PenthiumProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
