using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAdmin.Models;

namespace WebAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbcontextMemory db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbcontextMemory db)
        {
            _logger = logger;
            this.db = db;
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

        public IActionResult Info()
        {
            var result = db.Patients.ToList();
            return Json(result);
        }

        public IActionResult AddNew()
        {
            var rnd = new Random();
            db.Patients.Add(new Patient
            {
                Id = rnd.Next(),
                Age = 55,
                Name = "lll",
                Famili = "kkjlkj"
            });
            db.SaveChanges();
            return Json("ok");
        }
    }
}
