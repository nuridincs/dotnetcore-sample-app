using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Myapp.Web.Data;

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
    }
}
