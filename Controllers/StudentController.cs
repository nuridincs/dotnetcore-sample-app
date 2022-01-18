using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Myapp.Web.Data;
using Myapp.Web.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Myapp.Web.Controllers
{
    public class StudentController : Controller
    {
        private IStudent _students;

        public StudentController(IStudent students)
        {
            _students = students;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _students.GetAll();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                _students.Add(student);
                ViewData["msg"] = "Data Berhasil Disimpan";
                return View();
            }
            catch (Exception ex)
            {
                ViewData["msg"] = $"Error {ex.Message}";
                return View();
            }
            //return Content($"ID : {student.ID} - FirstMidName : {student.FirstMidName} - LastName : {student.LastName} - Address : {student.Address} - EnrollmentDate : {student.EnrollmentDate}");
        }
    }
}
