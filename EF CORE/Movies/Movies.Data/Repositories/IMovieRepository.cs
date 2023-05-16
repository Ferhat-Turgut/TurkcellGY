using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data.Repositories
{
    public interface IMovieRepository:IRepository<Movie>
    {
        Task<IEnumerable<Movie>> SearchMoviesByTitlle(string tittle);
        Task addPlayerToMovie(int movieId, List<int> selectedPlayers);
    }
}
