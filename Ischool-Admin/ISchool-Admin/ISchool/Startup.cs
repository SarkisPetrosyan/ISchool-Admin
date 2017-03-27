using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISchool.Startup))]
namespace ISchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
