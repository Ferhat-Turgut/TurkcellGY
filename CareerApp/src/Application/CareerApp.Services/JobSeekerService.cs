using AutoMapper;
using CareerApp.DataTransferObject.Requests;
using CareerApp.DataTransferObject.Responses;
using CareerApp.Entities;
using CareerApp.Infrastructure.Repositories;
using CareerApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services
{
    public class JobSeekerService : IJobSeekerService
    {
        private readonly IJobSeekerRepository _repository;
        private readonly IMapper _mapper;

        public JobSeekerService(IJobSeekerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void CreateJobSeeker(CreateNewJobSeekerRequest createNewJobSeekerRequest)
        {
            var jobSeeker = _mapper.Map<JobSeeker>(createNewJobSeekerRequest);
            _repository.Create(jobSeeker);
        }

        public async Task CreateJobSeekerAsync(CreateNewJobSeekerRequest createNewJobSeekerRequest)
        {
            var jobSeeker =_mapper.Map<JobSeeker>(createNewJobSeekerRequest);
            await _repository.CreateAsync(jobSeeker);
        }

        public void DeleteJobSeeker(int id)
        {
            _repository.Delete(id);
        }

        public async Task DeleteJobSeekerAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public JobSeekerDisplayResponse GetJobSeeker(int id)
        {
            var jobSeeker = _repository.Get(id);
            return _mapper.Map<JobSeekerDisplayResponse>(jobSeeker);
        }

        public async Task<JobSeekerDisplayResponse> GetJobSeekerAsync(int id)
        {
            var jobSeeker = await _repository.GetAsync(id);
            return _mapper.Map<JobSeekerDisplayResponse>(jobSeeker);
        }

        public JobSeekerDisplayResponse GetJobSeekerByUsername(string username)
        {
            var jobSeeker = _repository.GetJobSeekerByUsername(username);
            return _mapper.Map<JobSeekerDisplayResponse>(jobSeeker);
        }

        public async Task<JobSeekerDisplayResponse> GetJobSeekerByUsernameAsync(string username)
        {
            var jobSeeker =await _repository.GetJobSeekerByUsernameAsync(username);
            return _mapper.Map<JobSeekerDisplayResponse>(jobSeeker);
        }

        public IEnumerable<JobSeekerDisplayResponse> GetJobSeekerDisplayResponses()
        {
            var jobSeekers = _repository.GetAll();
            var responses = jobSeekers.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<IEnumerable<JobSeekerDisplayResponse>> GetJobSeekerDisplayResponsesAsync()
        {
            var jobSeekers = await _repository.GetAllAsync();
            var responses = jobSeekers.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public UpdateJobSeekerRequest GetJobSeekerForUpdate(int id)
        {
            var jobSeeker = _repository.Get(id);
            return _mapper.Map<UpdateJobSeekerRequest>(jobSeeker);
        }

        public async Task<UpdateJobSeekerRequest> GetJobSeekerForUpdateAsync(int id)
        {
            var jobSeeker = await _repository.GetAsync(id);
            return _mapper.Map<UpdateJobSeekerRequest>(jobSeeker);
        }

        public bool IsJobSeekerExist(string JobSeekerUsername, string password)
        {
            var IsExist = _repository.IsJobSeekerExist(JobSeekerUsername, password);
            if (IsExist!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateJobSeeker(UpdateJobSeekerRequest updateJobSeekerRequest)
        {
            var jobSeekers = _mapper.Map<JobSeeker>(updateJobSeekerRequest);
            _repository.Update(jobSeekers);
        }

        public async Task UpdateJobSeekerAsync(UpdateJobSeekerRequest updateJobSeekerRequest)
        {
            var jobSeekers = _mapper.Map<JobSeeker>(updateJobSeekerRequest);
            await _repository.UpdateAsync(jobSeekers);
        }
    }
}
