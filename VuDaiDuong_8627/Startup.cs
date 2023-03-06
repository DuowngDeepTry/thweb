using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VuDaiDuong_8627.Startup))]
namespace VuDaiDuong_8627
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
