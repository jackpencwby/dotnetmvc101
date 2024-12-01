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
            Student s1 = new Student();
            s1.StudentID = "66010089";
            s1.Name = "Jack";
            s1.Score = 99;

            Student s2 = new Student();
            s2.StudentID = "66000001";
            s2.Name = "Alice";
            s2.Score = 75;

            Student s3 = new Student();
            s3.StudentID = "66000002";
            s3.Name = "Bob";
            s3.Score = 49;

            List<Student> s = new List<Student>();
            s.Add(s1);
            s.Add(s2);
            s.Add(s3);

            return View(s);
        }

        public IActionResult ShowStudentScore(string id)
        {
            return View();
        }
    }
}
