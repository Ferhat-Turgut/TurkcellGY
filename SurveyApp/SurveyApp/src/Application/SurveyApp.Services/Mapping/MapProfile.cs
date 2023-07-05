using AutoMapper;
using Survey.Entities;
using SurveyApp.DataTransferObjects.Requests;

namespace SurveyApp.Services.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CreateNewSurveyRequest, TheSurvey>();
            CreateMap<CreateNewQuestionRequest, Question>();
            CreateMap<CreateNewAnswerOptionRequest, AnswerOption>();
        }
    }
}
