using CourseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Infrastructure.Data
{
    public static class DbSeeding
    {
        public static void SeedDatabase(CourseDbContext dbContext)
        {
            seedCategoryIfNotExist(dbContext);
            seedCourseIfNotExist(dbContext);
        }

        private static void seedCategoryIfNotExist(CourseDbContext dbContext)
        {
            if (!dbContext.categories.Any())
            {
                var categories = new List<Category>()
                {
                    new(){Name="Müzik Kursları",Description="Her çeşit enstruman eğitimi ve ses eğitimi"},
                    new(){Name="Yazılım Kursları",Description="......"},
                    new(){Name="Resim Kursları",Description=".........."},
                    new(){Name="Spor Kursları",Description="Yoga,Plates vb."}
                };
                dbContext.categories.AddRange(categories);
                dbContext.SaveChanges();
            }
        }

        private static void seedCourseIfNotExist(CourseDbContext dbContext)
        {
            if (!dbContext.courses.Any())
            {
                 var courses = new List<Course>()
                {
                    new(){Name="Keman Kursu",CategoryId=1,ImageUrl="https://loremflickr.com/320/240",Price=9.75M,TotalHours=80,Rating=4},
                    new(){Name="Gitar Kursu",CategoryId=1,ImageUrl="https://loremflickr.com/320/240",Price=8.75M,TotalHours=70,Rating=5},
                    new(){Name="C# Kursu",CategoryId=2,ImageUrl="https://loremflickr.com/320/240",Price=15.75M,TotalHours=100,Rating=5},
                    new(){Name=".Net Kursu",CategoryId=2,ImageUrl="https://loremflickr.com/320/240",Price=12.75M,TotalHours=120,Rating=4},
                    new(){Name="Karakalem Kursu",CategoryId=3,ImageUrl="https://loremflickr.com/320/240",Price=4.75M,TotalHours=50,Rating=4},
                    new(){Name="Perspektif Kursu",CategoryId=3,ImageUrl="https://loremflickr.com/320/240",Price=6.75M,TotalHours=45,Rating=3},
                    new(){Name="Yoga Kursu",CategoryId=4,ImageUrl="https://loremflickr.com/320/240",Price=9.55M,TotalHours=55,Rating=4},
                    new(){Name="Plates Kursu",CategoryId=4,ImageUrl="https://loremflickr.com/320/240",Price=8.55M,TotalHours=57,Rating=4},
                 
                };
                dbContext.courses.AddRange(courses);
                dbContext.SaveChanges();
            }
        }
    }
}
