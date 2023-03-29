using EVC_DAY2.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace EVC_DAY2.Context
{
    public class DepartmentContex: DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<CrsResult> crsResults { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "User ID=postgres; Password=000; Host=localhost; Port=5432; Database=DepartmentDb;";

            optionsBuilder
                //.UseLazyLoadingProxies()
                .UseNpgsql(connectionString);

            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging();
        }
    }
}


