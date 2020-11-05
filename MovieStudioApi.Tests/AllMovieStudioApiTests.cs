using MovieStudioApi.DBEntities;
using NUnit.Framework;
using System;

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


        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

    }
}