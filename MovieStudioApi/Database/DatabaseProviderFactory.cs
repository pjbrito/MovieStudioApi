using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStudioApi.DBEntities;

namespace MovieStudioApi.Database
{
    public class DatabaseProviderFactory
    {
        public readonly Dictionary<int, Movie> _movies;

        public DatabaseProviderFactory(Dictionary<int, Movie> movies)
        {
            _movies = movies;
        }

        public DatabaseProvider GetDatabaseProvider()
        {
            return new DatabaseProvider(_movies);
        }
    }
}
