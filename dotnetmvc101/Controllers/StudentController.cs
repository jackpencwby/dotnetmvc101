using Microsoft.AspNetCore.Mvc;

namespace dotnetmvc101.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return Content("หน้าเเรก");
        }

        public IActionResult SaveScore()
        {
            return Content("บันทึกคะเเนนสอบวิชา Web Application");
        }

        public IActionResult ShowAllStudentScore()
        {
            return Content("คะเเนนสอบวิชา Web Application");
        }

        public IActionResult ShowStudentScore(string id)
        {
            return Content($"คะเเนนสอบวิชา Web Application ของรหัสนักศึกษา : {id}");
        }
    }
}
