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
    public class CarouselManager : ICarouselService
    {
        private readonly ICarouselDal _carouselDal;

        public CarouselManager(ICarouselDal carouselDal)
        {
            _carouselDal = carouselDal;
        }

        public void TDelete(Carousel entity)
        {
           _carouselDal.Delete(entity);
        }

        public Carousel TGetByID(int id)
        {
            return _carouselDal.GetByID(id);
        }

        public List<Carousel> TGetList()
        {
           return _carouselDal.GetListAll();
        }

        public void TInsert(Carousel entity)
        {
            _carouselDal.Insert(entity);
        }

        public void TUpdate(Carousel entity)
        {
          _carouselDal.Update(entity);
        }
    }
}
