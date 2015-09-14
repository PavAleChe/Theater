using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Theater.Startup))]
namespace Theater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
