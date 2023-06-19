using CourseApp.DataTransferObjects.Requests;
using CourseApp.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Services
{
    public interface ICourseService
    {
        IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses();
        Task<int> CreateCourseAndReturnIdAsync(CreateNewCourseRequest createNewCourseRequest);

        IEnumerable<CourseDisplayResponse> GetCourseByCategory(int categoryId);
        CourseDisplayResponse GetCourse(int id);
        Task CreateNewCourseAsync(CreateNewCourseRequest createNewCourseRequest);
        Task UpdateCourse(UpdateCourseRequest updateCourseRequest);
        Task<IEnumerable<CourseDisplayResponse>> SearchByName(string name);
        Task<bool> CourseIsExist(int courseId);
        Task<UpdateCourseRequest> GetCourseForUpdate(int id);
        Task DeleteAsync(int id);
    }
}
