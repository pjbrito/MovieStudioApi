using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStudioApi.DBEntities;

namespace MovieStudioApi.Models
{
    public class MovieStatsModel
    {
        public MovieStatsModel()
        {
        }

        public MovieStatsModel(Movie movie)
        {
            MovieId = movie.MovieId;
            Title = movie.Title;
            ReleaseYear = movie.ReleaseYear;
        }

        public int MovieId { get; set; }

        public string Title { get; set; }

        public int AverageWatchDurationS { get; set; }

        public int Watches { get; set; }

        public int ReleaseYear { get; set; }

    }
}
