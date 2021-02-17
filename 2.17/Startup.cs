using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2._17.Startup))]
namespace _2._17
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
