using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStudioApi.Database;
using MovieStudioApi.DBEntities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieStudioApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MetadataController : ControllerBase
    {
        private readonly IDatabaseProvider _databaseProvider;

        public MetadataController(IDatabaseProvider databaseProvider)
        {
            _databaseProvider = databaseProvider;
        }

        // GET: api/<MetadataController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _databaseProvider
                .GetAllMovies();
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
