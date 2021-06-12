using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Name.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private static readonly string[] Letters = new[]
        {
            "Ahmed","Bilal", "Charlie","Daniella","Edward","Fanta","Grizzly","Henry","Indigo","Jamel"
        };

        [HttpGet]
        public ActionResult<string> Get()
        {
            var rnd = new Random();
            var returnIndex = rnd.Next(0, 10);
            return Letters[returnIndex].ToString();
        }
    }
}
