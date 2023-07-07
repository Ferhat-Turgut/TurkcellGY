using Microsoft.EntityFrameworkCore;
using Survey.Entities;
using Survey.Infrastructure;

namespace SurveyApp.Infrastructure.Repositories
{
    public class EFUserRepository : IUserRepository
    {
        private readonly SurveyDbContext _surveyDbContext;

        public EFUserRepository(SurveyDbContext surveyDbContext)
        {
            _surveyDbContext = surveyDbContext;
        }

        public void Create(User entity)
        {
             _surveyDbContext.Users.Add(entity);
             _surveyDbContext.SaveChanges();
        }

        public async Task CreateAsync(User entity)
        {
            await _surveyDbContext.Users.AddAsync(entity);
            await _surveyDbContext.SaveChangesAsync();
        }

        public IEnumerable<TheSurvey> GetSurveysForStatistics(int userId)
        {
            var surveys =  _surveyDbContext.Surveys.Include(s => s.Questions)
                                                  .ThenInclude(a => a.AnswerOptions)
                                                  .Include(s => s.Questions)
                                                  .ThenInclude(a => a.Answers)
                                                  .Where(s => s.UserId == userId)
                                                  .ToList();
            return surveys;
        }

        public async Task<IEnumerable<TheSurvey>> GetSurveysForStatisticsAsync(int userId)
        {
            var surveys =await _surveyDbContext.Surveys.Include(s => s.Questions)
                                                  .ThenInclude(a => a.AnswerOptions)
                                                  .Include(s => s.Questions)
                                                  .ThenInclude(a => a.Answers)
                                                  .Where(s => s.UserId == userId)
                                                  .ToListAsync();
            return surveys;
           
        }

        public bool IsUserExist(string userName )
        {
            return _surveyDbContext.Users.Any(u=>u.Username==userName);
        }

        public async Task<bool> IsUserExistAsync(string userName )
        {
            return await _surveyDbContext.Users.AnyAsync(u => u.Username == userName);
        }

        public User? ValidateUser(string userName, string password)
        {
            var user = _surveyDbContext.Users.SingleOrDefault(u=>u.Username==userName&&u.Password==password);
            return user;
        }

        public async Task<User>? ValidateUserAsync(string userName, string password)
        {
            var user =await _surveyDbContext.Users.SingleOrDefaultAsync(u => u.Username == userName && u.Password == password);
            return user;
        }
    }
}
