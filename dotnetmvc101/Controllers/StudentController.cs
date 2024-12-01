using dotnetmvc101.Models;
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
            Student s = new Student();
            s.StudentID = "66010089";
            s.Name = "Jack";
            s.Score = 99;

            return View(s);
        }

        public IActionResult ShowStudentScore(string id)
        {
            return View();
        }
    }
}
