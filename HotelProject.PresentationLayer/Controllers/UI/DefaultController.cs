using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Controllers.UI
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About() {
            return View();
        }
    }
}
