using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCStartingApplication.Startup))]
namespace MVCStartingApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
