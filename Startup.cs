using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Futurevalue.Startup))]
namespace Futurevalue
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
