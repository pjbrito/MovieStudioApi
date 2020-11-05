using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStudioApi.DBEntities;

namespace MovieStudioApi.Database
{
    public interface IDatabaseProvider
    {

        IEnumerable<Movie> GetAllMovies();
        void SaveMovieToDatabase(Movie movie);

    }
}
