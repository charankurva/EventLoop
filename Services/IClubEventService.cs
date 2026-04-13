using EventLoop.Models;

namespace EventLoop.Services
{
    public interface IClubEventService
    {
        public Task<List<ClubEvent>> GetClubEvents();
        public Task<ClubEvent?> GetClubEventById(Guid id);
        public Task UpdateClubEvent(Guid id, ClubEvent clubEvent);
        public Task DeleteClubEvent(Guid id);


    }
}
