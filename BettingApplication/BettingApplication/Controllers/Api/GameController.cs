﻿using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using BettingApplication.Models;
using Newtonsoft.Json;

namespace BettingApplication.Controllers.Api
{
  public class GameController : ApiController
  {
    private readonly Fixtures.FixtureEntities _db = new Fixtures.FixtureEntities();

    [HttpGet]
    public JsonResult<Fixtures> GetTheApi(int id)
    {
      var client = new HttpClient();

      var game = new HttpRequestMessage
      {
        RequestUri = new Uri("http://api.football-data.org/alpha/fixtures/133566"),
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

      var fixture = JsonConvert.DeserializeObject<Fixtures>(response.Content.ReadAsStringAsync().Result);

      return Json(fixture);
    }
  }
}