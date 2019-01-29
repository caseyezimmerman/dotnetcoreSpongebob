using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.Domain.Interfaces;

namespace WebApplication1.Web.ApiConrollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeasonController : Controller
    {
        [HttpGet("season")]
        public object GetASeason([FromServices] ISeasonService season)
        {
            return season.GetSeason().Year;
        }
    }
}