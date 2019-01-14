using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using WebApplication1.Services.Domain.Interfaces;

namespace WebApplication1.Web.ApiConrollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EpisodeController : Controller
    {

        [HttpGet("thisEpisode")]
        public object GetAnEpisode([FromServices] IEpisodeService episode)
        {
            return episode.GetEpisode();
        }
    }

    
}