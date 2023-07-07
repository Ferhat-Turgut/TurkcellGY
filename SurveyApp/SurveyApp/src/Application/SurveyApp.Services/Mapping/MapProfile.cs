using AutoMapper;
using Survey.Entities;
using SurveyApp.DataTransferObjects.Requests;
using SurveyApp.DataTransferObjects.Responses;

namespace SurveyApp.Services.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CreateNewSurveyRequest, TheSurvey>();
            CreateMap<CreateNewQuestionRequest, Question>();
            CreateMap<CreateNewAnswerOptionRequest, AnswerOption>();
            CreateMap<CreateNewUserRequest, User>();
            CreateMap<CreateNewAnswerRequest, Answer>();

            CreateMap<TheSurvey, TheSurveyDisplayResponse>();

        }
    }
}
