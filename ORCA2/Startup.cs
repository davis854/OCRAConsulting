using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ORCA2.Startup))]
namespace ORCA2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
