using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CScherpProject.Startup))]
namespace CScherpProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
