using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Html5.Startup))]
namespace Html5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
