using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]

    public class ContactInfoController : Controller
    {
        private readonly IContactInfoService _ContactInfoService;

        public ContactInfoController(IContactInfoService ContactInfoService)
        {
            _ContactInfoService = ContactInfoService;
        }

        public IActionResult Index()
        {
            var values = _ContactInfoService.TGetList();
            return View(values);
        }
    }
}
