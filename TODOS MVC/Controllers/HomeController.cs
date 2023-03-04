using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TODOS_MVC.Models;

namespace TODOS_MVC.Controllers
{
    public sealed class HomeController : Controller
    {
        public IActionResult Index()
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