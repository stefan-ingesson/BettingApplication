using System.IO;
using System.Net;
using BettingApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Xml.Linq;

namespace BettingApplication.Scripts
{
  public class SoccerApi
  { 


    public class SoccerRestService
    {
      //private readonly string uri = "http://api.football-data.org/alpha/soccerseasons/356/fixtures";

      //public List<SoccerModel> GetSoccerApi()
      //{
      //  var element = XDocument.Load(uri);
      //  var json = new JavaScriptSerializer().Serialize(element);
      //  var games = element.Descendants("fixtures").Descendants("fixtures")
      //    .Select(el => new SoccerModel
      //    {
      //      homeTeamName = el.Element("homeTeamName").Value,
      //      awayTeamName = el.Element("awayTeamName").Value,
      //      result = int.Parse(el.Element("result").Value)
      //    })
      //    .ToList();

      //  return games.Select(item => new SoccerModel
      //  {
      //    homeTeamName = item.homeTeamName,
      //    awayTeamName = item.awayTeamName,
      //    result = item.result
      //  }).ToList();
      //return responseData;

      }
    }


}
