using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Code.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace RaffleTests.Controller {
    public class CodeControllerTest
    {
        [Fact]

        public void GetTest()
        {
            CodeController codeController = new CodeController();
            var codeControllerResult = codeController.Get();

            Assert.NotNull(codeControllerResult);
            Assert.IsType<ActionResult<string>>(codeControllerResult);

        }
    }
}