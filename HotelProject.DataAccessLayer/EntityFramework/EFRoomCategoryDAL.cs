﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFRoomCategoryDAL : GenericRepository<RoomCategory>, IRoomCategoryDAL
    {
    }
}