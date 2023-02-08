using Microsoft.AspNetCore.Mvc;

namespace ConcertAPI.Controllers
{
    public class VenueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
