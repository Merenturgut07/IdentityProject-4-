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
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }


        public Notification TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> TGetListAll()
        {
            return _notificationDal.GetListAll();
        }



        public void TInsert(Notification entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Notification entity)
        {
            throw new NotImplementedException();
        }
    }
}
