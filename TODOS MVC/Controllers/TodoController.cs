using Microsoft.AspNetCore.Mvc;
using TODOS_MVC.Models;

namespace TODOS_MVC.Controllers
{
    public sealed class TodoController : Controller
    {
        public IActionResult Index()
        {
            var todoViewModel = new TodoViewModel();

            return View(todoViewModel);
        }
    }
}
