using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaDevOpsWeb.Client.Startup))]
namespace PizzaDevOpsWeb.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
