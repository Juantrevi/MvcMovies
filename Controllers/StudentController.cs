using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { ID = 1, Name = "John" });
            students.Add(new Student { ID = 2, Name = "Mary" });
            students.Add(new Student { ID = 3, Name = "Bob" });
            students.Add(new Student { ID = 4, Name = "Jane" });
            students.Add(new Student { ID = 5, Name = "Mike" });

            ViewData["Students"] = students;    


            return View();
        }
    }
}
