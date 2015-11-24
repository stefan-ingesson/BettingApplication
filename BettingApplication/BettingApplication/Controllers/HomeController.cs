﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using BettingApplication.Models;
using Newtonsoft.Json;

namespace BettingApplication.Controllers
{
  public class HomeController : Controller
  {
    private readonly ApplicationDbContext db = new ApplicationDbContext();

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
 private readonly SoccerApi.SoccerRestService game = new SoccerApi.SoccerRestService();
        
        public ActionResult GetSoccerApi()
        {
            return View("index", game.GetSoccerApi());
        } 


        public ActionResult Index()
        {
            return View();
        }

    public ActionResult MatchApi()
    {

      var client = new HttpClient();

      var game = new HttpRequestMessage
      {
        RequestUri = new Uri("http://api.football-data.org/v1/soccerseasons/398/fixtures?matchday=11"),
        Method = HttpMethod.Get
      };


      //game.Headers.Authorization = new AuthenticationHeaderValue("X-Auth-Token", "3a5878e758b14d71bd774070afd07d69");
      game.Headers.Add("X-Auth-Token", "3a5878e758b14d71bd774070afd07d69");

      HttpResponseMessage response = client.SendAsync(game).Result;

      if (response.StatusCode != HttpStatusCode.OK)
      {
        //return response.Content.ReadAsStringAsync().Result;
        throw new ArgumentException();
      }

      var fixtures = JsonConvert.DeserializeObject<Fixtures>(response.Content.ReadAsStringAsync().Result);

      return View(fixtures.fixtures);
    }

    //Upcoming Games in patial views
    public ActionResult _UpcomingGames()
    {
      var client = new HttpClient();

      var game = new HttpRequestMessage
      {
        RequestUri = new Uri("http://api.football-data.org/v1/soccerseasons/398/fixtures?matchday=15"),
        Method = HttpMethod.Get
      };

      game.Headers.Add("X-Auth-Token", "3a5878e758b14d71bd774070afd07d69");

      HttpResponseMessage response = client.SendAsync(game).Result;

      if (response.StatusCode != HttpStatusCode.OK)
      {
        //return response.Content.ReadAsStringAsync().Result;
        throw new ArgumentException();
      }

      var fixtures = JsonConvert.DeserializeObject<Fixtures>(response.Content.ReadAsStringAsync().Result);

      return PartialView(fixtures.fixtures);
    }

    public ActionResult PlaceBets()
    {
      return View();
    }
  }
}