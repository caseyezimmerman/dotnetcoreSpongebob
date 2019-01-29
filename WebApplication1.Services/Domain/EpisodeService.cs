using WebApplication1.Common;
using WebApplication1.Data;
using WebApplication1.Services.Domain.Interfaces;

namespace WebApplication1.Services.Domain
{
    public class EpisodeService : IEpisodeService
    {
        private readonly SpongebobContext _context;
        public EpisodeService(SpongebobContext context)
        {
            _context = context;
        }
        public Episode GetEpisode()
        {
            return new Episode()
            {
                SeasonId = 3,
                EpisodeNumber = 12,
                HasSpongebob = true
            };
        }

        public Episode DoThing()
        {
            var ep = new Episode()
            {
                SeasonId = 3,
                EpisodeNumber = 21,
                HasSpongebob = true
            };
            _context.Episode.Add(ep);

            // or
            // context.Add<Student>(std);

            _context.SaveChanges();

            return ep;
        }
        
//        using (var context = new WebApplication1Context())
//        {
//            var ep = new Episode()
//            {
//                SeasonId = 3,
//                EpisodeNumber = 21,
//                HasSpongebob = true
//            };
//            context.Episode.Add(ep);
//
//            // or
//            // context.Add<Student>(std);
//
//            context.SaveChanges();
//        }
    }
}