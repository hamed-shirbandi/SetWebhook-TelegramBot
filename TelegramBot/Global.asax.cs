using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CodeBlock.Bot.Engine
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            try
            {
                AreaRegistration.RegisterAllAreas();
                GlobalConfiguration.Configure(WebApiConfig.Register);
                FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
                RouteConfig.RegisterRoutes(RouteTable.Routes);
                BundleConfig.RegisterBundles(BundleTable.Bundles);


                Telegram.Bot.Api bot = new Telegram.Bot.Api("Your_Bot_Token");
                bot.SetWebhook("https://site.com/api/webhook").Wait();

            }
            catch
            {
                HttpRuntime.UnloadAppDomain();
                throw;
            }
        }

        

    }
}
