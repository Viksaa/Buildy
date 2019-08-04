using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Buildy.Startup))]
namespace Buildy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
