using MovieFinder.Business.Abstract;
using MovieFinder.DataAccess.Abstract;
using MovieFinder.DataAccess.Concrete;
using MovieFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinder.Business.Concrete
{
    public class MovieManager : IMovieService
    {

        private IMovieRepository _movieRepository;

        public MovieManager(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }


        public Movie Create(Movie movie)
        {
            return _movieRepository.Create(movie);
        }

        public void Delete(int id)
        {
            _movieRepository.Delete(id);
        }

        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }

        public Movie GetMovieById(int id)
        {
            return _movieRepository.GetMovieById(id);
        }

        public Movie Update(Movie movie)
        {
            return _movieRepository.Update(movie);
        }
    }
}
