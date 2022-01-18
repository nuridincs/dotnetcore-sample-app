using System;
using System.Collections.Generic;
using System.Linq;
using Myapp.Web.Models;

namespace Myapp.Web.Data
{
    public class StudentRepository : IStudent
    {
        private AppDbContext _db;

        public StudentRepository(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Student> GetAll()
        {
            return _db.Students.OrderBy(s=>s.FirstMidName);
        }
    }
}
