using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Playlists.Startup))]
namespace Playlists
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
