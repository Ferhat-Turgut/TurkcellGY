using SurveyApp.DataTransferObjects.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Services
{
    public interface IAnswerService
    {
        void CreateNewAnswer(CreateNewAnswerRequest createNewAnswerRequest);
        Task CreateNewAnswerAsync(CreateNewAnswerRequest createNewAnswerRequest);
    }
}
