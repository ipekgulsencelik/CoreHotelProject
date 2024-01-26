using HotelProject.BusinessLayer.Abstract;
using HotelProject.DTOLayer.DTOs.AboutDTOs;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AboutsController : ControllerBase
	{
		private readonly IAboutService _aboutService;

		public AboutsController(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}

		[HttpGet]
		public IActionResult AboutList()
		{
			var values = _aboutService.TGetList();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateAbout(CreateAboutDTO createAboutDTO)
		{
			About about = new About()
			{
				Title1 = createAboutDTO.Title1,
				Title2 = createAboutDTO.Title2,
				Description1 = createAboutDTO.Description1,
				Description2 = createAboutDTO.Description2,
				VideoURL = createAboutDTO.VideoURL,
				IsActive = createAboutDTO.IsActive,
			};
			_aboutService.TInsert(about);
			return Ok("Hakkımızda Bilgisi Başarılı Bir Şekilde Eklendi");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteAbout(int id)
		{
			var values = _aboutService.TGetByID(id);
			_aboutService.TDelete(values);
			return Ok("Hakkımızda Bilgisi Başarılı Bir Şekilde Silindi");
		}

		[HttpGet("{id}")]
		public IActionResult GetAbout(int id)
		{
			var values = _aboutService.TGetByID(id);
			return Ok(values);
		}

		[HttpPut]
		public IActionResult UpdateAbout(UpdateAboutDTO updateAboutDTO)
		{
			About about = new About()
			{
				Title1 = updateAboutDTO.Title1,
				Title2 = updateAboutDTO.Title2,
				Description1 = updateAboutDTO.Description1,
				Description2 = updateAboutDTO.Description2,
				VideoURL = updateAboutDTO.VideoURL,
				IsActive = updateAboutDTO.IsActive,
				AboutID = updateAboutDTO.AboutID
			};
			_aboutService.TUpdate(about);
			return Ok("Hakkımızda Bilgisi Başarılı Bir Şekilde Güncellendi");
		}

		[HttpGet("GetActiveAbout")]
		public IActionResult GetActiveAbouts()
		{
			var values = _aboutService.TGetAbout();
			return Ok(values);
		}

		[HttpGet("ChangeAboutStatus/{id}")]
		public IActionResult ChangeAboutStatus(int id)
		{
			_aboutService.TChangeAboutStatus(id);
			return Ok("Hakkımızda Bilgisi Durum Değeri Değiştirildi");
		}
	}
}