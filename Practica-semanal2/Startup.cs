using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practica_semanal2.Startup))]
namespace Practica_semanal2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
