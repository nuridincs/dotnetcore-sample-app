using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Myapp.Web.Models;

namespace Myapp.Web.Controllers
{
  public class EmployeeController : Controller
  {
    // private readonly ILogger<HomeController> _logger;

    // public EmployeeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

    private IEmployeeRepository _employee;

    public EmployeeController(IEmployeeRepository employee)
    {
      _employee = employee;
    }
    public IActionResult Index()
    {
      var results = _employee.GetAll().ToList();
      return Content($"EmployeeID : {results[1].EmployeeID} Firstname : {results[1].FirtstName}");
    }

    public IActionResult Detail(int id)
    {
      var result = _employee.GetById(id);
      return Content($"Detail EmployeeID: {result.EmployeeID}");
    }
  }
}