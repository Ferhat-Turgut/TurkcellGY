using CareerApp.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services
{
    public interface IJobPostingService
    {
        public IEnumerable<JobPostingDisplayResponse> GetJobPostingDisplayResponses { get; set; }
    }
}
