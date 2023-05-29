using CourseApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Infrastructure.Data
{
    public class CourseDbContext : DbContext
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Category> categories { get; set; }

        public CourseDbContext(DbContextOptions<CourseDbContext> options) : base(options)
        {

        }
    }
}
