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
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDAL _reservationDAL;

        public ReservationManager(IReservationDAL reservationDAL)
        {
            _reservationDAL = reservationDAL;
        }

        public void TDelete(Reservation entity)
        {
           _reservationDAL.Delete(entity);
        }

        public Reservation TGetByID(int id)
        {
           return _reservationDAL.GetByID(id);
        }

        public List<Reservation> TGetList()
        {
            return _reservationDAL.GetListAll();
        }

        public void TInsert(Reservation entity)
        {
            _reservationDAL.Insert(entity);
        }

        public void TUpdate(Reservation entity)
        {
           _reservationDAL.Update(entity);
        }
    }
}
