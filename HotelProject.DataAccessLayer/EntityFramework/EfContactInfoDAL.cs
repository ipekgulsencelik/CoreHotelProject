using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfContactInfoDAL: GenericRepository<ContactInfo>,IContactInfoDAL
    {

    }
}
