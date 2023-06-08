using AutoMapper;
using CareerApp.Entities;
using CareerApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _repository;

        public JobService(IJobRepository repository)
        {
            _repository = repository;
        }

        public void CreateJob(Job entity)
        {
            _repository.Create(entity);
        }

        public async Task CreateJobAsync(Job entity)
        {
            await _repository.CreateAsync(entity);
        }

        public IEnumerable<Job> GetAllJobs()
        {
            var jobs = _repository.GetAll();
            return jobs;
        }

        public async Task<IEnumerable<Job>> GetAllJobsAsync()
        {
            var jobs =await _repository.GetAllAsync();
            return jobs;
        }

        public Job GetJob(int id)
        {
            var job = _repository.Get(id);
            return job;
        }

        public async Task<Job> GetJobAsync(int id)
        {
            var job= await _repository.GetAsync(id);
            return  job;
        }

        public void UpdateJobSeeker(Job entity)
        {
            _repository.Update(entity);
        }

        public async Task UpdateJobSeekerAsync(Job entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
