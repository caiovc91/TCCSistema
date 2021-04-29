using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TCCSistema.Data;
using TCCSistema.Models;

namespace TCCSistema.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BaseContext _db;

        public HomeController(BaseContext db, ILogger<HomeController> logger)
        {
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string login, string password)
        {
            var usuario_logado = _db.Login.Where(l => l.login == login && l.password == password).FirstOrDefault();
            if (usuario_logado != null)
            {
                return RedirectToAction("Index", "ControlPanel");
            }
            else
            {

                return View();
            }

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
