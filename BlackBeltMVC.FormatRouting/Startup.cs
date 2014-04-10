using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlackBeltMVC.FormatRouting.Startup))]
namespace BlackBeltMVC.FormatRouting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
