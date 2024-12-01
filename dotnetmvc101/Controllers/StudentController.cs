using Microsoft.AspNetCore.Mvc;

namespace dotnetmvc101.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SaveScore()
        {
            return View();
        }

        public IActionResult ShowAllStudentScore()
        {
            return View();
        }

        public IActionResult ShowStudentScore(string id)
        {
            return View();
        }
    }
}
