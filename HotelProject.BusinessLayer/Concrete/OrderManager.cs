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
    public class OrderManager : IOrderService
    {
        private readonly IOrderDAL _orderDAL;

        public OrderManager(IOrderDAL orderDAL)
        {
            _orderDAL = orderDAL;
        }

        public void TDelete(Order entity)
        {
            _orderDAL.Delete(entity);
        }

        public Order TGetByID(int id)
        {
           return _orderDAL.GetByID(id);
        }

        public List<Order> TGetList()
        {
            return _orderDAL.GetListAll();
        }

        public void TInsert(Order entity)
        {
            _orderDAL.Insert(entity);
        }

        public void TUpdate(Order entity)
        {
           _orderDAL.Update(entity);
        }
    }
}
