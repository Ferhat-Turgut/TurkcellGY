using CareerApp.DataTransferObject.Requests;
using CareerApp.DataTransferObject.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services
{
    public interface IJobPostingService
    {
        JobPostingDisplayResponse GetJobPosting(int id);
        Task<JobPostingDisplayResponse> GetJobPostingAsync(int id);
        IEnumerable<JobPostingDisplayResponse> GetJobPostingDisplayResponses();
        Task<IEnumerable<JobPostingDisplayResponse>> GetJobPostingDisplayResponsesAsync();

        void CreateJobPosting(CreateNewJobPostingRequest createNewJobPosting);
        Task CreateJobPostingAsync(CreateNewJobPostingRequest createNewJobPosting);

         UpdateJobPostingRequest GetJobPostingForUpdate(int id);
        Task<UpdateJobPostingRequest> GetJobPostingForUpdateAsync(int id);

        void UpdateJobPosting(UpdateJobPostingRequest updateJobPostingRequest);
        Task UpdateJobPostingAsync(UpdateJobPostingRequest updateJobPostingRequest);

        IEnumerable<JobPostingDisplayResponse> GetJobPostingsByJob(int jobId);
        Task<IEnumerable<JobPostingDisplayResponse>> GetJobPostingsByJobAsync(int jobId);
        IEnumerable<JobPostingDisplayResponse> GetJobPostingsByCompany(int companyId);
        Task<IEnumerable<JobPostingDisplayResponse>> GetJobPostingsByCompanyAsync(int companyId);

        void ChangeJobPostingStatus(int jobPostingId);
        Task ChangeJobPostingStatusAsync(int jobPostingId);
    }
}
