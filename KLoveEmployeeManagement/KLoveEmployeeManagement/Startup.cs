using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KLoveEmployeeManagement.Startup))]
namespace KLoveEmployeeManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
