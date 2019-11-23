using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CwrkWebApp.Startup))]
namespace CwrkWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
