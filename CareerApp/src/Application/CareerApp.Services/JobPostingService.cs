using AutoMapper;
using CareerApp.DataTransferObjects.Responses;
using CareerApp.Infrastructure.Repositories;
using CareerApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services
{
    public class JobPostingService : IJobPostingService
    {
        private readonly IJobPostingRepository _repository;
        private readonly IMapper _mapper;

        public JobPostingService(IJobPostingRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper= mapper;
        }

        IEnumerable<JobPostingDisplayResponse> IJobPostingService.GetJobPostingDisplayResponses()
        {
            var jobPostings = _repository.GetAll();
            var responses = jobPostings.ConvertToDto<IEnumerable<JobPostingDisplayResponse>>(_mapper);
            return responses;
        }
    }
}
