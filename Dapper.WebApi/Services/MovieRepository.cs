using projeto.movie.api.Models;
using projeto.movie.api.Services.Queries;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace projeto.movie.api.Services
{
    public class MovieRepository : BaseRepository, IMovieRepository
    {
        private readonly ICommandTextMovie _commandText;

        public MovieRepository(IConfiguration configuration, ICommandTextMovie commandText) : base(configuration)
        {
            _commandText = commandText;

        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {

            return await WithConnection(async conn =>
            {
                var query = await conn.QueryAsync<Movie>(_commandText.GetMovies);
                return query;
            });

        }

        public async ValueTask<Movie> GetById(int id)
        {
            return await WithConnection(async conn =>
            {
                var query = await conn.QueryFirstOrDefaultAsync<Movie>(_commandText.GetMovieById, new { Id = id });
                return query;
            });

        }

        public async Task AddMovie(Movie entity)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(_commandText.AddMovie,
                    new { Title = entity.Title, Director = entity.Director, ReleaseDate = entity.ReleaseDate, Duration = entity.Duration, Id_Genre = entity.Id_Genre });
            });

        }
        public async Task UpdateMovie(Movie entity, int id)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(_commandText.UpdateMovie,
                    new { Title = entity.Title, Director = entity.Director,  ReleaseDate = entity.ReleaseDate, Duration = entity.Duration, Id = id, Id_Genre = entity.Id_Genre });
            });

        }
        public async Task RemoveMovie(int id)
        {

            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(_commandText.RemoveMovie, new { Id = id });
            });

        }

    }
}
