using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomDetailManager : IRoomDetailService
    {
        private readonly IRoomDetailDAL _roomDetailDAL;

        public RoomDetailManager(IRoomDetailDAL roomDetailDAL)
        {
            _roomDetailDAL = roomDetailDAL;
        }

        public void TDelete(RoomDetail entity)
        {
            _roomDetailDAL.Delete(entity);
        }

        public RoomDetail TGetByID(int id)
        {
            return _roomDetailDAL.GetByID(id);
        }

        public List<RoomDetail> TGetList()
        {
            return _roomDetailDAL.GetListAll();
        }

        public void TInsert(RoomDetail entity)
        {
            _roomDetailDAL.Insert(entity);
        }

        public void TUpdate(RoomDetail entity)
        {
            _roomDetailDAL.Update(entity);
        }
    }
}