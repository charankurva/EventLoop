using EventLoop.Models;

namespace EventLoop.Services
{
    public class ClubEventService:IClubEventService
    {
        private static readonly List<ClubEvent> club_events=new List<ClubEvent>();
        public Task<List<ClubEvent>> GetClubEvents()
        {
            return Task.FromResult(club_events);
        }

        public Task<ClubEvent?> GetClubEventById(Guid id) { 
        
           var club= club_events.FirstOrDefault(x=>x.EventId==id);
            return Task.FromResult(club);
        }

        public Task UpdateClubEvent(Guid id,ClubEvent clubEvent) {
            var club = club_events.FirstOrDefault(x => x.EventId == id);
            club.Title= clubEvent.Title;
            club.Description= clubEvent.Description;
            club.Location= clubEvent.Location;
            club.EventPrice= clubEvent.EventPrice;
            club.EventDate= clubEvent.EventDate;
            club.EventDuration= clubEvent.EventDuration;
            club.BannerImageUrl= clubEvent.BannerImageUrl;
            club.Organisers= clubEvent.Organisers;
            club.Participants= clubEvent.Participants;
            club.PosterImage= clubEvent.PosterImage;
            return Task.CompletedTask;
        }

        public Task DeleteClubEvent(Guid id) {
            var club = club_events.FirstOrDefault(x => x.EventId == id);
            club_events.Remove(club);
            return Task.CompletedTask;
        }
    }
}
