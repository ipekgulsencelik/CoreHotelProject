using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDAL _serviceDAL;
        public void TDelete(Service entity)
        {
            _serviceDAL.Delete(entity);
        }

        public Service TGetByID(int id)
        {
            return _serviceDAL.GetByID(id);
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
