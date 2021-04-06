using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngelBd.Startup))]
namespace AngelBd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
