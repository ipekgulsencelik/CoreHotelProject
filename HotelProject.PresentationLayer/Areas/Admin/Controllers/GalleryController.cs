using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]

    public class GalleryController : Controller
    {
        private readonly IGalleryService _GalleryService;

        public GalleryController(IGalleryService GalleryService)
        {
            _GalleryService = GalleryService;
        }

        public IActionResult Index()
        {
            var values = _GalleryService.TGetList();
            return View(values);
        }
    }
}
