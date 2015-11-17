using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BettingApplication.Controllers
{
    public class HomeController : Controller
    {

        private readonly SoccerApi.SoccerRestService game = new SoccerApi.SoccerRestService();
        
        public ActionResult GetSoccerApi()
        {
            return View("index", game.GetSoccerApi());
        } 


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}