using Microsoft.Owin;
using Owin;
using ProManager.BL.Data;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(ProManager.API.Startup))]

namespace ProManager.API
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            // COnfigure Context to use a singleton instance per request
            app.CreatePerOwinContext(ProManagerContext.Create);
        }
    }
}
