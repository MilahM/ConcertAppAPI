using Microsoft.AspNetCore.Mvc;

namespace ConcertAPI.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IEventByArtistRepository repo;

        public ArtistController(IEventByArtistRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ArtistEvents()
        {

        }
       
    }
}
