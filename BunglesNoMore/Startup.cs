using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BunglesNoMore.Startup))]
namespace BunglesNoMore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
