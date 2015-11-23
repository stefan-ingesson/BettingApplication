
using BettingApplication.Models;

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


    
        public ViewResult ListTable()
        {


            var client = new HttpClient();

            HttpRequestMessage table = new HttpRequestMessage
            {
                RequestUri = new Uri("http://api.football-data.org/alpha/soccerseasons/398/leagueTable"),
                Method = HttpMethod.Get
            };


            #region Den här fungerar inte!
            //table.Headers.Authorization = new AuthenticationHeaderValue("X-Auth-Token", "insert token here");
            #endregion

            table.Headers.Add("X-Auth-Token", "insert token here");

            var response = client.SendAsync(table).Result;

            if (response.StatusCode != HttpStatusCode.OK)
            {
                //return response.Content.ReadAsStringAsync().Result;
                throw new ArgumentException();
            }

            LeagueTable leagueTable = JsonConvert.DeserializeObject<LeagueTable>(response.Content.ReadAsStringAsync().Result);              
            return View("ListTable",leagueTable.standing);

        }

   


    }
}
