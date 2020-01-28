using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(WebApiTodo.App_Start.Startup))]

namespace WebApiTodo.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            var ninjectConfig = new NinjectConfig();

            ninjectConfig.ConfigureNinjectKernel(app);

            WebApiConfig.Register(config);

            ninjectConfig.ConfigureNinjectWebApi(app, config);
        }
    }
}