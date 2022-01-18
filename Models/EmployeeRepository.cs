using System;
using System.Collections.Generic;
using System.Linq;

namespace Myapp.Web.Models
{
  public class EmployeeRepository : IEmployeeRepository
  {
    private List<Employee> _employees;

    public EmployeeRepository()
    {
        _employees = new List<Employee>
        {
          new Employee{EmployeeID=1, FirtstName="idin", LaststName="ncs", EnrollmentDate=DateTime.Parse("2021-02-02")},
          new Employee{EmployeeID=2, FirtstName="idin2", LaststName="ncs2", EnrollmentDate=DateTime.Parse("2021-02-02")},
          new Employee{EmployeeID=3, FirtstName="idin3", LaststName="ncs3", EnrollmentDate=DateTime.Parse("2021-02-02")},
        };
    }

    public IEnumerable<Employee> GetAll()
    {
        return _employees.OrderBy(e=>e.FirtstName);
    }

    public Employee GetById(int id)
    {
      var result = _employees.Where(e=>e.EmployeeID==id).SingleOrDefault();
      return result;
    }
  }
}