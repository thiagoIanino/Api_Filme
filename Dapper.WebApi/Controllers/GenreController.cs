using Microsoft.AspNetCore.Mvc;
using projeto.movie.api.Models;
using projeto.movie.api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.movie.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreRepository _GenreRepository;

        public GenreController(IGenreRepository GenreRepository)
        {
            _GenreRepository = GenreRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Genre>> GetAll()
        {
            var Genres = await _GenreRepository.GetAllGenres();
            return Ok(Genres);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Genre>> GetById(int id)
        {
            var Genre = await _GenreRepository.GetById(id);
            return Ok(Genre);
        }
        [HttpPost]
        public async Task<ActionResult> AddGenre(Genre entity)
        {
            await _GenreRepository.AddGenre(entity);
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Genre>> Update(Genre entity, int id)
        {
            await _GenreRepository.UpdateGenre(entity, id);
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _GenreRepository.RemoveGenre(id);
            return Ok();
        }
    }
}
