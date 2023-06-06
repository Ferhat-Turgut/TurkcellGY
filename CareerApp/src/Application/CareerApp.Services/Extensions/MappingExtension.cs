﻿using AutoMapper;
using CareerApp.DataTransferObject.Responses;
using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services.Extensions
{
    public static class MappingExtension
    {
        public static T ConvertToDto<T>(this IEnumerable<JobPosting> jobPostings, IMapper mapper)
        {
            return mapper.Map<T>(jobPostings);
        }
        public static IEnumerable<JobPostingDisplayResponse> ConvertToDisplayResponses(this IEnumerable<JobPosting> jobPostings, IMapper mapper)
        {
            return mapper.Map<IEnumerable<JobPostingDisplayResponse>>(jobPostings);
        }

        public static IEnumerable<RecourseDisplayResponse> ConvertToDto(this IEnumerable<Recourse> recourses, IMapper mapper)
        {
            return mapper.Map<IEnumerable<RecourseDisplayResponse>>(recourses);
        }
    }
}