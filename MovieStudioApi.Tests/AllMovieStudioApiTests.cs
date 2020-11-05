using MovieStudioApi.DBEntities;
using NUnit.Framework;
using System;
using System.Linq;
using MovieStudioApi.Database;
using MovieStudioApi.Tests.Data;

namespace MovieStudioApi.Tests
{
    public class AllMovieStudioApiTests
    {
        [SetUp]
        public void Setup()
        {
        }

        public class TheMovieEntityAllows
        {
            [Test]
            public void CreateInstanceWithCorrectValues()
            {
                var m = new Movie(1, 2, "Shrek", "EN", "1:30:00", 2001);

                Assert.AreEqual(1, m.Id);
                Assert.AreEqual(2, m.MovieId);
                Assert.AreEqual("Shrek", m.Title);
                Assert.AreEqual("EN", m.Language);
                Assert.AreEqual(new TimeSpan(1, 30, 0), m.Duration);
                Assert.AreEqual(2001, m.ReleaseYear);
            }

        }

        public class TheDatabaseProvider
        {
            private DatabaseProvider _provider;

            [SetUp]
            public void Setup()
            {
                var moviesData = MoviesStaticData.GetMoviesStaticData();
                var f = new DatabaseProviderFactory(moviesData);
                _provider = f.GetDatabaseProvider();
            }

            [Test]
            public void ReturnsSomeData()
            {
                var movies = _provider.GetAllMovies();

                Assert.IsNotEmpty(movies);
            }

            [Test]
            public void ReturnsSpecificMovie()
            {
                var testId = 93029;
                var title = "Specific Movie Test";
                _provider.SaveMovieToDatabase(new Movie(0, testId, title, "EN", "1:30:00", 2000));

                var movie = _provider
                    .GetMovieByMovieId(testId)
                    .FirstOrDefault();

                Assert.IsNotNull(movie);
                Assert.AreEqual(testId, movie.MovieId);
            }

        }

    }
}