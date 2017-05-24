using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CodeBlock.Bot.Engine.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public async Task<ActionResult> Index()
        {
            ////فراخوانی متد GET 
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("www.yoursite.com");
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    HttpResponseMessage response = await client.GetAsync("/api/webhook/");
            //    if (!response.IsSuccessStatusCode)
            //    {
            //       // 
                 
            //    }
            //}

            return View();
        }



    }
}
