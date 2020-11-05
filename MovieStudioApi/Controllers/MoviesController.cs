using Microsoft.AspNetCore.Mvc;
using MovieStudioApi.Database;
using MovieStudioApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieStudioApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IDatabaseProvider _databaseProvider;

        public MoviesController(IDatabaseProvider databaseProvider)
        {
            _databaseProvider = databaseProvider;
        }


        [HttpGet("stats")]
        public IEnumerable<MovieStatsModel> Get()
        {
            var stats = new List<MovieStatsModel>();

            stats = _databaseProvider
                .GetAllMovies()
                .GroupBy(x => x.MovieId)
                .Select(g => new MovieStatsModel()
                {
                    MovieId = g.Key,
                    Title = g.First().Title,
                    AverageWatchDurationS = (int)g.Select(x => x.Duration.TotalSeconds).Average(),
                    Watches = g.Select(x => x.Id).Distinct().Count(),
                    ReleaseYear = g.First().ReleaseYear
                })
                .ToList();

            return stats;
        }

    }
}