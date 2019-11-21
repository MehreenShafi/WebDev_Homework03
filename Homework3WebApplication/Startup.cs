using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homework3WebApplication.Startup))]
namespace Homework3WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
