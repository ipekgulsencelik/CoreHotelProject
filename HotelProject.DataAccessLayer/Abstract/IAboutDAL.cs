using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
	public interface IAboutDAL : IGenericDAL<About>
	{
		void ChangeAboutStatus(int id);
		About GetAbout();
	}
}