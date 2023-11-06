using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, int age)
        {
            return $"{name}, This is the Welcome action method... you age is {age}";
        }

        public IActionResult Person(string name, int age)
        {
            ViewData["Message"] = $"{name}, This is the Person action method... you age is {age}";

            return View();
        }
    }
}
