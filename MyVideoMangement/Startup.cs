using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyVideoMangement.Startup))]
namespace MyVideoMangement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
