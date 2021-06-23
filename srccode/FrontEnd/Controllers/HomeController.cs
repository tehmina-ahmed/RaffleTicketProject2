using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FrontEnd.Models;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace FrontEnd.Controllers
{
    //mergeURL: https://localhost:44323/merge
    public class HomeController : Controller
    {

        private AppSettings Configuration;
        public HomeController(IOptions<AppSettings> settings)
        {
            Configuration = settings.Value;
        }

        public async Task<IActionResult> Index()
        {
            //var mergedService = "https://localhost:44323/merge";
            var mergedService = $"{Configuration.mergedServiceURL}/merge";
            var mergeResponseCall = await new HttpClient().GetStringAsync(mergedService);
            ViewBag.responseCall = mergeResponseCall;
            return View();
        }
    }
}
