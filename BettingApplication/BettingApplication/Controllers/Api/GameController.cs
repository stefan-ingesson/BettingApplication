using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Mvc;
using BettingApplication.Models;
using Newtonsoft.Json;

namespace BettingApplication.Controllers.Api
{
  public class GameController : ApiController
    {
    readonly Fixtures.FixtureEntities _db = new Fixtures.FixtureEntities();

        [System.Web.Http.HttpGet]
        public string GetTheApi(int id)
        {
          var client = new HttpClient();

          HttpRequestMessage game = new HttpRequestMessage
            {
              RequestUri = new Uri("http://api.football-data.org/alpha/fixtures/133566"),
              Method = HttpMethod.Get
            };

          game.Headers.Authorization = new AuthenticationHeaderValue("X-Auth-Token", "3a5878e758b14d71bd774070afd07d69");

          var response = client.SendAsync(game).Result;

              if (response.StatusCode != HttpStatusCode.OK)
              {
                return response.Content.ReadAsStringAsync().Result;
              }

          var fixture = JsonConvert.DeserializeObject<Fixtures.Fixture>(response.Content.ReadAsStringAsync().Result);

          return fixture.ToString();

        }   
    }
}
