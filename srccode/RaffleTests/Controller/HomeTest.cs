using FrontEnd;
using FrontEnd.Controllers;
//using Merge;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
//using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
//using static FrontEnd.Controllers.HomeController;

namespace RaffleTests.Controller
{
    public class HomeTest
    {
        private AppSettings appSettings = new AppSettings()
        {
            mergedServiceURL = "https://mergeta-app-service.azurewebsites.net"
        };
        [Fact]

        public async void GetTest()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            HomeController homeController = new HomeController(options.Object);
            var homeControllerResult = await homeController.Index();

            Assert.NotNull(homeControllerResult);
            //Assert.IsType<ActionResult<string>>(homeControllerResult);

        }
    }
}
