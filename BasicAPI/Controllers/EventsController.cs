using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private static List<Event> _events = new List<Event>() { new Event { Id = 1, Title = "default event" } };

        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _events;
        }

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Event eve)
        {
            _events.Add(new Event { Id = 2, Title = eve.Title });
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event eve)
        {
            var eve1 = _events.Find(e => e.Id == id);
            eve1.Title = eve.Title;
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var eve = _events.Find(e => e.Id == id);
            _events.Remove(eve);
        }
    }
}
