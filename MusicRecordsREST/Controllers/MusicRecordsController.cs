using DRMusic.Records;
using Microsoft.AspNetCore.Mvc;

namespace DRMusic{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase {
        private MusicRecordRepository repo = new();

        // GET: api/<MusicRecordsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<List<MusicRecordModel>> Get([FromQuery] string? title = null, string? artist = null, int? duration = null, int? publication_year = null ) {
            try{
                List<MusicRecordModel>? mr = repo.Get();
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
                if(mr.Count == 0){
                    return NoContent();
                }
                return Ok(new List<MusicRecordModel>(mr));
            }
            catch(ArgumentNullException){
                return NoContent();
            }
        }

        // GET api/<MusicRecordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MusicRecordsController>
        [HttpPost]
        public MusicRecordModel Post([FromBody] MusicRecord record)
        {
            MusicRecordModel converted = RecordsHelper.ConvertDRMusicRecord(record);
            MusicRecordModel createdmusic = repo.Add(converted);
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
