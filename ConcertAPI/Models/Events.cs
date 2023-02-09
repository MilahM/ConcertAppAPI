using Newtonsoft.Json.Linq;

namespace ConcertAPI.Models
{
    public class Events
    {
        public string type { get; set; }
        public DateTime datetime_local { get; set; }
        public Venue venue { get; set; }
        public string url { get; set; }
    }
}
