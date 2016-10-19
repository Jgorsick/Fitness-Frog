using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fitness_Frog.Startup))]
namespace Fitness_Frog
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
