using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamNgocHai_2090694876.Startup))]
namespace PhamNgocHai_2090694876
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
