using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web3_23._06._2019_.Startup))]
namespace Web3_23._06._2019_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
