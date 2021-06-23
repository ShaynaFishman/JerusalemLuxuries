using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JerusalemLuxuries.Startup))]
namespace JerusalemLuxuries
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
