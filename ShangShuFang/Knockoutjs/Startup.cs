using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Knockoutjs.Startup))]
namespace Knockoutjs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
