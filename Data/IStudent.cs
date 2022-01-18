using System;
using System.Collections.Generic;
using Myapp.Web.Models;

namespace Myapp.Web.Data
{
    public interface IStudent
    {
        IEnumerable<Student> GetAll();
        void Add(Student student);
    }
}
