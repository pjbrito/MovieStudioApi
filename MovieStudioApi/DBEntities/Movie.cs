using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStudioApi.DBEntities
{
    public class Movie
    {

        public Movie(int id, int movieId, string title, string language, string durationStr, int releaseYear)
        {
            this.Id = id;
            this.MovieId = movieId;
            this.Title = title;
            this.Language = language;
            this.Duration = TimeSpan.ParseExact(durationStr, @"h\:mm\:ss", null, TimeSpanStyles.None);
            this.ReleaseYear = releaseYear;
        }

        public int Id { get; set; }

        public int MovieId { get; set; }

        public string Title { get; set; }

        public string Language { get; set; }

        public TimeSpan Duration { get; set; }

        public int ReleaseYear { get; set; }


        public bool IsValid()
        {
            if (Id == 0)
                return false;

            if (MovieId == 0)
                return false;

            if (string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Language))
                return false;

            if (Duration.TotalSeconds <= 0)
                return false;

            if (ReleaseYear == 0)
                return false;

            return true; // this movie passed all rules => so is valid
        }

    }

}