using AutoMapper;
using Microsoft.AspNetCore.Http;
using Survey.Entities;
using SurveyApp.DataTransferObjects.Requests;
using SurveyApp.DataTransferObjects.Responses;
using SurveyApp.Infrastructure.Repositories;
using SurveyApp.Services.Extensions;
using System.Security.Claims;

namespace SurveyApp.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly ISurveyRepository _repository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public SurveyService(ISurveyRepository repository, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _repository = repository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public int CreateSurveyAndReturnId(CreateNewSurveyRequest createNewSurveyRequest)
        {
            var claim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name);

            var userId = claim.Value;
            var survey = _mapper.Map<TheSurvey>(createNewSurveyRequest);
            survey.UserId = Convert.ToInt32(userId);
            _repository.Create(survey);

            return survey.Id;
        }

        public async Task<int> CreateSurveyAndReturnIdAsync(CreateNewSurveyRequest createNewSurveyRequest)
        {
            var survey = _mapper.Map<TheSurvey>(createNewSurveyRequest);

            var claim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name);
            var userId=claim.Value;
            survey.UserId = Convert.ToInt32(userId);
            await _repository.CreateAsync(survey);
            return survey.Id;
        }

        public IEnumerable<TheSurveyDisplayResponse> GetAll()
        {
            var surveys = _repository.GetAll();
            var response = surveys.ConvertToDisplayResponses(_mapper);
            return response;
        }

        public async Task<IEnumerable<TheSurveyDisplayResponse>> GetAllAsync()
        {
            var surveys = await _repository.GetAllAsync();
            var response = surveys.ConvertToDisplayResponses(_mapper);
            return response;
        }

        public TheSurvey GetSurvey(int id)
        {
            var survey = _repository.Get(id);
            return survey;
        }

        public async Task<TheSurvey> GetSurveyAsync(int id)
        {
            var survey = await _repository.GetAsync(id);
            return survey;
        }
    }
}
