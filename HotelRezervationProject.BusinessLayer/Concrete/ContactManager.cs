using HotelReservationProject.BusinessLayer.Abstract;
using HotelReservationProject.DataAccessLayer.Abstract;
using HotelReservationProject.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _ContactDal;

        public ContactManager(IContactDal ContactDal)
        {
            _ContactDal = ContactDal;
        }
        public void TDelete(Contact t)
        {
            _ContactDal.Delete(t);
        }

        public Contact TGetById(int id)
        {
            return _ContactDal.GetById(id);
        }

        public Contact TGetByID(int id)
        {
            return _ContactDal.GetById(id);
        }

        public List<Contact> TGetList()
        {
            return _ContactDal.GetList();
        }

        public void TInsert(Contact t)
        {
            _ContactDal.Insert(t);
        }
        public void TUpdate(Contact t)
        {
            _ContactDal.Update(t);
        }
    }
}
