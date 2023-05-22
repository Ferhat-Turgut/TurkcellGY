using likePlayStore.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Numerics;

namespace likePlayStore.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Application> Applications { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Category> Categorys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
     

            modelBuilder.Entity<Application>().HasOne(a => a.Producer)
                                    .WithMany(p => p.Applications)
                                    .HasForeignKey(a => a.ProducerId)
                                    .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ApplicationsCategories>().HasKey("ApplicationId", "CategoryId");


            modelBuilder.Entity<Application>().HasMany(a => a.Categories)
                                       .WithOne(ac => ac.Application)
                                       .HasForeignKey(ac => ac.ApplicationId)
                                       .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>().HasMany(c => c.Applications)
                                         .WithOne(ac => ac.Category)
                                         .HasForeignKey(ac => ac.CategoryId)
                                         .OnDelete(DeleteBehavior.NoAction);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LikePlayStore;Integrated Security=True");
        }

    }
}
