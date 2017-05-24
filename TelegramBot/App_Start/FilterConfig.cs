using System.Web;
using System.Web.Mvc;

namespace CodeBlock.Bot.Engine
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
