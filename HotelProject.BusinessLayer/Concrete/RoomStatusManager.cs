using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomStatusManager : IRoomStatusService
    {
        private readonly IRoomStatusDAL _roomStatusDAL;

        public RoomStatusManager(IRoomStatusDAL roomStatusDAL)
        {
            _roomStatusDAL = roomStatusDAL;
        }

        public void TDelete(RoomStatus entity)
        {
            _roomStatusDAL.Delete(entity);
        }

        public RoomStatus TGetByID(int id)
        {
            return _roomStatusDAL.GetByID(id);
        }

        public List<RoomStatus> TGetList()
        {
            return _roomStatusDAL.GetListAll();
        }

        public void TInsert(RoomStatus entity)
        {
            _roomStatusDAL.Insert(entity);
        }

        public void TUpdate(RoomStatus entity)
        {
            _roomStatusDAL.Update(entity);
        }
    }
}