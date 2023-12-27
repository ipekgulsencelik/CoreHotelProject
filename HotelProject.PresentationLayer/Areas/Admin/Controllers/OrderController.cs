using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            var values=_orderService.TGetList();
            return View(values);
        }
    }
}
