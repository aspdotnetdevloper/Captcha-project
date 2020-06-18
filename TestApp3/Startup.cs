using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestApp3.Startup))]
namespace TestApp3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
