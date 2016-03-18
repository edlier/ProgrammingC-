using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConnectSAP.Startup))]
namespace ConnectSAP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
