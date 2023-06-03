using AutoMapper;
using CareerApp.DataTransferObjects.Responses;
using CareerApp.Entities;

namespace CareerApp.Services.Extensions
{
    public static class MappingExtensions
    {
        public static T ConvertToDto<T>(this IEnumerable<JobPosting> jobPosting, IMapper mapper)
        {
            return mapper.Map<T>(jobPosting);
        }

    }
}
