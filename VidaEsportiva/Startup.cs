using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidaEsportivaView.Startup))]
namespace VidaEsportivaView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
