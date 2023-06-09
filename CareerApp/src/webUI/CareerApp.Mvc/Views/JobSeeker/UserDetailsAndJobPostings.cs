using CareerApp.DataTransferObject.Responses;

namespace CareerApp.Mvc.Views.JobSeeker
{
    public class UserDetailsAndJobPostings
    {
        public JobSeekerDisplayResponse JobSeekerDisplayResponse { get; set; }
        public IEnumerable<JobPostingDisplayResponse> jobPostingDisplayResponses { get; set; }
    }
}
