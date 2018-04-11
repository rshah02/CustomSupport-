using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerServiceFacilitation.Startup))]
namespace CustomerServiceFacilitation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
