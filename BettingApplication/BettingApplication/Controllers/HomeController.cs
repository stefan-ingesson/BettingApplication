
using BettingApplication.Models;
using BettingApplication.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

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



        //private RestService service = new RestService();

        //public async Task<ActionResult> ListTable()
        //{
        //    Task<List<LeagueTable>> task = service.GetTablesAsync();
        //    return View(await service.GetTablesAsync());
        //}




    
        public ViewResult ListTable()
        {


            var client = new HttpClient();

        


            HttpRequestMessage table = new HttpRequestMessage
            {
                RequestUri = new Uri("http://api.football-data.org/alpha/soccerseasons/398/leagueTable"),
                Method = HttpMethod.Get
            };



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
                
            return View(leagueTable.standing);

        }

   



        //public ActionResult ListTable()
        //{
        //    var list = new List<LeagueTable>();

        //    return View(list);
        //}

        //private LeagueTableREST table = new LeagueTableREST();


        //public string ListTable()
        //{
        //    var client = new HttpClient();
        //    HttpRequestMessage message = new HttpRequestMessage();
        //    message.RequestUri = new Uri("http://api.football-data.org/alpha/soccerseasons/398/leagueTable");
        //    message.Method = HttpMethod.Get;
        //    message.Headers.Authorization = new AuthenticationHeaderValue("X-Auth-Token", "3a5878e758b14d71bd774070afd07d69");
        //    message.Content = new StringContent("grant_type=client_credentials", Encoding.UTF8);
        //    message.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

        //    var response = client.SendAsync(message).Result;
        //    if (response.StatusCode != HttpStatusCode.OK)
        //    {
        //        return response.Content.ReadAsStringAsync().Result;
        //    }

        //    LeagueTable leagueTable = JsonConvert.DeserializeObject<LeagueTable>(response.Content.ReadAsStringAsync().Result);

        //    return View();
        //}

   
    


        //private LeagueTableREST table = new LeagueTableREST();
        //public ActionResult LeagueTable()
        //{
        //    Uri uri = new Uri(@"http://api.football-data.org/alpha/soccerseasons/398/leagueTable");
        //    WebRequest webRequest = WebRequest.Create(uri);
        //    WebResponse response = webRequest.GetResponse();
        //    StreamReader streamReader = new StreamReader(response.GetResponseStream());
        //    String responseData = streamReader.ReadToEnd();
        //    var outObject = JsonConvert.DeserializeObject<BettingApplication.Models.LeagueTable>(responseData);
        //    return View(responseData);
        //    //return View("LeagueTable", table.GetLeagueTable());
        //}


        //private FootballGameREST game = new FootballGameREST();


        //public ActionResult FootballGame()
        //{
        //    return View("FootballGame", game.GetFootballGames());
        //}
    }
}