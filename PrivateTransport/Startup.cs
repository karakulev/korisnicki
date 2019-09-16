using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrivateTransport.Startup))]
namespace PrivateTransport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
