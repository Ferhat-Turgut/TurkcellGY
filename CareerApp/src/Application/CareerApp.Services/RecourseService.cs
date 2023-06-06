using AutoMapper;
using CareerApp.DataTransferObject.Requests;
using CareerApp.DataTransferObject.Responses;
using CareerApp.Entities;
using CareerApp.Infrastructure.Repositories;
using CareerApp.Services.Extensions;

namespace CareerApp.Services
{
    public class RecourseService : IRecourseServices
    {
        private readonly IRecourseRepository _repository;
        private readonly IMapper _mapper;

        public RecourseService(IRecourseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void CreateRecourse(CreateNewRecourseRequest createNewRecourseRequest)
        {
            var recourse = _mapper.Map<Recourse>(createNewRecourseRequest);
            _repository.Create(recourse);
        }

        public async Task CreateRecourseAsync(CreateNewRecourseRequest createNewRecourseRequest)
        {
            var recourse = _mapper.Map<Recourse>(createNewRecourseRequest);
            await _repository.CreateAsync(recourse);
        }

        public RecourseDisplayResponse GetRecourse(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<RecourseDisplayResponse> GetRecourseAsync(int id)
        {
            var recourse = await _repository.GetAsync(id);
            return _mapper.Map<RecourseDisplayResponse>(recourse);
        }

        public IEnumerable<RecourseDisplayResponse> GetRecourseDisplayResponses()
        {
            var recourses = _repository.GetAll();
            var responses = recourses.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<IEnumerable<RecourseDisplayResponse>> GetRecourseDisplayResponsesAsync()
        {
            var recourses = await _repository.GetAllAsync();
            var responses = recourses.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public IEnumerable<RecourseDisplayResponse> GetRecoursesByCompany(int companyId)
        {
            var recourses = _repository.GetRecoursesByCompany(companyId);
            var responses = recourses.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<IEnumerable<RecourseDisplayResponse>> GetRecoursesByCompanyAsync(int companyId)
        {
            var recourses = await _repository.GetRecoursesByCompanyAsync(companyId);
            var responses = recourses.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public IEnumerable<RecourseDisplayResponse> GetRecoursesByJobSeeker(int jobSeekerId)
        {
            var recourses = _repository.GetRecoursesByJobSeeker(jobSeekerId);
            var responses = recourses.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<IEnumerable<RecourseDisplayResponse>> GetRecoursesByJobSeekerAsync(int jobSeekerId)
        {
            var recourses = await _repository.GetRecoursesByJobSeekerAsync(jobSeekerId);
            var responses = recourses.ConvertToDisplayResponses(_mapper);
            return responses;
        }
    }
}
