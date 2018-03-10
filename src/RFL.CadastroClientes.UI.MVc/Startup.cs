using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RFL.CadastroClientes.UI.MVc.Startup))]
namespace RFL.CadastroClientes.UI.MVc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
