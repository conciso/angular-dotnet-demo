using AngularDotnetDemo.Core.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularDotnetDemo.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EventsController : ControllerBase
  {

    [HttpGet("{Id:long}")]
    [ProducesResponseType<Event>(200)]
    [ProducesResponseType<ProblemDetails>(404)]
    public async Task<ActionResult<Event>> GetEventById(long Id)
    {

      return Ok();
    }
  }
}
