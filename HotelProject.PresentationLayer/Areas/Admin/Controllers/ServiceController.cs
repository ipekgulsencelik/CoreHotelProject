﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            _serviceService.TInsert(service);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.TGetByID(id);
            _serviceService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id) 
        { 
            var value = _serviceService.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeHomeStatus(int id)
        {
            _serviceService.TChangeHomeStatus(id);
            return RedirectToAction("Index");
        }

        public ActionResult ChangeStatus(int id)
        {
            _serviceService.TChangeServiceStatus(id);
            return RedirectToAction("Index");
        }
    }
}