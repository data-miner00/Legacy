using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Legacy.Webforms.Startup))]
namespace Legacy.Webforms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
