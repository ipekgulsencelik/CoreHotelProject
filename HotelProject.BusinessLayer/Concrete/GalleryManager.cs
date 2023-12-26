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
    public class GalleryManager : IGalleryService
    {
        private readonly IGalleryDAL _galleryDAL;
        public void TDelete(Gallery entity)
        {
           _galleryDAL.Delete(entity);
        }

        public Gallery TGetByID(int id)
        {
           return _galleryDAL.GetByID(id);  
        }

        public List<Gallery> TGetList()
        {
           return _galleryDAL.GetListAll();
        }

        public void TInsert(Gallery entity)
        {
            _galleryDAL.Insert(entity);
        }

        public void TUpdate(Gallery entity)
        {
           _galleryDAL.Update(entity);
        }
    }
}
