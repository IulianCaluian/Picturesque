using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Picturesque.Startup))]
namespace Picturesque
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
