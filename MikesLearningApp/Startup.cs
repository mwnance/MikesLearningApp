using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MikesLearningApp.Startup))]
namespace MikesLearningApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
