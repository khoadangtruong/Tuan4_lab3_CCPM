using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(khoa123.Startup))]
namespace khoa123
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
