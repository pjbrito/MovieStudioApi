using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieStudioApi.Database;
using MovieStudioApi.DBEntities;
using MovieStudioApi.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieStudioApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MetadataController : ControllerBase
    {
        private readonly ILogger<MetadataController> _logger;
        private readonly IDatabaseProvider _databaseProvider;

        public MetadataController(ILogger<MetadataController> logger, IDatabaseProvider databaseProvider)
        {
            _logger = logger;
            _databaseProvider = databaseProvider;
        }

        // GET: api/<MetadataController>
        [HttpGet]
        public IEnumerable<MovieModel> Get()
        {
            var movies = _databaseProvider
                .GetAllMovies();
            _logger.LogInformation($"Get request done, returned {movies.Count()} movies!");

            return movies
                .Select(x => new MovieModel(x));
        }

        // GET api/<MetadataController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var responseData = _databaseProvider
                .GetAllMovies()
                .Where(x => x.MovieId == id)
                .Where(x => x.IsValid())
                .OrderBy(x => x.Language)
                .Select(x => new MovieModel(x));
            if (!responseData.Any())
            {
                return NotFound();
            }

            return Ok(responseData);
        }

        // POST api/<MetadataController>
        [HttpPost]
        public void Post([FromBody] MovieModel movie)
        {
            var v1 = movie.MovieId;
            _databaseProvider.SaveMovieToDatabase(MovieModel.ConvertToMovie(movie));
        }

    }
}
