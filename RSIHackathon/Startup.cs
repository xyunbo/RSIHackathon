using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RSIHackathon.Startup))]
namespace RSIHackathon
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
