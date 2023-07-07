using Survey.Entities;
using Survey.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Infrastructure.Repositories
{
    public class EFAnswerRepository : IAnswerRepository
    {
        private readonly SurveyDbContext surveyDbContext;

        public EFAnswerRepository(SurveyDbContext surveyDbContext)
        {
            this.surveyDbContext = surveyDbContext;
        }

        public void Create(Answer entity)
        {
            surveyDbContext.Add(entity);
            surveyDbContext.SaveChanges();
        }

        public async Task CreateAsync(Answer entity)
        {
            await surveyDbContext.AddAsync(entity);
            surveyDbContext.SaveChanges();
        }
    }
}
