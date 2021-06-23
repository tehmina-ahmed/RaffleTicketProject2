using Merge;
using Merge.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace RaffleTests.Controller
{
    public class MergeControllerTest
    {
        private AppSettings appsettings = new AppSettings
        {
            codeServiceURL = "https://codeTA-app-service.azurewebsites.net",
            nameServiceURL = "https://nameTA-app-service.azurewebsites.net"
        };
        [Fact]
        public async void GetTest()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(Xunit => Xunit.Value).Returns(appsettings);

            MergeController mergeController = new MergeController(options.Object);
            var mergeContollerResult = await mergeController.Get();

            Assert.NotNull(mergeContollerResult);
            Assert.IsType<OkObjectResult>(mergeContollerResult);

        }
    }
}
