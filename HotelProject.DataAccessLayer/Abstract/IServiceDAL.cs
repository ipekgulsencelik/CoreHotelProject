using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IServiceDAL : IGenericDAL<Service>
    {
        void ChangeServiceStatus(int id);
        void ChangeHomeStatus(int id);
        List<Service> GetLast4ActiveServices();
        List<Service> GetActiveServices();
    }
}