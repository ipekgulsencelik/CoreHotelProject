using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IMessageService : IGenericService<ContactMessage>
    {
        List<ContactMessage> TGetInboxList(string session);
        List<ContactMessage> TGetSendboxList(string session);
        List<ContactMessage> TGetReadList(string session);
        List<ContactMessage> TGetUnReadList(string session);
        List<ContactMessage> TGetDraftList(string session);
        List<ContactMessage> TGetTrashList();
        List<ContactMessage> TGetSpamList(string session);
        List<ContactMessage> TGetImportantList(string session);
    }
}