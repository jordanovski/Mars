using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mars.Web.Startup))]
namespace Mars.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
