using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp18102017.Startup))]
namespace WebApp18102017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
