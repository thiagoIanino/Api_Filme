using projeto.movie.api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace projeto.movie.api.Services
{
    public interface IMovieRepository
    {
        ValueTask<Movie> GetById(int id);
        Task AddMovie(Movie entity);
        Task UpdateMovie(Movie entity, int id);
        Task RemoveMovie(int id);
        Task<IEnumerable<Movie>> GetAllMovies();
    }
}
