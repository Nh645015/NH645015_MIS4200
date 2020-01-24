using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NH645015_MIS4200.Startup))]
namespace NH645015_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
