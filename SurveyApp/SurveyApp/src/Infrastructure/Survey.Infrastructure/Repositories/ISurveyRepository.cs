using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Infrastructure.Repositories
{
    public interface ISurveyRepository:IRepository<TheSurvey>
    {
        TheSurvey? Get(int id);
        Task<TheSurvey?> GetAsync(int id);
        IEnumerable<TheSurvey?> GetAll();
        Task<IEnumerable<TheSurvey?>> GetAllAsync();

    }
}
