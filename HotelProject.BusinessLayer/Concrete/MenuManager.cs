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
    public class MenuManager : IMenuService
    {
        private readonly IMenuDAL _menuDAL;

        public MenuManager(IMenuDAL menuDAL)
        {
            _menuDAL = menuDAL;
        }

        public void TDelete(Menu entity)
        {
            _menuDAL.Delete(entity);
        }

        public Menu TGetByID(int id)
        {
          return  _menuDAL.GetByID(id);
        }

        public List<Menu> TGetList()
        {
           return _menuDAL.GetListAll();
        }

        public void TInsert(Menu entity)
        {
            _menuDAL.Insert(entity);
        }

        public void TUpdate(Menu entity)
        {
           _menuDAL.Update(entity);
        }
    }
}
