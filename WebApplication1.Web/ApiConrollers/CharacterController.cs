using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.Domain.Interfaces;

namespace WebApplication1.Web.ApiConrollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController
    {
        [HttpGet("main")]
        public object GetACharacter([FromServices] ICharacterService character)
        {
            return character.GetCharacter();
        }
    }
}