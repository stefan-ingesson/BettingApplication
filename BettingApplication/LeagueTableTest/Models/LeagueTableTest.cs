using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BettingApplication.Models;
using System.Collections.Generic;
using BettingApplication.Controllers;

namespace ApiTest
{
    [TestClass]
    public class LeagueTableTest
    {
        [TestMethod]
        public void Can_Find_Table_Success()
        {
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute("Default", "{controller}/{id}");
            HttpServer server = new HttpServer(config);
            using (HttpMessageInvoker client = new HttpMessageInvoker(server))
            {
                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "http://localhost/Movies/-1"))
                using (HttpResponseMessage response = client.SendAsync(request, CancellationToken.None).Result)
                {
                    Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
                }
            };
        }


    }
}
