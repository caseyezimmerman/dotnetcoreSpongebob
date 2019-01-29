using Microsoft.AspNetCore.Mvc;
using WebApplication1.Common;
using WebApplication1.Services.Domain.Interfaces;

namespace WebApplication1.Web.ApiConrollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
        [HttpGet("main")]
        public object GetACharacter([FromServices] ICharacterService character)
        {
            return character.GetCharacter();
        }

        [HttpGet("thing")]
        public IActionResult SaveACharacter([FromServices] ICharacterService characterService)
        {
            var thisCharacter = characterService.SaveCharacter();
            return Ok(thisCharacter);
        }
    }
}