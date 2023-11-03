using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public void TDelete(Contact entity)
        {
            _contactDAL.Delete(entity);
        }

        public Contact TGetByID(int id)
        {
            return _contactDAL.GetByID(id);
        }

        public Contact TGetByIDAndSetRead(int id, bool read)
        {
            return _contactDAL.GetByIDAndSetRead(id, read);
        }

        public List<Contact> TGetList()
        {
           return _contactDAL.GetListAll();
        }

        public void TInsert(Contact entity)
        {
            _contactDAL.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactDAL.Update(entity);
        }
    }
}