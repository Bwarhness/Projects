using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Schoolplanner.Startup))]
namespace Schoolplanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
