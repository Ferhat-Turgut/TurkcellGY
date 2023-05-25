using AutoMapper;
using CourseApp.DataTransferObjects.Responses;
using CourseApp.Infrastructure.Repositories;
using CourseApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _repository;

        public CategoryService(IMapper mapper, ICategoryRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public IEnumerable<CategoryDisplayResponse> GetCategoriesForList()
        {
            var item = _repository.GetAll();
            var responses = item.ConvertToDto(_mapper);
            return responses;
        }
    }
}
