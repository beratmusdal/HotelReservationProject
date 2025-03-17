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
    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUsDal _AboutUsDal;

        public AboutUsManager(IAboutUsDal AboutUsDal)
        {
            _AboutUsDal = AboutUsDal;
        }

        public void TDelete(AboutUs t)
        {
            _AboutUsDal.Delete(t);
        }

        public AboutUs TGetById(int id)
        {
            return _AboutUsDal.GetById(id);
        }

        public AboutUs TGetByID(int id)
        {
            return _AboutUsDal.GetById(id);
        }

        public List<AboutUs> TGetList()
        {
            return _AboutUsDal.GetList();
        }

        public void TInsert(AboutUs t)
        {
            _AboutUsDal.Insert(t);
        }

        public void TUpdate(AboutUs t)
        {
            _AboutUsDal.Update(t);
        }
    }
}
