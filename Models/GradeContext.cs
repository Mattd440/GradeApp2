using System;
using Microsoft.EntityFrameworkCore;

namespace GradeProject.Models
{
    public class GradeContext : DbContext
    {
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Student> Students { get; set; }

        //public DbSet<Person> Persons { get; set; }

        String conString = "Server=tcp:gradeproject.cu7suwrmmofv.us-east-2.rds.amazonaws.com,1433;Initial Catalog=GradeApp;Persist Security Info=False;User ID=mattd440;Password=Mmd44035;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;Persist Security Info=True;";     
        //gradeapp2.cu7suwrmmofv.us-east-2.rds.amazonaws.com
    
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
            optionsBuilder.UseSqlServer(conString);
        }
		public GradeContext()
        {
        }
    }
}
