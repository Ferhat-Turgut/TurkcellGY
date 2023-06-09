using CareerApp.DataTransferObject.Responses;


namespace CareerApp.Mvc.Views.Company
{
    public class UserDetailsAndJobPostings
    {
        public CompanyDisplayResponse Company { get; set; }
        public IEnumerable<JobPostingDisplayResponse> jobPostingDisplayResponses { get; set; }
    }
}
