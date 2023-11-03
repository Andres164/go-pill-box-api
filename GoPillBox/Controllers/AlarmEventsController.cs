using GoPillBox.Models;
using GoPillBox.Models.ViewModels;
using GoPillBox.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace GoPillBox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlarmEventsController : ControllerBase
    {
        private readonly IAlarmEventRepository _alarmEventRepository;

        public AlarmEventsController(IAlarmEventRepository alarmEventRepository)
        {
            this._alarmEventRepository = alarmEventRepository;
        }

        // GET: api/<AlarmEventsController>
        [HttpGet]
        [ProducesResponseType(typeof(AlarmEvent), 200)]
        public async Task<IActionResult> Get()
        {
            List<AlarmEvent> alarEvents = await this._alarmEventRepository.ReadAllAsync();
            return Ok(alarEvents);
        }

        // GET api/<AlarmEventsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(AlarmEvent), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get(int id)
        {
            AlarmEvent? alarmEvent = await this._alarmEventRepository.ReadAsync(id);
            if (alarmEvent == null)
                return NotFound();
            return Ok(alarmEvent);
        }

        // POST api/<AlarmEventsController>
        [HttpPost]
        [ProducesResponseType(typeof(AlarmEvent), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Post([FromBody] AlarmEventView newAlarmEvent)
        {
            AlarmEvent? createdAlarmEvent = await this._alarmEventRepository.CreateAsync(newAlarmEvent);
            if (createdAlarmEvent == null)
                return StatusCode(500, "Unexpected error while creating the user, the user wasn't created");
            return Ok(createdAlarmEvent);
        }

        // PUT api/<AlarmEventsController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public Task<IActionResult> Put(int id, [FromBody] string value)
        {

        }
    }
}
