using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitApp.Startup))]
namespace GitApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
