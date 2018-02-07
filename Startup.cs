using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BotShopOfficial.Startup))]
namespace BotShopOfficial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
