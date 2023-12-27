using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void TDelete(About entity)
        {
            _aboutDAL.Delete(entity);
        }

        public About TGetByID(int id)
        {
            return _aboutDAL.GetByID(id);
        }

        public List<About> TGetList()
        {
            return _aboutDAL.GetListAll();
        }

        public void TInsert(About entity)
        {
            _aboutDAL.Insert(entity);
        }

        public void TUpdate(About entity)
        {
           _aboutDAL.Update(entity);
        }
    }
}
