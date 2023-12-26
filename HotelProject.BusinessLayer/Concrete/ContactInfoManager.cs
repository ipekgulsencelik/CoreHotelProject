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
    public class ContactInfoManager : IContactInfoService
    {
        private readonly IContactInfoDAL _contactInfoDAL;

        public ContactInfoManager(IContactInfoDAL contactInfoDAL)
        {
            _contactInfoDAL = contactInfoDAL;
        }

        public void TDelete(ContactInfo entity)
        {
            _contactInfoDAL.Delete(entity);
        }

        public ContactInfo TGetByID(int id)
        {
            return _contactInfoDAL.GetByID(id);
        }

        public List<ContactInfo> TGetList()
        {
           return _contactInfoDAL.GetListAll();
        }

        public void TInsert(ContactInfo entity)
        {
            _contactInfoDAL.Insert(entity);
        }

        public void TUpdate(ContactInfo entity)
        {
           _contactInfoDAL.Update(entity);
        }
    }
}
