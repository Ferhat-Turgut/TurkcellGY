using AutoMapper;
using CareerApp.DataTransferObjects.Responses;
using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services.Mappings
{
    public class MapProfile:Profile
    {
        public MapProfile() 
        {
            CreateMap<JobPosting, JobPostingDisplayResponse>();
        }
    }
}
