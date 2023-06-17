using CareerApp.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Infrastructure.Data
{
    public class CareerAppDbContext:IdentityDbContext
    {
   
        public DbSet<Role> Roles { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<JobPosting> JobPostings { get; set; }
        public DbSet<Recourse> Recourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });

            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, RoleName = "company" },
                                                new Role { Id = 2, RoleName = "jobSeeker" },
                                                new Role { Id = 3, RoleName = "admin" });

            modelBuilder.Entity<City>().HasData(new City { Id = 1, Name = "adana" },
                                                new City { Id = 2, Name = "adıyaman" },
                                                new City { Id = 3, Name = "afyonkarahisar" },
                                                new City { Id = 4, Name = "ağrı" },
                                                new City { Id = 5, Name = "amasya" },
                                                new City { Id = 6, Name = "ankara" },
                                                new City { Id = 7, Name = "antalya" },
                                                new City { Id = 8, Name = "artvin" },
                                                new City { Id = 9, Name = "aydın" },
                                                new City { Id = 10, Name = "balıkesir" },
                                                new City { Id = 11, Name = "bilecik" },
                                                new City { Id = 12, Name = "bingöl" },
                                                new City { Id = 13, Name = "bitlis" },
                                                new City { Id = 14, Name = "bolu" },
                                                new City { Id = 15, Name = "burdur" },
                                                new City { Id = 16, Name = "bursa" },
                                                new City { Id = 17, Name = "çanakkale" },
                                                new City { Id = 18, Name = "çankırı" },
                                                new City { Id = 19, Name = "çorum" },
                                                new City { Id = 20, Name = "denizli" },
                                                new City { Id = 21, Name = "diyarbakır" },
                                                new City { Id = 22, Name = "edirne" },
                                                new City { Id = 23, Name = "elazığ" },
                                                new City { Id = 24, Name = "erzincan" },
                                                new City { Id = 25, Name = "erzurum" },
                                                new City { Id = 26, Name = "eskişehir" },
                                                new City { Id = 27, Name = "gaziantep" },
                                                new City { Id = 28, Name = "giresun" },
                                                new City { Id = 29, Name = "gümüşhane" },
                                                new City { Id = 30, Name = "hakkari" },
                                                new City { Id = 31, Name = "hatay" },
                                                new City { Id = 32, Name = "ısparta" },
                                                new City { Id = 33, Name = "mersin" },
                                                new City { Id = 34, Name = "istanbul" },
                                                new City { Id = 35, Name = "izmir" },
                                                new City { Id = 36, Name = "kars" },
                                                new City { Id = 37, Name = "kastamonu" },
                                                new City { Id = 38, Name = "kayseri" },
                                                new City { Id = 39, Name = "kırklareli" },
                                                new City { Id = 40, Name = "kırşehir" },
                                                new City { Id = 41, Name = "kocaeli" },
                                                new City { Id = 42, Name = "konya" },
                                                new City { Id = 43, Name = "kütahya" },
                                                new City { Id = 44, Name = "malatya" },
                                                new City { Id = 45, Name = "manisa" },
                                                new City { Id = 46, Name = "kahramanmaraş" },
                                                new City { Id = 47, Name = "mardin" },
                                                new City { Id = 48, Name = "muğla" },
                                                new City { Id = 49, Name = "muş" },
                                                new City { Id = 50, Name = "nevşehir" },
                                                new City { Id = 51, Name = "niğde" },
                                                new City { Id = 52, Name = "ordu" },
                                                new City { Id = 53, Name = "rize" },
                                                new City { Id = 54, Name = "sakarya" },
                                                new City { Id = 55, Name = "samsun" },
                                                new City { Id = 56, Name = "siirt" },
                                                new City { Id = 57, Name = "sinop" },
                                                new City { Id = 58, Name = "sivas" },
                                                new City { Id = 59, Name = "tekirdağ" },
                                                new City { Id = 60, Name = "tokat" },
                                                new City { Id = 61, Name = "trabzon" },
                                                new City { Id = 62, Name = "tunceli" },
                                                new City { Id = 63, Name = "şanlıurfa" },
                                                new City { Id = 64, Name = "uşak" },
                                                new City { Id = 65, Name = "van" },
                                                new City { Id = 66, Name = "yozgat" },
                                                new City { Id = 67, Name = "zonguldak" },
                                                new City { Id = 68, Name = "aksaray" },
                                                new City { Id = 69, Name = "bayburt" },
                                                new City { Id = 70, Name = "karaman" },
                                                new City { Id = 71, Name = "kırıkkale" },
                                                new City { Id = 72, Name = "batman" },
                                                new City { Id = 73, Name = "şırnak" },
                                                new City { Id = 74, Name = "bartın" },
                                                new City { Id = 75, Name = "ardahan" },
                                                new City { Id = 76, Name = "ığdır" },
                                                new City { Id = 77, Name = "yalova" },
                                                new City { Id = 78, Name = "karabük" },
                                                new City { Id = 79, Name = "kilis" },
                                                new City { Id = 80, Name = "osmaniye" },
                                                new City { Id = 81, Name = "düzce" }
                                                );

            modelBuilder.Entity<Job>().HasData(new Job { Id = 1, Name = "inşaat mühendisi" },
                                               new Job { Id = 2, Name = "yazılım geliştirici" },
                                               new Job { Id = 3, Name = "doktor" },
                                               new Job { Id = 4, Name = "öğretmen" },
                                               new Job { Id = 5, Name = "hemşire" },
                                               new Job { Id = 6, Name = "avukat" },
                                               new Job { Id = 7, Name = "mimar" },
                                               new Job { Id = 8, Name = "eczacı" },
                                               new Job { Id = 9, Name = "muhabir" },
                                               new Job { Id = 10, Name = "elektrikçi" },
                                               new Job { Id = 11, Name = "şef" },
                                               new Job { Id = 12, Name = "grafiker" },
                                               new Job { Id = 13, Name = "fotografçı" },
                                               new Job { Id = 14, Name = "mekanikçi" },
                                               new Job { Id = 15, Name = "tasarımcı" },
                                               new Job { Id = 16, Name = "aşçı" },
                                               new Job { Id = 17, Name = "müzik öğretmeni" },
                                               new Job { Id = 18, Name = "itfaiyeci" },
                                               new Job { Id = 19, Name = "bankacı" },
                                               new Job { Id = 20, Name = "psikolog" }
                                               );


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Initial Catalog=CareerApp;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }


    }
}
