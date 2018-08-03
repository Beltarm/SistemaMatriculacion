using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaMatriculacion.Startup))]
namespace SistemaMatriculacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
