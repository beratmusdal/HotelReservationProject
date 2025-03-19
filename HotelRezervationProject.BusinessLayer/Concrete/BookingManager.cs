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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _BookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _BookingDal = bookingDal;
        }

      

        public void TDelete(Booking t)
        {
            _BookingDal.Delete(t);
        }

        public Booking TGetById(int id)
        {
            return _BookingDal.GetById(id);
        }

        public Booking TGetByID(int id)
        {
            return _BookingDal.GetById(id);
        }

        public List<Booking> TGetList()
        {
            return _BookingDal.GetList();
        }

        public void TInsert(Booking t)
        {
            _BookingDal.Insert(t);
        }

        public void TUpdate(Booking t)
        {
            _BookingDal.Update(t);
        }
    }
}
