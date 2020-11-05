using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieStudioApi.Database;
using MovieStudioApi.DBEntities;
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
        public IEnumerable<Movie> Get()
        {
            var movies = _databaseProvider
                .GetAllMovies();
            _logger.LogInformation($"Get request done, returned {movies.Count()} movies!");

            return movies;
        }

        // GET api/<MetadataController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MetadataController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
