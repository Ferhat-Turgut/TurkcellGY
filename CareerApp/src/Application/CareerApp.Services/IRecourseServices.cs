using CareerApp.DataTransferObject.Requests;
using CareerApp.DataTransferObject.Responses;
using CareerApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services
{
    public interface IRecourseServices
    {
        RecourseDisplayResponse GetRecourse(int id);
        Task<RecourseDisplayResponse> GetRecourseAsync(int id);

        IEnumerable<RecourseDisplayResponse> GetRecourseDisplayResponses();
        Task<IEnumerable<RecourseDisplayResponse>> GetRecourseDisplayResponsesAsync();

        void CreateRecourse(CreateNewRecourseRequest createNewRecourseRequest);
        Task CreateRecourseAsync(CreateNewRecourseRequest createNewRecourseRequest);

        
        IEnumerable<RecourseDisplayResponse> GetRecoursesByCompany(int companyId);
        Task<IEnumerable<RecourseDisplayResponse>> GetRecoursesByCompanyAsync(int companyId);

        IEnumerable<RecourseDisplayResponse> GetRecoursesByJobSeeker(int jobSeekerId);
        Task<IEnumerable<RecourseDisplayResponse>> GetRecoursesByJobSeekerAsync(int jobSeekerId);

    }
}
