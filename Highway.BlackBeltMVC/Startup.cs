using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Highway.BlackBeltMVC.Startup))]
namespace Highway.BlackBeltMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
