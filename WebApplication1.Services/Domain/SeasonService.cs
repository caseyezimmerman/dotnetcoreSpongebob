using WebApplication1.Common;
using WebApplication1.Services.Domain.Interfaces;

namespace WebApplication1.Services.Domain
{
    public class SeasonService : ISeasonService
    {
        public Season GetSeason()
        {
            return new Season()
            {
                SeasonNumber = 5,
                Year = 1998,
                NumberOfEpisodes = 24
            };
        }
        
        
    }
}