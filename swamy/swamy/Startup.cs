using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(swamy.Startup))]
namespace swamy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
