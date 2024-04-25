using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRoutingPrj.Models;

namespace AttributeRoutingPrj.Controllers
{
    [RoutePrefix("Student")]
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>()
        {
            new Student(){Id = 1, Name="Shyam"},
            new Student(){Id = 2, Name="Shreya"},
            new Student(){Id = 3, Name="Anurag"},
            new Student(){Id = 4, Name="Aakruthi"},
        };

        [HttpGet]
      // 1. without RoutePrefix  [Route("Student")]
      [Route]
        public ActionResult GetAllStudents()
        {
            return View(students);
        }

        [HttpGet]
        // 1. without RoutePrefix [Route("Student/{Sid}")]
        [Route("{Sid}")]
        public ActionResult GetStudentById(int Sid)
        {
            Student stddetails = students.FirstOrDefault(s =>s.Id == Sid);
            return View(stddetails);
        }

        [HttpGet]
        // 1. without RoutePrefix [Route("Student/{Sid}/courses")]
        [Route("{Sid}/courses")]
        public ActionResult GetStudentCourse(int Sid)
        {
            List<string> CourseList = new List<string>();
            if (Sid == 1)
                CourseList = new List<string>() { "ASP.Net", "C#.Net", "SQL" };
            else if(Sid == 2)
                CourseList = new List<string>() { "ASP.Net", "C#.Net", "ADO.Net" };
            else if(Sid == 3)
                CourseList = new List<string>() { "ASP.Net", "WebAPI", "C#.Net" };
            else
                CourseList = new List<string>() { "Bootstrap", "Javascript", "Html" };
            ViewBag.CourseLst = CourseList;
            return View();
        }
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
    }
}