using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP220211V3.Startup))]
namespace ASP220211V3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
