using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BurnOutDev.Exams.Web.Startup))]
namespace BurnOutDev.Exams.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
