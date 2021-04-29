using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TCCSistema.Data;
using TCCSistema.Models;

namespace TCCSistema.Controllers
{   
    public class RegisterUserController : Controller
    {
        private readonly BaseContext _context;

        public RegisterUserController(BaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(string login, string password)
        {

            return View();
        }
    }
}
