using Identity.BussinessLayer.Abstract;
using Identity.DataAccessLayer.Abstract;
using Identity.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.BussinessLayer.Concrate
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }



        public List<Message> GetListReceiverMessage(string p)
        {

            return _messageDal.GetByFilter(x => x.Receiver == p);
        }

        public List<Message> GetListSenderMessage(string p)
        {
            return _messageDal.GetByFilter(x => x.Sender == p);
        }

        public void TDelete(int id)
        {
            _messageDal.Delete(id);
        }

        public Message TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> TGetListAll()
        {
            return _messageDal.GetListAll();
        }



        public void TInsert(Message entity)
        {
            _messageDal.Insert(entity);
        }

        public void TUpdate(Message entity)
        {
           _messageDal.Update(entity);
        }
    }
}
