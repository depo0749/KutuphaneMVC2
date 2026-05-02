using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KutuphaneMVC2.Controllers
{
    
    public class KontrolController : Controller
    {
        private readonly ILogger<KontrolController> _logger;


        public KontrolController(ILogger<KontrolController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
            return View();
        }
        [HttpGet]
        public IActionResult Giris()

        {

            return View();
        }
        [HttpPost]
        public IActionResult Giris()

        {
            return View();
        }
         public IActionResult Kayit()

        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}