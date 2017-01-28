using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChaosMVCFIRSTAPP.Startup))]
namespace ChaosMVCFIRSTAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
