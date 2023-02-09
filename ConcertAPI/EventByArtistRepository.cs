using ConcertAPI.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ConcertAPI
{
    public class EventByArtistRepository : IEventByArtistRepository
    {
        public EventByArtistRepository()
        {
            string auth = File.ReadAllText("appsettings.json");

            string authKey = JObject.Parse(auth).GetValue("client_id").ToString();

            var artistName = Console.ReadLine();

            string apiCall = $"https://api.seatgeek.com/2/events?performers.slug={artistName}&client_id={authKey}";
        }

        private readonly HttpClient _client;

        public EventByArtistRepository(HttpClient client)
        {
            _client = client;
        }

        public List<Events> GetEventByArtist(string apiCall)
        {
            var client = new HttpClient();

            var artistUrlResponse = client.GetStringAsync(apiCall).Result;

            var artistEvents = JObject.Parse(artistUrlResponse)["events"].ToString();

            List<Events> events = JsonConvert.DeserializeObject<List<Events>>(artistEvents);

            foreach (var item in events)
            {
                Console.WriteLine(item.venue.name);
                Console.WriteLine(item.url);
                Console.WriteLine(item.datetime_local);
                Console.WriteLine();
            }

            return events;
        }
    }    
}
