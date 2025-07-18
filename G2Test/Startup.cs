using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(G2Test.Startup))]
namespace G2Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
