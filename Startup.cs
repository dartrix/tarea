using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tarea_3.Startup))]
namespace tarea_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
