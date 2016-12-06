using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zenithsociety.Startup))]
namespace zenithsociety
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
