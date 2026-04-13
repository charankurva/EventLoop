using System.ComponentModel;

namespace EventLoop.Models
{
    public class ClubEvent
    {
        public Guid EventId { get; set; } = Guid.NewGuid();
        public string Title { get;set; }
        public string Description { get;set; }
        public string BannerImageUrl { get; set; }
        public string PosterImage {  get; set; }
        public virtual ICollection<User> Participants { get; set; } = new List<User>();
        public virtual ICollection<User> Organisers { get; set; } = new List<User>();
        public string Location { get;set; }
        public DateTime EventDate { get;set; }
        public TimeSpan EventDuration { get;set; }
        public clubcategory Category { get; set; }
        public int EventPrice {  get;set; }


    }
    public enum clubcategory
    {
        Art=0,
        Dance=1,
        Singing=2,
        Hacker=3,
        Acting=4
    }
      
}
