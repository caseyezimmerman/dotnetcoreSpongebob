using WebApplication1.Common;
using WebApplication1.Services.Domain.Interfaces;

namespace WebApplication1.Services.Domain
{
    public class CharacterService : ICharacterService
    {
        public Character GetCharacter()
        {
            return new Character()
            {
                Name = "Spongebob",
                Age = 32,
                IsMain = true
            };
        }
    }
}