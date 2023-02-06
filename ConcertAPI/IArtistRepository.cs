using ConcertAPI.Models;

namespace ConcertAPI
{
    public interface IArtistRepository
    {
        public Artist GetArtist(string name);
    }
}
