using projeto.movie.api.Models;
using projeto.movie.api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace projeto.movie.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _MovieRepository;

        public MovieController(IMovieRepository MovieRepository)
        {
            _MovieRepository = MovieRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Movie>> GetAll()
        {
            var Movies = await _MovieRepository.GetAllMovies();
            return Ok(Movies);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Movie>> GetById(int id)
        {
            var Movie = await _MovieRepository.GetById(id);
            return Ok(Movie);
        }
        [HttpPost]
        public async Task<ActionResult> AddMovie(Movie entity)
        {
            await _MovieRepository.AddMovie(entity);
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Movie>> Update(Movie entity, int id)
        {
            await _MovieRepository.UpdateMovie(entity, id);
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _MovieRepository.RemoveMovie(id);
            return Ok();
        }
    }
}