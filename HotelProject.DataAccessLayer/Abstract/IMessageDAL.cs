using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IMessageDAL : IGenericDAL<ContactMessage>
    {
        List<ContactMessage> GetInboxList(string session);
        List<ContactMessage> GetSendboxList(string session);
        List<ContactMessage> GetReadList(string session);
        List<ContactMessage> GetUnReadList(string session);
        List<ContactMessage> GetDraftList(string session);
        List<ContactMessage> GetTrashList();
        List<ContactMessage> GetSpamList(string session);
        List<ContactMessage> GetImportantList(string session);
    }
}