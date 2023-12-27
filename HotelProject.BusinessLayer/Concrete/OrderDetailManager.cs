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
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDAL _orderDetailDAL;

        public OrderDetailManager(IOrderDetailDAL orderDetailDAL)
        {
            _orderDetailDAL = orderDetailDAL;
        }

        public void TDelete(OrderDetail entity)
        {
          _orderDetailDAL.Delete(entity);
        }

        public OrderDetail TGetByID(int id)
        {
           return _orderDetailDAL.GetByID(id);
        }

        public List<OrderDetail> TGetList()
        {
            return _orderDetailDAL.GetListAll();
        }

        public void TInsert(OrderDetail entity)
        {
           _orderDetailDAL.Insert(entity);
        }

        public void TUpdate(OrderDetail entity)
        {
            _orderDetailDAL.Update(entity);
        }
    }
}
