using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartSuite.Startup))]
namespace SmartSuite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
