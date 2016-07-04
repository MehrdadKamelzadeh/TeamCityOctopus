using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OctopusTeamcityModise.Startup))]
namespace OctopusTeamcityModise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
