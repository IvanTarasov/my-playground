using BikePath.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sandbox.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace sandbox.Controllers
{
    public class HomeController : Controller
    {
        private SandboxContext _db;

        public HomeController(SandboxContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
