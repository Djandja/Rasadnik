using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rasadnik.Startup))]
namespace Rasadnik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
