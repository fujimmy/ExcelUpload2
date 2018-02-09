using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExcelUpload.Startup))]
namespace ExcelUpload
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
