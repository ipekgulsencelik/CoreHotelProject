using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDAL _serviceDAL;

        public ServiceManager(IServiceDAL serviceDAL)
        {
            _serviceDAL = serviceDAL;
        }

        public void TChangeHomeStatus(int id)
        {
            _serviceDAL.ChangeHomeStatus(id);
        }

        public void TChangeServiceStatus(int id)
        {
            _serviceDAL.ChangeServiceStatus(id);
        }

        public void TDelete(Service entity)
        {
            _serviceDAL.Delete(entity);
        }

        public List<Service> TGetActiveServices()
        {
            return _serviceDAL.GetActiveServices();
        }

        public Service TGetByID(int id)
        {
            return _serviceDAL.GetByID(id);
        }

        public List<Service> TGetLast4ActiveServices()
        {
            return _serviceDAL.GetLast4ActiveServices();
        }

        public List<Service> TGetList()
        {
            return _serviceDAL.GetListAll();
        }

        public void TInsert(Service entity)
        {
            _serviceDAL.Insert(entity);
        }

        public void TUpdate(Service entity)
        {
            _serviceDAL.Update(entity);
        }
    }
}