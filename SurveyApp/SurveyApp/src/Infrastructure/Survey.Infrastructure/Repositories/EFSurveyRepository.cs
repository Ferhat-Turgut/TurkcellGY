using Microsoft.EntityFrameworkCore;
using Survey.Entities;
using Survey.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Infrastructure.Repositories
{
    public class EFSurveyRepository : ISurveyRepository
    {
        private readonly SurveyDbContext surveyDbContext;

        public EFSurveyRepository(SurveyDbContext surveyDbContext)
        {
            this.surveyDbContext = surveyDbContext;
        }

        public void Create(TheSurvey entity)
        {
            surveyDbContext.Surveys.Add(entity);
            surveyDbContext.SaveChanges();
        }

        public async Task CreateAsync(TheSurvey entity)
        {
            await surveyDbContext.Surveys.AddAsync(entity);
            await surveyDbContext.SaveChangesAsync();
        }

        public TheSurvey? Get(int id)
        {
            var survey = surveyDbContext.Surveys.Include(s => s.Questions).ThenInclude(a => a.AnswerOptions).FirstOrDefault(s => s.Id == id);
            return survey;

        }
        public async Task<TheSurvey?> GetAsync(int id)
        {
            var survey =await surveyDbContext.Surveys.Include(s => s.Questions).ThenInclude(a => a.AnswerOptions).FirstOrDefaultAsync(s => s.Id == id);
            return survey;
        }

        public IEnumerable<TheSurvey?> GetAll()
        {
            return surveyDbContext.Surveys.ToList();
        }

        public async Task<IEnumerable<TheSurvey?>> GetAllAsync()
        {
            return await surveyDbContext.Surveys.ToListAsync();
        }

       
    }
}
