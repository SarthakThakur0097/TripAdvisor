using Microsoft.AspNetCore.Mvc;
using TripAdvisor_React.Data;
using TripAdvisor_React.Data.Models;

namespace TripAdvisor_React.Controllers
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private readonly ITripService _service;
        public TripsController(ITripService service)
        {
            _service = service;
        }
    
        [HttpGet("[action]")]
        public IActionResult GetTrips()
        {
            var allTrips = _service.GetAllTrips();
            return Ok(allTrips);
        }
        [HttpPost("AddTrip")]
        public IActionResult AddTrip([FromBody]Trip trip)
        {
            if(trip != null)
            {
                _service.AddTrip(trip);
            }
            return Ok();
        }

    }
}