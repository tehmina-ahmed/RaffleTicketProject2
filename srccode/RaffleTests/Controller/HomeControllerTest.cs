using Merge;
using Microsoft.AspNetCore.Mvc;
//using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RaffleTests.Controller
{
    public class HomeControllerTest
    {
        private AppSettings appSettings = new AppSettings()
        {
            mergedServiceURL = "https://mergeta-app-service.azurewebsites.net"
        };
        [Fact]

        public async void GetTest()
        {
            HomeControllerTest homeController = new HomeControllerTest();
            var homeControllerResult = await homeController.Index();

            Assert.NotNull(homeControllerResult);
            Assert.IsType<ActionResult<string>>(homeControllerResult);

        }
    }
}
