using KUSYS_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace KUSYS_Demo.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students
                .Include(s => s.StudentCourses)
                .ThenInclude(sc => sc.Course).ToList();

            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                student.CreatedDate= DateTime.Now;
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public IActionResult UpdatePage(int id)
        {
            var student = _context.Students
                    .FirstOrDefault(s => s.Id == id);

            return View(student);
        }

        [HttpPost]

        public IActionResult Update(Student student)
        {
            var existingStudent = _context.Students
                .FirstOrDefault(s => s.Id == student.Id);

            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.BirthDate = student.BirthDate;
            existingStudent.UpdatedDate = DateTime.Now;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            var student = _context.Students
                .Include(s => s.StudentCourses)
                .ThenInclude(sc => sc.Course)
                .FirstOrDefault(s => s.Id == id);

            return View(student);
        }




        public IActionResult AddCourse()
        {

            ViewBag.Students = new SelectList(_context.Students.Select(s => new
            {
                SId = s.Id,
                SName = s.FirstName + " " + s.LastName,
            }),"SId","SName","SName");
            ViewBag.Courses = new SelectList(_context.Courses.Select(c => new
            {
                CId = c.Id,
                CName = c.Id + " - " + c.Name
            }),"CId","CName","CName");


            return View();
        }

        [HttpPost]
        public IActionResult AddCourseToStudent(int studentId, int courseId)
        {
            var existingCourse = _context.StudentCourses
                .FirstOrDefault(sc => sc.StudentId == studentId && sc.CourseId == courseId);
            
            if (existingCourse == null)
            {
                var studentCourse = new StudentCourses
                {
                    StudentId = studentId,
                    CourseId = courseId
                };

                _context.StudentCourses.Add(studentCourse);
                _context.SaveChanges();

                return RedirectToAction("CourseList");
            }
            else
            {
                string errorMessage = "Student already saved this course";
                ViewBag.ErrorMessage = errorMessage;
                return View("_Error");
            }
        }

        public IActionResult CourseList() 
        {
            var courseStudent = _context.StudentCourses
                .Include(sc => sc.Student)
                .Include(sc => sc.Course)
                .ToList();

            return View(courseStudent);
        }

        [HttpPost]
        public void Delete(int studentId)
        {
            var existingStudent = _context.Students
                .FirstOrDefault(s => s.Id == studentId);
            _context.Students.Remove(existingStudent);
            _context.SaveChanges();
        }      
    }
}
