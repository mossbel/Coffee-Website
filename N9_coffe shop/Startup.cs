using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(N9_coffe_shop.Startup))]
namespace N9_coffe_shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
