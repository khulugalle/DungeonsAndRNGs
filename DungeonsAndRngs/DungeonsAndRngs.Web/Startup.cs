using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DungeonsAndRngs.Web.Startup))]
namespace DungeonsAndRngs.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
