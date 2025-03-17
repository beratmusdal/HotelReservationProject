using HotelReservationProject.BusinessLayer.Abstract;
using HotelReservationProject.DataAccessLayer.Abstract;
using HotelReservationProject.DataAccessLayer.EntityFramework;
using HotelReservationProject.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationProject.BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _SubscribeDal;

        public SubscribeManager(ISubscribeDal SubscribeDal)
        {
            _SubscribeDal = SubscribeDal;
        }

        public void TDelete(Subscribe t)
        {
            _SubscribeDal.Delete(t);
        }

        public Subscribe TGetById(int id)
        {
            return _SubscribeDal.GetById(id);
        }

        public Subscribe TGetByID(int id)
        {
            return _SubscribeDal.GetById(id);
        }

        public List<Subscribe> TGetList()
        {
            return _SubscribeDal.GetList();
        }

        public void TInsert(Subscribe t)
        {
            _SubscribeDal.Insert(t);
        }

        public void TUpdate(Subscribe t)
        {
            _SubscribeDal.Update(t);
        }
    }
}
