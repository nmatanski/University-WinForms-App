using DAL.Database.Helpers;
using StudentService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Database
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() : base("University")
        {
            Database.Initialize(true);

            //if(!Database.Exists())
            //{
            //    Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>())
            //}
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<StudentSubject> StudentSubjects { get; set; }

    }
}
