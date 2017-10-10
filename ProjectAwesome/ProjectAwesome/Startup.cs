using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectAwesome.Startup))]
namespace ProjectAwesome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
