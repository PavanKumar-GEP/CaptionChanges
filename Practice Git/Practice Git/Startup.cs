using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practice_Git.Startup))]
namespace Practice_Git
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
