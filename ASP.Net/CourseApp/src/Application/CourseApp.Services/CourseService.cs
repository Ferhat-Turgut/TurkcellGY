using AutoMapper;
using CourseApp.DataTransferObjects.Requests;
using CourseApp.DataTransferObjects.Responses;
using CourseApp.Entities;
using CourseApp.Infrastructure.Repositories;
using CourseApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CourseService()
        {
        }

        public CourseDisplayResponse GetCourse(int id)
        {
            var course = _repository.Get(id);
            return _mapper.Map<CourseDisplayResponse>(course);
        }

        public IEnumerable<CourseDisplayResponse> GetCourseByCategory(int categoryId)
        {
            var courses = _repository.GetCoursesByCategory(categoryId);
            var response = courses.ConvertToDisplayResponses(_mapper);
            return response;
        }

        public  IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses()
        {
            var courses=_repository.GetAll();
            var response = courses.ConvertToDisplayResponses(_mapper);
            return response;
        }
        public async Task CreateNewCourseAsync(CreateNewCourseRequest createNewCourseRequest) 
        {
            var course = _mapper.Map<Course>(createNewCourseRequest);
            await _repository.CreateAsync(course);
        }

        public async Task UpdateCourse(UpdateCourseRequest updateCourseRequest)
        {
            var course=_mapper.Map<Course>(updateCourseRequest);
            await _repository.UpdateAsync(course);
        }

        public async Task<bool> CourseIsExist(int courseId)
        {
            return await _repository.IsExistAsync(courseId);
        }

        public async Task<UpdateCourseRequest> GetCourseForUpdate(int id)
        {
            var course=await _repository.GetAsync(id);
            return  _mapper.Map<UpdateCourseRequest>(course);
        }

        public async Task<IEnumerable<CourseDisplayResponse>> SearchByName(string name)
        {
            var courses =await  _repository.GetCoursesByNameAsync(name);
            return courses.ConvertToDisplayResponses(_mapper);
        }

        public async Task<int> CreateCourseAndReturnIdAsync(CreateNewCourseRequest createNewCourseRequest)
        {
            var course = _mapper.Map<Course>(createNewCourseRequest);
            await _repository.CreateAsync(course);
            return course.Id;
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
