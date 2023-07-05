using AutoMapper;
using Survey.Entities;
using SurveyApp.DataTransferObjects.Requests;
using SurveyApp.Infrastructure.Repositories;

namespace SurveyApp.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly ISurveyRepository _repository;
        private readonly IMapper _mapper;

        public SurveyService(ISurveyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public int CreateSurveyAndReturnId(CreateNewSurveyRequest createNewSurveyRequest)
        {
            var survey = _mapper.Map<TheSurvey>(createNewSurveyRequest);
            _repository.Create(survey);
            return survey.Id;
        }

        public async Task<int> CreateSurveyAndReturnIdAsync(CreateNewSurveyRequest createNewSurveyRequest)
        {
            var survey = _mapper.Map<TheSurvey>(createNewSurveyRequest);
            survey.Tittle = createNewSurveyRequest.Tittle;
            survey.UserId = 1;
            survey.Link = "sada";
            await _repository.CreateAsync(survey);
            return survey.Id;
        }

        public IEnumerable<TheSurvey> GetAll()
        {

            return _repository.GetAll();
        }

        public async Task<IEnumerable<TheSurvey>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public TheSurvey GetSurvey(int id)
        {
            var survey = _repository.Get(id);
            return survey;
        }

        public Task<TheSurvey> GetSurveyAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
