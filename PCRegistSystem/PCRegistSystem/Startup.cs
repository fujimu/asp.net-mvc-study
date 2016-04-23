using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCRegistSystem.Startup))]
namespace PCRegistSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
