using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStudioApi.DBEntities;

namespace MovieStudioApi.Models
{
    public class MovieModel
    {
        public MovieModel(Movie movie)
        {
            MovieId = movie.MovieId;
            Title = movie.Title;
            Language = movie.Language;
            Duration = movie.Duration.ToString("hh\\:mm\\:ss");
            ReleaseYear = movie.ReleaseYear;
        }

        public int MovieId { get; set; }

        public string Title { get; set; }

        public string Language { get; set; }

        public string Duration { get; set; }

        public int ReleaseYear { get; set; }
    }
}
