using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShipDay.Startup))]
namespace ShipDay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
