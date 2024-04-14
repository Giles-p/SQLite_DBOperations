using Microsoft.AspNetCore.Mvc;
using SQLite_DBOperations.Models;
using SQLite_DBOperations.Models.DataAccessLayer;
using System.Diagnostics;

namespace SQLite_DBOperations.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext _studentDbContext;
        public HomeController(StudentDbContext studentDbContext) {
            _studentDbContext = studentDbContext;
        
        }

        public IActionResult Index()
        {
            var sList = _studentDbContext.Students.ToList();
            return View(sList);
        }

        public IActionResult Create(Students student)
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