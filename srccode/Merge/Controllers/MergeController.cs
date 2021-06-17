using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]

    //codeURL: https://localhost:44310/code
    //nameURL: https://localhost:44373/name
    public class MergeController : ControllerBase
    {
        private IConfiguration Configuration;
        public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
 
            var codeService = "https://localhost:44310/code";
            //URL for codeController service
            var codeResponseCall = await new HttpClient().GetStringAsync(codeService);

            var nameService = "https://localhost:44373/name";
            //URL for nameController service
            var nameResponseCall = await new HttpClient().GetStringAsync(nameService);

            //If Else statements after names & code have been called
            if (nameResponseCall == "Kamran")//assigns a name to a prize 
            {
                var RafflePrize = "Car";
                var mergedResponse = $"{nameResponseCall} has redeemed the code {codeResponseCall} and won a CAR!!!";
                return Ok(mergedResponse);
            }
            else if (nameResponseCall == "Atiyya")
            {
                var RafflePrize = "Handbag";//variable defines a prize for the user 
                var mergedResponse = $"{nameResponseCall} has redeemed the code {codeResponseCall} and won a HANDBAG!!!";
                return Ok(mergedResponse);
            }
            else if (nameResponseCall == "Zeeshan")
            {
                var RafflePrize = "Football";
                var mergedResponse = $"{nameResponseCall} has redeemed the code {codeResponseCall} and won a FOOTBALL!!!";
                //merge response joins the name and code controller services to within a string to display on service 1
                return Ok(mergedResponse);

            }
            else if (nameResponseCall == "Shafia")
            {
                var RafflePrize = "Mop";
                var mergedResponse = $"{nameResponseCall} has redeemed the code {codeResponseCall} and won a MOP!!!";
                return Ok(mergedResponse);
                //line 61 returns the merged response
            }
            else if (nameResponseCall == "Shayan")
            {
                var RafflePrize = "Poppit";
                var mergedResponse = $"{nameResponseCall} has redeemed the code {codeResponseCall} and won a POPPIT!!!";
                return Ok(mergedResponse);

            }
            else
            {
                return Ok("This ticket doesn't redeem a prize, SIKE LOOOL!!!!");
            }//last else statement is met if all values are false

        }

        
    }
}
