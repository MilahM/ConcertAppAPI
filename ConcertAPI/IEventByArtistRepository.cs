using ConcertAPI.Models;

namespace ConcertAPI
{
    public interface IEventByArtistRepository
    {
        public List<Events> GetEventByArtist(string apiCall);
    }

}
