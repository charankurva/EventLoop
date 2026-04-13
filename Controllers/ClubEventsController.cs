using EventLoop.Models;
using EventLoop.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EventLoop.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ClubEventsController : ControllerBase
    {
        private readonly IClubEventService _service;
        public ClubEventsController(IClubEventService service)
        {

            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<List<ClubEvent>>> GetEvents()
        {
            var clubevents = await _service.GetClubEvents();
            return Ok(clubevents);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ClubEvent>> GetEventById(Guid id)
        {
            var club=_service.GetClubEventById(id);
            if (club == null)
            {
                return NotFound($"No event found with ID: {id}");
            }
            else
            {
                return Ok(club);
            }

        }
        [HttpPost("{id:Guid}")]
        public async Task<ActionResult<ClubEvent>> UpdateClubEvent(Guid id,ClubEvent club)
        {
           var updatedPost= _service.UpdateClubEvent(id, club);
            if (updatedPost == null)
            {
                return NotFound();
            }
            return Ok(updatedPost);

        }

       
    }
}
