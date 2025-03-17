using HotelReservationProject.DataAccessLayer.Abstract;
using HotelReservationProject.DataAccessLayer.Concrete;
using HotelReservationProject.DataAccessLayer.Repositories;
using HotelReservationProject.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationProject.DataAccessLayer.EntityFramework
{
    public class EfAboutUsDal : GenericRepository<AboutUs>, IAboutUsDal
    {
        public EfAboutUsDal(Context context) : base(context)
        {
        }
    }
}
