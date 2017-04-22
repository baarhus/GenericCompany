using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GenericCompany.Startup))]
namespace GenericCompany
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
