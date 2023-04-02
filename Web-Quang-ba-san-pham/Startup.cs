using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Quang_ba_san_pham.Startup))]
namespace Web_Quang_ba_san_pham
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
