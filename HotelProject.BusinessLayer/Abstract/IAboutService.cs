using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
	public interface IAboutService : IGenericService<About>
	{
		void TChangeAboutStatus(int id);
		About TGetAbout();
	}
}