using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFServiceDAL : GenericRepository<Service>, IServiceDAL
    {
        public void ChangeHomeStatus(int id)
        {
            var context = new Context();
            var service = context.Services.Where(x => x.ServiceID == id).FirstOrDefault();
            if (service.IsHome == true)
            {
                service.IsHome = false;
            }
            else
            {
                service.IsHome = true;
            }
            context.Update(service);
            context.SaveChanges();
        }

        public void ChangeServiceStatus(int id)
        {
            var context = new Context();
            var service = context.Services.Where(x => x.ServiceID == id).FirstOrDefault();
            if (service.IsActive == true)
            {
                service.IsActive = false;
            }
            else
            {
                service.IsActive = true;
            }
            context.Update(service);
            context.SaveChanges();
        }

        public List<Service> GetActiveServices()
        {
            var context = new Context();
            var values = context.Services.Where(x => x.IsActive == true).ToList();
            return values;
        }

        public List<Service> GetLast4ActiveServices()
        {
            var context = new Context();
            var serviceCount = context.Services.Where(x => x.IsActive == true && x.IsHome == true).Count();
            var values = context.Services.Where(x => x.IsActive == true && x.IsHome == true).ToList();
            if (serviceCount <= 4)
            {
                values = context.Services.Where(x => x.IsActive == true && x.IsHome == true).OrderByDescending(x => x.ServiceID).ToList();
            }
            else
            {
                values = context.Services.Where(x => x.IsActive == true && x.IsHome == true).OrderByDescending(x => x.ServiceID).Take(4).ToList();
            }
            return values;
        }
    }
}