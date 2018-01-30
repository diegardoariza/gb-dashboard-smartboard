using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GBDashboard.Startup))]
namespace GBDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
