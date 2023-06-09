using AutoMapper;
using CareerApp.DataTransferObject.Requests;
using CareerApp.DataTransferObject.Responses;
using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<JobPosting, JobPostingDisplayResponse>();
            CreateMap<CreateNewJobPostingRequest, JobPosting>();
            CreateMap<UpdateJobPostingRequest, JobPosting>().ReverseMap();

            CreateMap<Recourse, RecourseDisplayResponse>();
            CreateMap<CreateNewRecourseRequest, Recourse>();
            


            CreateMap<JobSeeker, JobSeekerDisplayResponse>();
            CreateMap<CreateNewJobSeekerRequest, JobSeeker>();
            CreateMap<UpdateJobSeekerRequest, JobSeeker>().ReverseMap();

            CreateMap<Company, CompanyDisplayResponse>();
            CreateMap<CreateNewCompanyRequest, Company>();
            CreateMap<UpdateCompanyRequest, Company>().ReverseMap();

        }
    }
}
