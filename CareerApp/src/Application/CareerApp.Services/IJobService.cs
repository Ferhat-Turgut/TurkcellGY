using CareerApp.DataTransferObject.Requests;
using CareerApp.DataTransferObject.Responses;
using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services
{
    public interface IJobService
    {
        Job GetJob(int id);
        Task<Job> GetJobAsync(int id);

        IEnumerable<Job> GetAllJobs();
        Task<IEnumerable<Job>> GetAllJobsAsync();

        void CreateJob(Job entity);
        Task CreateJobAsync(Job entity);

        void UpdateJobSeeker(Job entity);
        Task UpdateJobSeekerAsync(Job entity);

    }
}
