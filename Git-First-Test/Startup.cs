using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git_First_Test.Startup))]
namespace Git_First_Test
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
