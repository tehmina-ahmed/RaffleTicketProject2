using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Code.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeController : ControllerBase
    {
        private static readonly string[] Numbers = new[]
         {
            "6175","2509","3772","4893","5276","6083","7312","8514","9247","0639"
        };

        [HttpGet]
        public ActionResult<string> Get()
        {
            var rnd = new Random();
            var returnIndex = rnd.Next(0, 10);
            return Numbers[returnIndex].ToString();
        }

    }
}
