using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScheduledParser.Startup))]
namespace ScheduledParser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
