using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MEF2.Startup))]
namespace MEF2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
