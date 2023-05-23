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
            modelBuilder.Entity<Application>().Property(a => a.Name)
                                              .IsRequired()
                                              .HasMaxLength(50);

            modelBuilder.Entity<Category>().Property(c => c.Name)
                                           .IsRequired()
                                           .HasMaxLength(30);

            modelBuilder.Entity<Producer>().Property(p => p.Developer)
                                        .IsRequired()
                                        .HasMaxLength(75);


            modelBuilder.Entity<Application>().HasOne(a => a.Producer)
                                    .WithMany(p => p.Applications)
                                    .HasForeignKey(a => a.ProducerId);

            modelBuilder.Entity<ApplicationsCategories>().HasKey("ApplicationId", "CategoryId");


            modelBuilder.Entity<Application>().HasMany(a => a.Categories)
                                       .WithOne(ac => ac.Application)
                                       .HasForeignKey(ac => ac.ApplicationId)
                                       .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>().HasMany(c => c.Applications)
                                         .WithOne(ac => ac.Category)
                                         .HasForeignKey(ac => ac.CategoryId)
                                         .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Producer>().HasData(new Producer { Id = 1, Developer = " Twitter Dev.", Email = "support@twitter.com" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Sosyal Medya" });
            modelBuilder.Entity<Application>().HasData(new Application { Id = 1, Name = "Twitter",Rating=4.5,DowloadCounter=150,IsInstalled=true,ProducerId=1 });
            modelBuilder.Entity<ApplicationsCategories>().HasData(new ApplicationsCategories { ApplicationId = 1, CategoryId = 1 });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LikePlayStore;Integrated Security=True");
        }

    }
}
