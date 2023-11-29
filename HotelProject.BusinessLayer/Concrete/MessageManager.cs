using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDAL _messageDAL;

        public MessageManager(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public void TDelete(ContactMessage entity)
        {
            _messageDAL.Delete(entity);
        }

        public ContactMessage TGetByID(int id)
        {
            return _messageDAL.GetByID(id);
        }

        public List<ContactMessage> TGetDraftList(string session)
        {
            return _messageDAL.GetDraftList(session);
        }

        public List<ContactMessage> TGetImportantList(string session)
        {
            return _messageDAL.GetImportantList(session);
        }

        public List<ContactMessage> TGetInboxList(string session)
        {
            return _messageDAL.GetInboxList(session);
        }

        public List<ContactMessage> TGetList()
        {
            return _messageDAL.GetListAll();
        }

        public List<ContactMessage> TGetReadList(string session)
        {
            return _messageDAL.GetReadList(session);
        }

        public List<ContactMessage> TGetSendboxList(string session)
        {
            return _messageDAL.GetSendboxList(session);
        }

        public List<ContactMessage> TGetSpamList(string session)
        {
            return _messageDAL.GetSpamList(session);
        }

        public List<ContactMessage> TGetTrashList()
        {
            return _messageDAL.GetTrashList();
        }

        public List<ContactMessage> TGetUnReadList(string session)
        {
            return _messageDAL.GetUnReadList(session);
        }

        public void TInsert(ContactMessage entity)
        {
            _messageDAL.Insert(entity);
        }

        public void TUpdate(ContactMessage entity)
        {
            _messageDAL.Update(entity);
        }
    }
}