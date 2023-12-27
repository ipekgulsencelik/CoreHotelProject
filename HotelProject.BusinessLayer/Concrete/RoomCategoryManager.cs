using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomCategoryManager : IRoomCategoryService
    {
        private readonly IRoomCategoryDAL _roomCategoryDAL;

        public RoomCategoryManager(IRoomCategoryDAL roomCategoryDAL)
        {
            _roomCategoryDAL = roomCategoryDAL;
        }

        public void TDelete(RoomCategory entity)
        {
            _roomCategoryDAL.Delete(entity);
        }

        public RoomCategory TGetByID(int id)
        {
            return _roomCategoryDAL.GetByID(id);
        }

        public List<RoomCategory> TGetList()
        {
            return _roomCategoryDAL.GetListAll();
        }

        public void TInsert(RoomCategory entity)
        {
            _roomCategoryDAL.Insert(entity);
        }

        public void TUpdate(RoomCategory entity)
        {
            _roomCategoryDAL.Update(entity);
        }
    }
}