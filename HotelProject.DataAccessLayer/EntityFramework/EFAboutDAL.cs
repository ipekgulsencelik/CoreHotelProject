using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EFAboutDAL : GenericRepository<About>, IAboutDAL
	{
		public void ChangeAboutStatus(int id)
		{
			var context = new Context();
			var about = context.Abouts.Where(x => x.AboutID == id).FirstOrDefault();
			if (about.IsActive == true)
			{
				about.IsActive = false;
			}
			else
			{
				about.IsActive = true;
			}
			context.Update(about);
			context.SaveChanges();
		}

		public About GetAbout()
		{
			var context = new Context();
			var about = context.Abouts.Where(x => x.IsActive == true).OrderByDescending(x => x.AboutID).FirstOrDefault();
			return about;
		}
	}
}