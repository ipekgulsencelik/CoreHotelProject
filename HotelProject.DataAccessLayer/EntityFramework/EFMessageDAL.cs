using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFMessageDAL : GenericRepository<Message>, IMessageDAL
    {
        public List<Message> GetDraftList(string session)
        {
            var context = new Context();
            var values = context.Messages.Where(x => x.IsDraft == true && x.SenderMail == session).ToList();
            return values;
        }

        public List<Message> GetImportantList(string session)
        {
            var context = new Context();
            var values = context.Messages.Where(x => x.IsImportant == true && x.ReceiverMail == session).ToList();
            return values;
        }

        public List<Message> GetInboxList(string session)
        {
            var context = new Context();
            var values = context.Messages.Where(x => x.ReceiverMail == session).ToList();
            return values;
        }

        public List<Message> GetReadList(string session)
        {
            var context = new Context();
            var values = context.Messages.Where(x => x.IsRead == true && x.ReceiverMail == session).ToList();
            return values;
        }

        public List<Message> GetSendboxList(string session)
        {
            var context = new Context();
            var values = context.Messages.Where(x => x.SenderMail == session).ToList();
            return values;
        }

        public List<Message> GetSpamList(string session)
        {
            var context = new Context();
            var values = context.Messages.Where(x => x.IsSpam == true && x.ReceiverMail == session).ToList();
            return values;
        }

        public List<Message> GetTrashList()
        {
            var context = new Context();
            var values = context.Messages.Where(x => x.IsTrash == true).ToList();
            return values;
        }

        public List<Message> GetUnReadList(string session)
        {
            var context = new Context();
            var values = context.Messages.Where(x => x.IsRead == false && x.ReceiverMail == session).ToList();
            return values;
        }
    }
}