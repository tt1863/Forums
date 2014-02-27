using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Forums.Startup))]
namespace Forums
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
