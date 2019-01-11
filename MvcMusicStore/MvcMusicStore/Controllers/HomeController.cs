using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConsoleAPI.connon;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index1()
        {
            var data = WeatherHelper.GetWeatherByCityName("柳州");
            return View(data );
        }
    }
}