using Dapper;
using Microsoft.Extensions.Configuration;
using projeto.movie.api.Models;
using projeto.movie.api.Services.Queries;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace projeto.movie.api.Services
{
    public class GenreRepository : BaseRepository, IGenreRepository
    {
        private readonly ICommandTextGenre _commandText;

        public GenreRepository(IConfiguration configuration, ICommandTextGenre commandText) : base(configuration)
        {
            _commandText = commandText;

        }

        public async Task<IEnumerable<Genre>> GetAllGenres()
        {

            return await WithConnection(async conn =>
            {
                var query = await conn.QueryAsync<Genre>(_commandText.GetGenres);
                return query;
            });

        }

        public async ValueTask<Genre> GetById(int id)
        {
            return await WithConnection(async conn =>
            {
                var query = await conn.QueryFirstOrDefaultAsync<Genre>(_commandText.GetGenreById, new { Id = id });
                return query;
            });

        }

        public async Task AddGenre(Genre entity)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(_commandText.AddGenre,
                    new { Name = entity.Name, Description = entity.Description });
            });

        }
        public async Task UpdateGenre(Genre entity, int id)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(_commandText.UpdateGenre,
                    new { Name = entity.Name, Description = entity.Description, Id = id });
            });

        }
        public async Task RemoveGenre(int id)
        {

            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(_commandText.RemoveGenre, new { Id = id });
            });

        }
    }
}
