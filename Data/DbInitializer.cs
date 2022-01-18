using System;
using System.Linq;
using System.Collections.Generic;
using Myapp.Web.Models;

namespace Myapp.Web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();
            // bool v = context.Students.Any();
            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student{FirstMidName="Muhammad", LastName="Nuridin", EnrollmentDate=DateTime.Parse("2020-01-02")},
                new Student{FirstMidName="Eva", LastName="Agustin", EnrollmentDate=DateTime.Parse("2020-01-02")},
                new Student{FirstMidName="Muhammad", LastName="Zibran", EnrollmentDate=DateTime.Parse("2020-01-02")},
            };

            foreach(var s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
        }
    }
}
