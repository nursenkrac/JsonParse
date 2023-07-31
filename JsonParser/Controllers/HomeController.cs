using JsonParser.Models;
using JsonParser.Models.ViewModels.Outputs;
using JsonParser.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JsonParser.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult JsonParse()
        {
            ServiceOperation ou = new ServiceOperation();
            OutputModel o = new OutputModel();
            String[] strlist = ou.JsonParse();
            o.strlist = strlist;
            ViewBag.Deger = strlist;
            return View(o);
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
