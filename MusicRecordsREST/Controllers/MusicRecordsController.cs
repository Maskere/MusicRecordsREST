using Microsoft.AspNetCore.Mvc;

namespace DRMusic{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase {
        private MusicRecordRepository repo = new();

        // GET: api/<MusicRecordsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public List<MusicRecord> Get() {
            List<MusicRecord>? mr = repo.Get();
            if(mr == null){
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
