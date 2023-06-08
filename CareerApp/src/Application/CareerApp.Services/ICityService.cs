using CareerApp.DataTransferObject.Requests;
using CareerApp.DataTransferObject.Responses;
using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Services
{
    public interface ICityService
    {
        City GetCity(int id);
        Task<City> GetCityAsync(int id);

        IEnumerable<City> GetAllCities();
        Task<IEnumerable<City>> GetAllCitiesAsync();

        void CreateCity(City city);
        Task CreateCityAsync(City city);
        

    }
}
