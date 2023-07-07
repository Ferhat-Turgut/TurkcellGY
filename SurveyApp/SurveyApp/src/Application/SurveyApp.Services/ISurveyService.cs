using Survey.Entities;
using SurveyApp.DataTransferObjects.Requests;
using SurveyApp.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Services
{
    public interface ISurveyService
    {
        TheSurvey GetSurvey(int id);
        Task <TheSurvey> GetSurveyAsync(int id);

        IEnumerable<TheSurveyDisplayResponse> GetAll();
        Task<IEnumerable<TheSurveyDisplayResponse>> GetAllAsync();

        int CreateSurveyAndReturnId(CreateNewSurveyRequest createNewSurveyRequest);
        Task<int> CreateSurveyAndReturnIdAsync(CreateNewSurveyRequest createNewSurveyRequest);
    }
}
