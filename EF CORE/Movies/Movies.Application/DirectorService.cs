using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;
using Movies.Data.Repositories;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application
{
    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository directorRepository;

        public DirectorService(IDirectorRepository directorRepository)
        {
            this.directorRepository = directorRepository;
        }

        public Task<int> CreateNewDirector(string name, string lastname, string info)
        {
            throw new NotImplementedException();
        }

        public async Task<int> CreateNewDirectorAsync(CreateNewDirectorRequest request)
        {
            var director = new Director 
            {
                Name=request.Name,
                LastName=request.LastName,
                Info=request.Info
            };
            await directorRepository.CreateAsync(director);
            return director.Id;
        }

        public async Task<SingleDirectorResponse> GetDirectorAsync(int id)
        {
            var director=await directorRepository.GetByIdAsync(id);
            return new SingleDirectorResponse 
            {
                Name=director.Name,
                LastName=director.LastName,
                Info=director.Info
            };
        }

        public async Task<IEnumerable<DirectorListResponse>> GetDirectorsAsync()
        {
            var directors = await directorRepository.GetAllAsync();
            var responses = directors.Select(d => new DirectorListResponse
            {
                Id = d.Id,
                Name = d.Name,
                LastName = d.LastName,
                Info = d.Info,
            });

            return responses;
        }

        public async Task UpdateDirectorAsync(UpdateDirectorRequest request)
        {
            var director = new Director 
            {
                Id= request.Id,
                Name=request.Name,
                LastName=request.LastName,
                Info=request.Info
            };
            await directorRepository.UpdateAsync(director);
            
        }
    }
}
