using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrameworkMVCExample.Startup))]
namespace FrameworkMVCExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
