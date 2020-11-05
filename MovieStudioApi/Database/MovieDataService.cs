using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStudioApi.DBEntities;

namespace MovieStudioApi.Database
{
    public class MovieDataService : IMovieDataService
    {
        public static Dictionary<int, Movie> GetHardcodedStartupData()
        {
            var movies = new Dictionary<int, Movie>();

            movies.Add(1, new Movie(1, 3, "Elysium", "AR", "01:49:00", 2013));

            return movies;
        }
    }
}
