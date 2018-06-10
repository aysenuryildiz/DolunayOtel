using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DolunayOtel.Startup))]
namespace DolunayOtel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
