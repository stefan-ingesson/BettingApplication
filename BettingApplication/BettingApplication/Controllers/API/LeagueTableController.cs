using BettingApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;



namespace BettingApplication.Controllers.API
{
    public class LeagueTableController : ApiController
    {
        // GET: api/LeagueTable
        [System.Web.Http.AcceptVerbs("GET")]
        [System.Web.Http.HttpGet]
        public JsonResult<LeagueTable> GetLeagueTable()
        {
            var client = new HttpClient();

            //HttpRequestMessage table= new HttpRequestMessage();
            //table.RequestUri = new Uri("http://api.football-data.org/alpha/soccerseasons/398/leagueTable");
            //table.Method = HttpMethod.Get;


            HttpRequestMessage table = new HttpRequestMessage
              {
                  RequestUri = new Uri("http://api.football-data.org/alpha/soccerseasons/398/leagueTable"),
                  Method = HttpMethod.Get
              };

            //table.Method = HttpMethod.Get;

#region Den här fungerar inte!
            //table.Headers.Authorization = new AuthenticationHeaderValue("X-Auth-Token", "94212a25154c472696f2be2ee25e9691");
#endregion

            table.Headers.Add("X-Auth-Token", "94212a25154c472696f2be2ee25e9691");

            var response = client.SendAsync(table).Result;

            if (response.StatusCode != HttpStatusCode.OK)
            {
                //return response.Content.ReadAsStringAsync().Result;
                throw new ArgumentException();
            }

            LeagueTable leagueTable = JsonConvert.DeserializeObject<LeagueTable>(response.Content.ReadAsStringAsync().Result);


            
           //var standing = leagueTable.standing;
           //var leagueCaption = leagueTable.leagueCaption;
           //var matchday = leagueTable.matchday;
           //var _links = leagueTable._links;

            return Json(leagueTable);

        }



        //[HttpGet]
        //public JsonResult<LeagueTable> GetLeagueTable()
        //{
        //    var client = new HttpClient();
        //    HttpRequestMessage message = new HttpRequestMessage();
        //    message.RequestUri = new Uri("http://api.football-data.org/alpha/soccerseasons/398/leagueTable");
        //    message.Method = HttpMethod.Get;
        //    message.Headers.Authorization = new AuthenticationHeaderValue("X-Auth-Token", "94212a25154c472696f2be2ee25e9691");

        //    var response = client.SendAsync(message).Result;
        //    if (response.StatusCode != HttpStatusCode.OK)
        //    {

        //        //return response.Content.ReadAsStringAsync().Result;
        //        throw new ArgumentException();
        //    }

        //    LeagueTable leagueTable = JsonConvert.DeserializeObject<LeagueTable>(response.Content.ReadAsStringAsync().Result);

        //    return Json(leagueTable);
        //}
        

        // GET: api/LeagueTable/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LeagueTable
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LeagueTable/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LeagueTable/5
        public void Delete(int id)
        {
        }
    }
}
