using AutoMapper;
using CareerApp.DataTransferObject.Requests;
using CareerApp.DataTransferObject.Responses;
using CareerApp.Entities;
using CareerApp.Infrastructure.Repositories;
using CareerApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services
{
    public class CompanyService : ICompanyService
    {

        private readonly ICompanyRepository _repository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public void CreateCompany(CreateNewCompanyRequest createNewCompanyRequest)
        {
            var company = _mapper.Map<Company>(createNewCompanyRequest);
            _repository.Create(company);
        }

        public async Task CreateCompanyAsync(CreateNewCompanyRequest createNewCompanyRequest)
        {
            var company =_mapper.Map<Company>(createNewCompanyRequest);
            await _repository.CreateAsync(company);
        }

        public void DeleteCompany(int id)
        {
            _repository.Delete(id);
        }

        public async Task DeleteCompanyAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public CompanyDisplayResponse GetCompany(int id)
        {
            var company = _repository.Get(id);
            return _mapper.Map<CompanyDisplayResponse>(company);
        }

        public async Task<CompanyDisplayResponse> GetCompanyAsync(int id)
        {
            var company =await _repository.GetAsync(id);
            return _mapper.Map<CompanyDisplayResponse>(company);
        }

        public CompanyDisplayResponse GetCompanyByUsername(string username)
        {
            var company = _repository.GetCompanyByUsername(username);
            return _mapper.Map<CompanyDisplayResponse>(company);
        }

        public async Task<CompanyDisplayResponse> GetCompanyByUsernameAsync(string username)
        {
            var company =await _repository.GetCompanyByUsernameAsync(username);
            return _mapper.Map<CompanyDisplayResponse>(company);
        }

        public IEnumerable<CompanyDisplayResponse> GetCompanyDisplayResponses()
        {
            var companies = _repository.GetAll();
            var responses = companies.ConvertToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<IEnumerable<CompanyDisplayResponse>> GetCompanyDisplayResponsesAsync()
        {
            var companies =await _repository.GetAllAsync();
            var responses =companies.ConvertToDisplayResponses(_mapper);
            return  responses;
        }

        public UpdateCompanyRequest GetCompanyForUpdate(int id)
        {
            var company = _repository.Get(id);
            return _mapper.Map<UpdateCompanyRequest>(company);
        }

        public async Task<UpdateCompanyRequest> GetCompanyForUpdateAsync(int id)
        {
            var company =await _repository.GetAsync(id);
            return _mapper.Map<UpdateCompanyRequest>(company);
        }

        public bool IsCompanyExist(string companyUsername, string password)
        {
            var IsExist = _repository.IsCompanyExist(companyUsername, password);
            if (IsExist != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> IsCompanyExistAsync(string companyUsername, string password)
        {
            var IsExist =await _repository.IsCompanyExistAsync(companyUsername, password);
            if (IsExist != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateCompany(UpdateCompanyRequest updateCompanyRequest)
        {
            var company = _mapper.Map<Company>(updateCompanyRequest);
            _repository.Update(company);
        }

        public async Task UpdateCompanyAsync(UpdateCompanyRequest updateCompanyRequest)
        {
            var company = _mapper.Map<Company>(updateCompanyRequest);
            await _repository.UpdateAsync(company);
        }
    }
}
