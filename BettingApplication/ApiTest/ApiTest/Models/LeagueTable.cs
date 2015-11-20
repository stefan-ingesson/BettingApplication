using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BettingApplication.Controllers;
using System.Web.Mvc;


namespace ApiTest.Models
{
    [TestClass]
    public class LeagueTable
    {
        [TestMethod]
        public void ListTable_Returns_Correct_View_Success()
        {
            //Arrange
            var controller = new HomeController();

            // Act
            var result = controller.ListTable() as ViewResult;

            // Assert
            Assert.AreEqual("ListTable", result.ViewName);

        }


        //     [TestMethod]
        //     public void GetTable_ReturnsNotFound_WhenTableNotFound()
        //     {
        //          HttpConfiguration config = new HttpConfiguration();
        //config.Routes.MapHttpRoute("Default", "{controller}/{id}");
        //  HttpServer server = new HttpServer(config);
        //   using (HttpMessageInvoker client = new HttpMessageInvoker(server))
        //  {
        //      using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "http://api.football-data.org/alpha/soccerseasons/398/leagueTable"))
        //      using (HttpResponseMessage response = client.SendAsync(request, CancellationToken.None).Result)
        //      {
        //          Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        //      }
        //   };
        //     }
    }
}
    
