﻿using Movies.Application.DTOs.Requests;
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
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository   movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public async Task<int> CreateNewMovie(CreateNewMovieRequest createNewMovie)
        {
            var movie = new Movie 
            {
                DirectorId= createNewMovie.DirectorId,
                Duration = createNewMovie.Duration,
                Name= createNewMovie.Name,
                Poster= createNewMovie.Poster,
                PublishDate= createNewMovie.PublishDate,
                Rating= createNewMovie.Rating,
            };
            await movieRepository.CreateAsync(movie);
            return movie.Id;
        }

        public async Task<IEnumerable<MovieListResponse>> GetAllMovies()
        {
            var movies =await movieRepository.GetAllAsync();
            var response = movies.Select(m => new MovieListResponse
            {
                Duration = m.Duration,
                Name = m.Name,
                Id = m.Id,
                Poster = m.Poster,
                PublishDate = m.PublishDate,
                Rating = m.Rating,
                DirectoryName = $"{m.Director?.Name} {m.Director?.LastName}",
                Players = string.Join("-",m.Players.Select(pl=>new {FullName=$"{pl.Player.Name} {pl.Player.LastName}"} ))
            }); 

            return response;
        }

        public async Task AddPlayerToMovie(int movieId,List<int> players) 
        {
            await movieRepository.addPlayerToMovie(movieId, players);
        }

        public Task UpdateMovie(UpdateMovieRequest updateMovie)
        {
            throw new NotImplementedException();
        }
    }
}
