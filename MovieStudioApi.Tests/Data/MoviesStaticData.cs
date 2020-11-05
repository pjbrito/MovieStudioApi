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
            movies.Add(2, new Movie(2, 3, "ELYSIUM", "EN", "01:49:00", 2013));
            movies.Add(3, new Movie(3, 3, "Elysium", "EN", "01:49:00", 2013));
            movies.Add(4, new Movie(4, 3, "Elysium", "HI", "01:49:00", 2013));
            movies.Add(5, new Movie(5, 3, "Elysium", "RU", "01:49:00", 2013));
            movies.Add(6, new Movie(6, 3, "Элизиум – Рай Не На Земле", "RU", "01:49:00", 2013));
            movies.Add(7, new Movie(7, 3, "Elysium", "JA", "01:49:00", 2013));
            movies.Add(8, new Movie(8, 3, "Elysium", "JA", "01:49:00", 2013));
            movies.Add(9, new Movie(9, 3, "エリジウム", "JA", "01:49:00", 2013));
            movies.Add(10, new Movie(10, 4, "Django Unchained", "EN", "02:45:00", 2012));
            movies.Add(11, new Movie(11, 4, "Django Unchained", "RU", "02:45:00", 2012));
            movies.Add(12, new Movie(12, 4, "Django Unchained", "AR", "02:45:00", 2012));
            movies.Add(13, new Movie(13, 5, "Total Recall", "AR", "01:58:00", 2012));
            movies.Add(14, new Movie(14, 5, "توتال ريكول", "AR", "01:58:00", 2012));
            movies.Add(15, new Movie(15, 5, "Total Recall", "HI", "01:58:00", 2012));
            movies.Add(16, new Movie(16, 5, "TOTAL RECALL (2012)", "EN", "01:58:00", 2012));
            movies.Add(17, new Movie(17, 5, "TOTAL RECALL (2012)", "EN", "01:58:00", 2012));
            movies.Add(18, new Movie(18, 5, "TOTAL RECALL (2012)", "EN", "01:58:00", 2012));
            movies.Add(19, new Movie(19, 5, "TOTAL RECALL (2012)", "EN", "01:58:00", 2012));
            movies.Add(20, new Movie(20, 5, "TOTAL RECALL (2012)", "EN", "01:58:00", 2012));

            return movies;
        }
    }
}
