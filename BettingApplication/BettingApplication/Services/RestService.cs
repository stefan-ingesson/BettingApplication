using BettingApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace BettingApplication.Services
{
    public class RestService
    {
        readonly string uri = "http://api.football-data.org/alpha/soccerseasons/398/leagueTable";

        public async Task<List<LeagueTable>> GetTablesAsync()
        {
            using (HttpClient client = new HttpClient())
            {

                HttpRequestMessage table = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://api.football-data.org/alpha/soccerseasons/398/leagueTable"),
                    Method = HttpMethod.Get
                };

                table.Headers.Add("X-Auth-Token", "94212a25154c472696f2be2ee25e9691");

                var response = client.SendAsync(table).Result;

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    //return response.Content.ReadAsStringAsync().Result;
                    throw new ArgumentException();
                }
                LeagueTable leagueTable = JsonConvert.DeserializeObject<LeagueTable>(response.Content.ReadAsStringAsync().Result);
                return JsonConvert.DeserializeObject<List<LeagueTable>>(
                    await client.GetStringAsync(uri)
                    );
            }
        }
    }
}