using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Doando.Ui.Startup))]
namespace Doando.Ui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
