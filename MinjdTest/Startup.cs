using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MinjdTest.Startup))]
namespace MinjdTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
