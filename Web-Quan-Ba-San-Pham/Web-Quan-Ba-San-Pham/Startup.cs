using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Quan_Ba_San_Pham.Startup))]
namespace Web_Quan_Ba_San_Pham
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
