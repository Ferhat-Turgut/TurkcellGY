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

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // User - Survey ilişkisi
            modelBuilder.Entity<TheSurvey>()
                .HasOne(s => s.User)
                .WithMany(u => u.Surveys)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // Survey - Question ilişkisi
            modelBuilder.Entity<Question>()
                .HasOne(q => q.Survey)
                .WithMany(s => s.Questions)
                .HasForeignKey(q => q.SurveyId)
                .OnDelete(DeleteBehavior.NoAction);

            // Question - AnswerOption ilişkisi
            modelBuilder.Entity<AnswerOption>()
                .HasOne(ao => ao.Question)
                .WithMany(q => q.AnswerOptions)
                .HasForeignKey(ao => ao.QuestionId)
                .OnDelete(DeleteBehavior.NoAction);

            // Survey - Answer ilişkisi
            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Survey)
                .WithMany(s => s.Answers)
                .HasForeignKey(a => a.SurveyId)
                .OnDelete(DeleteBehavior.NoAction);

            // Question - Answer ilişkisi
            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Question)
                .WithMany()
                .HasForeignKey(a => a.QuestionId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Initial Catalog=SurveyApp;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
