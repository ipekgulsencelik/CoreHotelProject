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

        public void TDelete(Message entity)
        {
            _messageDAL.Delete(entity);
        }

        public Message TGetByID(int id)
        {
            return _messageDAL.GetByID(id);
        }

        public List<Message> TGetDraftList(string session)
        {
            return _messageDAL.GetDraftList(session);
        }

        public List<Message> TGetImportantList(string session)
        {
            return _messageDAL.GetImportantList(session);
        }

        public List<Message> TGetInboxList(string session)
        {
            return _messageDAL.GetInboxList(session);
        }

        public List<Message> TGetList()
        {
            return _messageDAL.GetListAll();
        }

        public List<Message> TGetReadList(string session)
        {
            return _messageDAL.GetReadList(session);
        }

        public List<Message> TGetSendboxList(string session)
        {
            return _messageDAL.GetSendboxList(session);
        }

        public List<Message> TGetSpamList(string session)
        {
            return _messageDAL.GetSpamList(session);
        }

        public List<Message> TGetTrashList()
        {
            return _messageDAL.GetTrashList();
        }

        public List<Message> TGetUnReadList(string session)
        {
            return _messageDAL.GetUnReadList(session);
        }

        public void TInsert(Message entity)
        {
            _messageDAL.Insert(entity);
        }

        public void TUpdate(Message entity)
        {
            _messageDAL.Update(entity);
        }
    }
}