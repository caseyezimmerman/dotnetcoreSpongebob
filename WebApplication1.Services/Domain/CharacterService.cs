using WebApplication1.Common;
using WebApplication1.Data;
using WebApplication1.Services.Domain.Interfaces;

namespace WebApplication1.Services.Domain
{
    public class CharacterService : ICharacterService
    {
        private readonly SpongebobContext _characterContext;

        public CharacterService(SpongebobContext characterContext)
        {
            _characterContext = characterContext;
        }
        public Character GetCharacter()
        {
            return new Character()
            {
                Name = "Spongebob",
                Age = 32,
                IsMain = true
            };
        }

        public Character SaveCharacter()
        {
            var newCharacter = new Character()
            {
                Name = "Flats",
                Age = 21,
                IsMain = false
            };

            _characterContext.Character.Add(newCharacter);

            _characterContext.SaveChanges();

            return newCharacter;

        }
    }
}