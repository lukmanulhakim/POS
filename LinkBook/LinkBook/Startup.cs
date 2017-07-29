using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinkBook.Startup))]
namespace LinkBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
