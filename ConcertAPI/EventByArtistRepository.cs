using ConcertAPI.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ConcertAPI
{
    public class EventByArtistRepository
    {
        private readonly HttpClient _client;

        public EventByArtistRepository(HttpClient client)
        {
            _client = client;
        }
        public static List<Events> GetEventByArtist(string apiCall)
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
