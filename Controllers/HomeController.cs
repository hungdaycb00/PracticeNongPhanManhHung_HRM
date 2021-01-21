using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticeNongPhanManhHung_HRM.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeNongPhanManhHung_HRM.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository repository;
        private readonly ILogger<HomeController> _logger;

       public HomeController(IEmployeeRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(repository.Employees.OrderBy(p => p.Id));



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
