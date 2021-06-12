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
            var codeResponseCall = await new HttpClient().GetStringAsync(codeService);
            var nameService = "https://localhost:44373/name";
            var nameResponseCall = await new HttpClient().GetStringAsync(nameService);
            var mergedResponse = $"{nameResponseCall}{codeResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
