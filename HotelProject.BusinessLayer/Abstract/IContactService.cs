using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        Contact TGetByIDAndSetRead(int id, bool read);
    }
}