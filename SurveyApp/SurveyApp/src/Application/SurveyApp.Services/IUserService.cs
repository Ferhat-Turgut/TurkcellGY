using Survey.Entities;
using SurveyApp.DataTransferObjects.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Services
{
    public interface IUserService
    {
        User? ValidateUser(string userName, string password);
        Task<User>? ValidateUserAsync(string userName, string password);

        void CreateNewUser(CreateNewUserRequest createNewUserRequest);
        Task CreateNewUserAsync(CreateNewUserRequest createNewUserRequest);

        bool IsUserExist(string userName);
        Task<bool> IsUserExistAsync(string userName);

        IEnumerable<TheSurvey> GetSurveysForStatistics(int userId);
        Task<IEnumerable<TheSurvey>> GetSurveysForStatisticsAsync(int userId);
    }
}
