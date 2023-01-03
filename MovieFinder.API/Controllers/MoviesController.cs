using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieFinder.Business.Abstract;
using MovieFinder.Business.Concrete;
using MovieFinder.Entities;
using System.Collections.Generic;

namespace MovieFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var movies = _movieService.GetAllMovies();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMoviesById(int id)
        {
            var movie = _movieService.GetMovieById(id);
            if (movie != null)
            {
                return Ok(movie);
            }
            return NotFound();

        }

        [HttpPost]
        public IActionResult CreateMovie([FromBody] Movie movie) 
        {
                var createdMovie = _movieService.Create(movie);
                return CreatedAtAction("GetMoviesById", new {id = createdMovie.Id}, createdMovie);
        }

        [HttpPut]
        public IActionResult UpdateMovie([FromBody] Movie movie)
        {
            if (_movieService.GetMovieById(movie.Id)!=null)
            {
                return Ok(_movieService.Update(movie));
            }
            return NotFound();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            if (_movieService.GetMovieById(id) != null)
            {
                _movieService.Delete(id);
                return Ok();
            }
            return NotFound();
            
        }




    }
}
