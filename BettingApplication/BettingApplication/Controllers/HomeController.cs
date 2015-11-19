using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using BettingApplication.Models;
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
      var list = new List<Fixtures.Fixture>();
      //Task<List<Fixtures.Fixture>> task = new Task<List<Fixtures.Fixture>>(fixture);

      return View(list);
    }
  }
}