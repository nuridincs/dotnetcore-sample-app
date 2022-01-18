using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myapp.Web.Models
{
  public interface IEmployeeRepository
  {
      IEnumerable<Employee> GetAll();
      Employee GetById(int id);
  }
}