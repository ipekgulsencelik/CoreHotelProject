using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ReviewManager : IReviewService
    {
        private readonly IReviewDAL _reviewDAL;

        public ReviewManager(IReviewDAL reviewDAL)
        {
            _reviewDAL = reviewDAL;
        }

        public void TDelete(Review entity)
        {
            _reviewDAL.Delete(entity);
        }

        public Review TGetByID(int id)
        {
            return _reviewDAL.GetByID(id);
        }

        public List<Review> TGetList()
        {
            return _reviewDAL.GetListAll();
        }

        public void TInsert(Review entity)
        {
            _reviewDAL.Insert(entity);
        }

        public void TUpdate(Review entity)
        {
            _reviewDAL.Update(entity);
        }
    }
}