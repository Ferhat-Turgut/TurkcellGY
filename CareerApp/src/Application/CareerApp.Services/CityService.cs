using AutoMapper;
using CareerApp.Entities;
using CareerApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _repository;

        public CityService(ICityRepository repository)
        {
            _repository = repository;
        }
        public void CreateCity(City city)
        {
            _repository.Create(city);
        }

        public async Task CreateCityAsync(City city)
        {
            await _repository.CreateAsync(city);
        }

        public IEnumerable<City> GetAllCities()
        {
            return _repository.GetAll();
        }

        public async Task<IEnumerable<City>> GetAllCitiesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public City GetCity(int id)
        {
            return _repository.Get(id);
        }

        public async Task<City> GetCityAsync(int id)
        {
            return await _repository.GetAsync(id);
        }
    }
}
