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
    public class ContactMessageManager : IContactMessageService
    {
        private readonly IContactMessageDAL _contactMessageDAL;

        public ContactMessageManager(IContactMessageDAL contactMessageDAL)
        {
            _contactMessageDAL = contactMessageDAL;
        }

        public void TDelete(ContactMessage entity)
        {
           _contactMessageDAL.Delete(entity);
        }

        public ContactMessage TGetByID(int id)
        {
            return _contactMessageDAL.GetByID(id);
        }

        public List<ContactMessage> TGetList()
        {
            return _contactMessageDAL.GetListAll();
        }

        public void TInsert(ContactMessage entity)
        {
           _contactMessageDAL.Insert(entity);
        }

        public void TUpdate(ContactMessage entity)
        {
            _contactMessageDAL.Update(entity);
        }
    }
}
