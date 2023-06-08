using CareerApp.DataTransferObject.Requests;
using CareerApp.DataTransferObject.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services
{
    public interface IJobSeekerService
    {
        JobSeekerDisplayResponse GetJobSeeker(int id);
        Task<JobSeekerDisplayResponse> GetJobSeekerAsync(int id);

        IEnumerable<JobSeekerDisplayResponse> GetJobSeekerDisplayResponses();
        Task<IEnumerable<JobSeekerDisplayResponse>> GetJobSeekerDisplayResponsesAsync();

        void CreateJobSeeker(CreateNewJobSeekerRequest createNewJobSeekerRequest);
        Task CreateJobSeekerAsync(CreateNewJobSeekerRequest createNewJobSeekerRequest);
        UpdateJobSeekerRequest GetJobSeekerForUpdate(int id);
        Task<UpdateJobSeekerRequest> GetJobSeekerForUpdateAsync(int id);

        void UpdateJobSeeker(UpdateJobSeekerRequest updateJobSeekerRequest);
        Task UpdateJobSeekerAsync(UpdateJobSeekerRequest updateJobSeekerRequest);
        bool  IsJobSeekerExist(string JobSeekerUsername,string password);

        void DeleteJobSeeker(int id);
        Task DeleteJobSeekerAsync(int id);

    }
}
