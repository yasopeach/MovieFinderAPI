using MovieFinder.DataAccess.Abstract;
using MovieFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinder.DataAccess.Concrete
{
    public class MovieRepository : IMovieRepository
    {
        public Movie Create(Movie movie)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                movieDbContext.Movies.Add(movie);
                movieDbContext.SaveChanges();
                return movie;
            }
        }

        public void Delete(int id)
        {
            using (var movieDbContext = new MovieDbContext())
            {  
                var deletedMovie = GetMovieById(id);
                movieDbContext.Movies.Remove(deletedMovie);
                movieDbContext.SaveChanges();

            }
        }

        public List<Movie> GetAllMovies()
        {
            using (var movieDbContext = new MovieDbContext())
            {
                return movieDbContext.Movies.ToList();
            }
        }

        public Movie GetMovieById(int id)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                return movieDbContext.Movies.Find(id);
            }
        }

        public Movie Update(Movie movie)
        {
            using (var movieDbContext = new MovieDbContext())
            {
                movieDbContext.Movies.Update(movie);
                movieDbContext.SaveChanges();
                return movie;
            }
        }
    }
}
