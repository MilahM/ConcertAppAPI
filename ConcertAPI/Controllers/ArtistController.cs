using Microsoft.AspNetCore.Mvc;

namespace ConcertAPI.Controllers
{
    public class ArtistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
