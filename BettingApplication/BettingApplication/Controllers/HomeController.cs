using System.IO;
using System.Net;
using BettingApplication.Models;
using BettingApplication.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BettingApplication.Controllers.Api;
using Newtonsoft.Json;

namespace BettingApplication.Controllers
{
    public class HomeController : Controller
    {
  
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

        public ActionResult MatchApi()
        {
          Task<List<Fixtures.Fixture>> task = new Task<List<Fixtures.Fixture>>(GetTheApi());

          return View(task);
        }
    }
}