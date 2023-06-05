using CareerApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.DataAccessLayer.Concrete.Context
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Initial Catalog=CareerApp;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Role> Roles { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<JobPosting> JobPostings { get; set; }
        public DbSet<Recourse> Recourses { get; set; }
    }
}
