using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoGet.Startup))]
namespace GoGet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
