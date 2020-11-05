using System;
using System.Collections.Generic;
using System.Text;
using MovieStudioApi.DBEntities;

namespace MovieStudioApi.Tests.Data
{
    public class MoviesStaticData
    {
        public static Dictionary<int, Movie> GetMoviesStaticData()
        {
            var movies = new Dictionary<int, Movie>();

            movies.Add(1, new Movie(1, 3, "Elysium", "AR", "01:49:00", 2013));

            return movies;
        }
    }
}
