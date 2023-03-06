using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HiepHuynh_2011061513.Startup))]
namespace HiepHuynh_2011061513
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
