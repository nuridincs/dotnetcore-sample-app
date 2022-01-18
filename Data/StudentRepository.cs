using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

        public void Add(Student student)
        {

            _db.Students.Add(student);
            _db.Database.OpenConnection();
            try
            {
                _db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Students ON;");
                _db.SaveChanges();
                _db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Students OFF;");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
            finally
            {
                _db.Database.CloseConnection();
            }
        }

        public IEnumerable<Student> GetAll()
        {
            return _db.Students.OrderBy(s=>s.FirstMidName);
        }
    }
}
