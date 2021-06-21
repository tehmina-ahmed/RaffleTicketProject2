using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


//referencing Dara's project demo for numbersController
namespace Code.Controllers
{//webApi
    [ApiController]
    [Route("[controller]")]
    public class CodeController : ControllerBase
    {   //this string contains a series of redemption codes for the raffle ticket users
        private static readonly string[] Numbers = new[]
         {
            "6175","2509","3772","4893","5276","6083","7312","8514","9247","0639"
        };

        //this method gets the value from the above string using a random generator.
        [HttpGet]
        public ActionResult<string> Get()
        {
            var rnd = new Random();
            var returnIndex = rnd.Next(0, 10);
            return Numbers[returnIndex].ToString();
        }//this method above creates a random generator by assigning a random variable to a value of the string above
        //the return Numbers method calls on the string to return a randomly assigned code 
    }
}
