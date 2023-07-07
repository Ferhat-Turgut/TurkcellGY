using AutoMapper;
using Survey.Entities;
using SurveyApp.DataTransferObjects.Requests;
using SurveyApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void CreateNewUser(CreateNewUserRequest createNewUserRequest)
        {
            var user = _mapper.Map<User>(createNewUserRequest);
            _repository.CreateAsync(user);
        }

        public async Task CreateNewUserAsync(CreateNewUserRequest createNewUserRequest)
        {
            var user = _mapper.Map<User>(createNewUserRequest);
            await _repository.CreateAsync(user);
        }

        public  IEnumerable<TheSurvey> GetSurveysForStatistics(int userId)
        {
            var surveys= _repository.GetSurveysForStatistics(userId);
            return surveys;
        }

        public async Task<IEnumerable<TheSurvey>> GetSurveysForStatisticsAsync(int userId)
        {
            var surveys =await _repository.GetSurveysForStatisticsAsync(userId);
            return surveys;
        }

        public bool IsUserExist(string userName)
        {
            return _repository.IsUserExist(userName);
        }

        public async Task<bool> IsUserExistAsync(string userName)
        {
            return await _repository.IsUserExistAsync(userName);
        }

        public User? ValidateUser(string userName, string password)
        {
            var user=_repository.ValidateUser(userName, password);
            return user;
        }

        public async Task<User>? ValidateUserAsync(string userName, string password)
        {
            var user =await _repository.ValidateUserAsync(userName, password);
            return user;
        }
    }
}
