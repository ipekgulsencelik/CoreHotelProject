using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IServiceService : IGenericService<Service>
    {
        void TChangeServiceStatus(int id);
        void TChangeHomeStatus(int id);
        List<Service> TGetLast4ActiveServices();
        List<Service> TGetActiveServices();
    }
}