using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RestaurantManager : IRestaurantService
    {
        private readonly IRestaurantDAL _restaurantDAL;

        public RestaurantManager(IRestaurantDAL restaurantDAL)
        {
            _restaurantDAL = restaurantDAL;
        }

        public void TDelete(Restaurant entity)
        {
            _restaurantDAL.Delete(entity);
        }

        public Restaurant TGetByID(int id)
        {
            return _restaurantDAL.GetByID(id);
        }

        public List<Restaurant> TGetList()
        {
            return _restaurantDAL.GetListAll();
        }

        public void TInsert(Restaurant entity)
        {
            _restaurantDAL.Insert(entity);
        }

        public void TUpdate(Restaurant entity)
        {
            _restaurantDAL.Update(entity);
        }
    }
}