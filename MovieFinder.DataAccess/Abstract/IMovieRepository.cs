using MovieFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinder.DataAccess.Abstract
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();

        Movie GetMovieById(int id);

        Movie Create(Movie movie);

        Movie Update(Movie movie);

        void Delete(int id); 
    }
}
