using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoStoreExample.Startup))]
namespace VideoStoreExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
