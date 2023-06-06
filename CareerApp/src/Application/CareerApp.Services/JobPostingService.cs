using AutoMapper;
using CareerApp.DataTransferObject.Requests;
using CareerApp.DataTransferObject.Responses;
using CareerApp.Entities;
using CareerApp.Infrastructure.Data;
using CareerApp.Infrastructure.Repositories;
using CareerApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services
{
    public class JobPostingService : IJobPostingService
    {
        private readonly IJobPostingRepository _repository;
        private readonly IMapper _mapper;

        public JobPostingService(IJobPostingRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void ChangeJobPostingStatus(int jobPostingId)
        {
            _repository.ChangeJobPostingStatus(jobPostingId);
        }

        public async Task ChangeJobPostingStatusAsync(int jobPostingId)
        {
            await _repository.ChangeJobPostingStatusAsync(jobPostingId);
        }

        public void CreateJobPosting(CreateNewJobPostingRequest createNewJobPostingRequest)
        {
            var jobPosting = _mapper.Map<JobPosting>(createNewJobPostingRequest);
            _repository.Create(jobPosting);
        }

        public async Task CreateJobPostingAsync(CreateNewJobPostingRequest createNewJobPostingRequest)
        {
            var jobPosting =_mapper.Map<JobPosting>(createNewJobPostingRequest);
            await _repository.CreateAsync(jobPosting);
        }

        public JobPostingDisplayResponse GetJobPosting(int id)
        {
            var jobPosting = _repository.Get(id);
            return _mapper.Map<JobPostingDisplayResponse>(jobPosting);
        }

        public async Task<JobPostingDisplayResponse> GetJobPostingAsync(int id)
        {
            var jobPosting =await _repository.GetAsync(id);
            return _mapper.Map<JobPostingDisplayResponse>(jobPosting);
        }

        public IEnumerable<JobPostingDisplayResponse> GetJobPostingDisplayResponses()
        {
            var jobPostings = _repository.GetAll();
            var responses = jobPostings.ConvertToDisplayResponses(_mapper);
            return responses;

        }

        public async Task<IEnumerable<JobPostingDisplayResponse>> GetJobPostingDisplayResponsesAsync()
        {
            var jobPostings =await _repository.GetAllAsync();
            var responses = jobPostings.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public UpdateJobPostingRequest GetJobPostingForUpdate(int id)
        {
            var jobPosting = _repository.Get(id);
            return _mapper.Map<UpdateJobPostingRequest>(jobPosting);
        }

        public async Task<UpdateJobPostingRequest> GetJobPostingForUpdateAsync(int id)
        {
            var jobPosting = await _repository.GetAsync(id);
            return _mapper.Map<UpdateJobPostingRequest>(jobPosting);
        }

        public IEnumerable<JobPostingDisplayResponse> GetJobPostingsByCompany(int companyId)
        {
            var jobPostings = _repository.GetJobPostingsByCompany(companyId);
            var responses = jobPostings.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<IEnumerable<JobPostingDisplayResponse>> GetJobPostingsByCompanyAsync(int companyId)
        {
            var jobPostings =await _repository.GetJobPostingsByCompanyAsync(companyId);
            var responses = jobPostings.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public IEnumerable<JobPostingDisplayResponse> GetJobPostingsByJob(int jobId)
        {
            var jobPostings = _repository.GetJobPostingsByJob(jobId);
            var responses = jobPostings.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<IEnumerable<JobPostingDisplayResponse>> GetJobPostingsByJobAsync(int jobId)
        {
            var jobPostings = await _repository.GetJobPostingsByJobAsync(jobId);
            var responses = jobPostings.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public void UpdateJobPosting(UpdateJobPostingRequest updateJobPostingRequest)
        {
            var jobPosting = _mapper.Map<JobPosting>(updateJobPostingRequest);
            _repository.Update(jobPosting);
        }

        public async Task UpdateJobPostingAsync(UpdateJobPostingRequest updateJobPostingRequest)
        {
            var jobPosting = _mapper.Map<JobPosting>(updateJobPostingRequest);
            await _repository.UpdateAsync(jobPosting);
        }

   
    }
}
