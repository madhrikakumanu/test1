using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UILayer.Startup))]
namespace UILayer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
