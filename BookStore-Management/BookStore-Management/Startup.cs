using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookStore_Management.Startup))]
namespace BookStore_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
