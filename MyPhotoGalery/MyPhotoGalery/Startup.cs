using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPhotoGalery.Startup))]
namespace MyPhotoGalery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
