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
        private int _maxMovieId;

        public DatabaseProvider(Dictionary<int, Movie> movies)
        {
            _movies = movies;
            _maxMovieId = _movies?.Keys.Max() ?? 1;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _movies
                .Values
                .ToList();
        }

        public IEnumerable<Movie> GetMovieByMovieId(int movieId)
        {
            return _movies
                .Values
                .Where(x => x.MovieId == movieId)
                .ToList();
        }

        public void SaveMovieToDatabase(Movie movie)
        {
            var _currentId = ++_maxMovieId;
            movie.Id = _currentId;
            _movies.Add(_currentId, movie);
        }
    }
}
