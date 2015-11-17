using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace BettingApplication.Models
{
    public class LeagueTableREST
    {

        private readonly string uri = "http://brottsplatskartan.se/api.php?action=getEvents&period=1440";

        public List<LeagueTable> GetLeagueTable()
        {
            XDocument element = XDocument.Load(uri);
            var crimes = element.Descendants("events").Descendants("event")
                .Select(el => new CrimeScene
                {
                    Description = el.Element("description").Value,
                    Accuracy = int.Parse(el.Element("accuracy").Value),
                    Place = el.Element("place").Value,
                    Text = el.Element("text").Value
                }
                    )
                    .ToList();

            var scenes = new List<CrimeScene>();

            foreach (var item in crimes)
            {
                var sceneOfCrime = new CrimeScene
                {
                    Description = item.Description,
                    Accuracy = item.Accuracy,
                    Place = item.Place,
                    Text = item.Text
                };
                scenes.Add(sceneOfCrime);
            }
            return scenes;

        }
    }
}