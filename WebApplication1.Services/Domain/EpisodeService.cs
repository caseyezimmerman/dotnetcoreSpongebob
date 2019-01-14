using WebApplication1.Common;
using WebApplication1.Services.Domain.Interfaces;

namespace WebApplication1.Services.Domain
{
    public class EpisodeService : IEpisodeService
    {
        public Episode GetEpisode()
        {
            return new Episode()
            {
                SeasonId = 3,
                EpisodeNumber = 12,
                HasSpongebob = true
            };
        }
    }
}