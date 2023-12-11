using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFMessageDAL : GenericRepository<ContactMessage>, IMessageDAL
    {
        //public List<ContactMessage> GetDraftList(string session)
        //{
        //    var context = new Context();
        //    var values = context.Messages.Where(x => x.IsDraft == true && x.SenderMail == session).ToList();
        //    return values;
        //}

        //public List<ContactMessage> GetImportantList(string session)
        //{
        //    var context = new Context();
        //    var values = context.Messages.Where(x => x.IsImportant == true && x.ReceiverMail == session).ToList();
        //    return values;
        //}

        //public List<ContactMessage> GetInboxList(string session)
        //{
        //    var context = new Context();
        //    var values = context.Messages.Where(x => x.ReceiverMail == session).ToList();
        //    return values;
        //}

        //public List<ContactMessage> GetReadList(string session)
        //{
        //    var context = new Context();
        //    var values = context.Messages.Where(x => x.IsRead == true && x.ReceiverMail == session).ToList();
        //    return values;
        //}

        //public List<ContactMessage> GetSendboxList(string session)
        //{
        //    var context = new Context();
        //    var values = context.Messages.Where(x => x.SenderMail == session).ToList();
        //    return values;
        //}

        //public List<ContactMessage> GetSpamList(string session)
        //{
        //    var context = new Context();
        //    var values = context.Messages.Where(x => x.IsSpam == true && x.ReceiverMail == session).ToList();
        //    return values;
        //}

        //public List<ContactMessage> GetTrashList()
        //{
        //    var context = new Context();
        //    var values = context.Messages.Where(x => x.IsTrash == true).ToList();
        //    return values;
        //}

        //public List<ContactMessage> GetUnReadList(string session)
        //{
        //    var context = new Context();
        //    var values = context.Messages.Where(x => x.IsRead == false && x.ReceiverMail == session).ToList();
        //    return values;
        //}
        public List<ContactMessage> GetDraftList(string session)
        {
            throw new NotImplementedException();
        }

        public List<ContactMessage> GetImportantList(string session)
        {
            throw new NotImplementedException();
        }

        public List<ContactMessage> GetInboxList(string session)
        {
            throw new NotImplementedException();
        }

        public List<ContactMessage> GetReadList(string session)
        {
            throw new NotImplementedException();
        }

        public List<ContactMessage> GetSendboxList(string session)
        {
            throw new NotImplementedException();
        }

        public List<ContactMessage> GetSpamList(string session)
        {
            throw new NotImplementedException();
        }

        public List<ContactMessage> GetTrashList()
        {
            throw new NotImplementedException();
        }

        public List<ContactMessage> GetUnReadList(string session)
        {
            throw new NotImplementedException();
        }
    }
}