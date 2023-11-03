using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFContactDAL : GenericRepository<Contact>, IContactDAL
    {
        public Contact GetByIDAndSetRead(int id, bool read)
        {
            var context = new Context();
            var value = context.Contacts.Where(x => x.ContactID == id && x.IsRead == true).FirstOrDefault();
            return value;
        }
    }
}