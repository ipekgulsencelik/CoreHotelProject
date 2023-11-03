using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
        List<Message> TGetInboxList(string session);
        List<Message> TGetSendboxList(string session);
        List<Message> TGetReadList(string session);
        List<Message> TGetUnReadList(string session);
        List<Message> TGetDraftList(string session);
        List<Message> TGetTrashList();
        List<Message> TGetSpamList(string session);
        List<Message> TGetImportantList(string session);
    }
}