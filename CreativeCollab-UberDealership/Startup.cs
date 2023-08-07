using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreativeCollab_UberDealership.Startup))]
namespace CreativeCollab_UberDealership
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
