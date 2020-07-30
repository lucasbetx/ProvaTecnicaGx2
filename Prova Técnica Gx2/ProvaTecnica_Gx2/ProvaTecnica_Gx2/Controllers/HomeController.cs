using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProvaTecnica_Gx2.Models;

namespace ProvaTecnica_Gx2.Controllers
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

        public IActionResult Questao1()
        {

            var j = 0;
            string msg = "";

            while (j <= 100)
            {

                if (j % 2 == 0)
                {

                    if (j == 100)
                    {

                        msg += j + ". ";

                    }
                    else
                    {

                        msg += j + ", ";

                    }

                }

                j++;
            }

            ViewBag.Numbers = msg;

            return View();
        }

        public IActionResult Questao2()
        {
            return View();
        }

        public IActionResult Questao3()
        {
            return View();
        }

        public IActionResult Questao4()
        {
            return View();
        }

        public IActionResult Questao5()
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
