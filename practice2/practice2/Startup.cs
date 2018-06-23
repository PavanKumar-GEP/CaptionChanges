using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(practice2.Startup))]
namespace practice2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
