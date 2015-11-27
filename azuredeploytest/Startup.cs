using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(azuredeploytest.Startup))]
namespace azuredeploytest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
