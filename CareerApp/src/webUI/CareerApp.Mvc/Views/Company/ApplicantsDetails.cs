using CareerApp.DataTransferObject.Responses;
using CareerApp.Entities;

namespace CareerApp.Mvc.Views.Company
{
    public class ApplicantsDetails
    {
        public JobSeekerDisplayResponse  JobSeeker { get; set; }
        public JobPostingDisplayResponse JobPosting { get; set; }
    }
}
