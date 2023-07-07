using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Infrastructure.Repositories
{
    public interface IUserRepository:IRepository<User>
    {
        bool IsUserExist(string userName);
        Task<bool> IsUserExistAsync(string userName);

        User? ValidateUser(string userName, string password);
        Task<User>? ValidateUserAsync(string userName, string password);

        IEnumerable<TheSurvey> GetSurveysForStatistics(int userId);
        Task<IEnumerable<TheSurvey>> GetSurveysForStatisticsAsync(int userId);
    }
}
