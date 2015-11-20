////using System;
////using System.Collections.Generic;
////using System.IO;
////using System.Linq;
////using System.Net;
////using System.Net.Http;
////using System.Runtime.Serialization.Json;
////using System.Text;
////using System.Web;
////using System.Xml.Linq;

//using BettingApplication.Models;
//using System.IO;
////namespace BettingApplication.Models
////{
//    using System.Net.Http;
//using System.Runtime.Serialization.Json;
//using System.Text;
//public class LeagueTableREST
//    {

//        //private readonly string uri = "http://api.football-data.org/alpha/soccerseasons/398/leagueTable";
//        private const string baseUrl = "http://api.football-data.org/alpha/soccerseasons/398/leagueTable";


//        public static void GetLeagueTable()
//        {
//            // Customize URL according to geo location parameters
//            var url = string.Format(baseUrl);

//            // Syncronious Consumption
//            var syncClient = new HttpClient();
//            var content = syncClient.GetStringAsync(url);

//            // Create the Json serializer and parse the response
//            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(LeagueTable));
//            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
//            {
//                // deserialize the JSON object using the WeatherData type.
//                var leagueTable = (LeagueTable)serializer.ReadObject(ms);
               
//            }

         
//        }


//    }
//}
