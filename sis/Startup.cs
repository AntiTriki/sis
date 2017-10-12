using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sis.Startup))]
namespace sis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
