using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class CarouselController : Controller
    {
        private readonly ICarouselService _CarouselService;

        public CarouselController(ICarouselService CarouselService)
        {
            _CarouselService = CarouselService;
        }

        public IActionResult Index()
        {
            var values = _CarouselService.TGetList();
            return View(values);
        }
    }
}
