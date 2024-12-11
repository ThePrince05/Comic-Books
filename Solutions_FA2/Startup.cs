using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Solutions_FA2.Startup))]
namespace Solutions_FA2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
