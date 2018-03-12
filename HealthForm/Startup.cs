using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthForm.Startup))]
namespace HealthForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
