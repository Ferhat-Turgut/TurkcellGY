using AutoMapper;
using Survey.Entities;
using SurveyApp.DataTransferObjects.Requests;
using SurveyApp.Infrastructure.Repositories;

namespace SurveyApp.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository _repository;
        private readonly IMapper _mapper;

        public AnswerService(IAnswerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void CreateNewAnswer(CreateNewAnswerRequest createNewAnswerRequest)
        {
            foreach (var response in createNewAnswerRequest.Responses)
            {
                var answer = new Answer
                {
                    QuestionId = response.Key,
                    Response = response.Value
                };
                _repository.Create(answer);
            }

        }

        public async Task CreateNewAnswerAsync(CreateNewAnswerRequest createNewAnswerRequest)
        {
            foreach (var response in createNewAnswerRequest.Responses)
            {
                var answer = new Answer
                {
                    QuestionId = response.Key,
                    Response = response.Value
                };
                await _repository.CreateAsync(answer);
            }
        }
    }
}
