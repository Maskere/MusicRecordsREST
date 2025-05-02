using Microsoft.AspNetCore.Mvc;

namespace DRMusic{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase {
        private MusicRecordRepository repo = new();

        // GET: api/<MusicRecordsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<MusicRecord>> Get([FromQuery] string? title = null, string? artist = null, int? duration = null, int? publication_year = null ) {
            List<MusicRecord>? mr = repo.Get();
            
            if (title != null)
            {
                mr = repo.Get(title);
            }
            if (artist != null)
            {
                mr = repo.Get(artist);
            }
            if (duration != null)
            {
                mr = repo.Get(duration:duration);
            }
            if (publication_year != null)
            {
                mr = repo.Get(publication_year:publication_year);
            }
            if (mr == null)
            {
                throw new ArgumentNullException("Collection is empty");
            }
            return new List<MusicRecord>(mr);
        }

        // GET api/<MusicRecordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MusicRecordsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MusicRecordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MusicRecordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
