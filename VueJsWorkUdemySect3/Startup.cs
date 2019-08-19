using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VueJsWorkUdemySect3.Startup))]
namespace VueJsWorkUdemySect3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
