using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenVanKhanh.Startup))]
namespace NguyenVanKhanh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
