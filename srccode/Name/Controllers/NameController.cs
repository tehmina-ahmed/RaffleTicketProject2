using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Name.Controllers
{//webApi
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {   //a string containing names 
        private static readonly string[] Letters = new[]
        {
            "Kamran","Atiyya","Zeeshan","Shafia","Shayan",
        };

        [HttpGet]
        public ActionResult<string> Get()
        {//a method that assigns a generator function to the string above - each value is returned at random
            var rnd = new Random();
            var returnIndex = rnd.Next(0, 5);
            return Letters[returnIndex].ToString();
        }

        public class LastNameController : ControllerBase
        {
            private static readonly string[] Letters = new[]
            {
            "ahmed","noori","smith","majeed","kaleo",
        };

            [HttpGet]
            public ActionResult<string> Get()
            {
                var rnd = new Random();
                var returnIndex = rnd.Next(0, 5);
                return Letters[returnIndex].ToString();
            }
        }
    }
}
