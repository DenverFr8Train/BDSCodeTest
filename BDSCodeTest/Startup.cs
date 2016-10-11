using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BDSCodeTest.Startup))]
namespace BDSCodeTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
