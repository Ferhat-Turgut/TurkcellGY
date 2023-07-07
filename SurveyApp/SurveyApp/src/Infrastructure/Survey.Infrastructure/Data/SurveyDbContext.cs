using Microsoft.EntityFrameworkCore;
using Survey.Entities;

namespace Survey.Infrastructure
{
    public class SurveyDbContext:DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<TheSurvey> Surveys { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<AnswerOption> AnswerOptions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public SurveyDbContext(DbContextOptions<SurveyDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        

    }
}
