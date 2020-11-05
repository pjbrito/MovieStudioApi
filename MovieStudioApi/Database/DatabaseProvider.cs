using MovieStudioApi.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStudioApi.Database
{
    public class DatabaseProvider : IDatabaseProvider
    {
        private readonly Dictionary<int, Movie> _movies;

        public DatabaseProvider(Dictionary<int, Movie> movies)
        {
            _movies = movies;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _movies
                .Values
                .ToList();
        }

        public void SaveMovieToDatabase(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
