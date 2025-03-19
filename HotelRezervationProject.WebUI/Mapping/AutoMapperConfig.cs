using AutoMapper;
using HotelReservationProject.DtoLayer.AboutUsDto;
using HotelReservationProject.EntitiyLayer.Concrete;
using HotelReservationProject.WebUI.Dtos.BookingDto;
using HotelReservationProject.WebUI.Dtos.GuestDto;
using HotelReservationProject.WebUI.Dtos.LoginDto;
using HotelReservationProject.WebUI.Dtos.RegisterDto;
using HotelReservationProject.WebUI.Dtos.ServiceDto;
using HotelReservationProject.WebUI.Dtos.TeamsDto;
using HotelReservationProject.WebUI.Dtos.TestimonialDto;

namespace HotelReservationProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutUsDto, AboutUs>().ReverseMap();
            CreateMap<UpdateAboutUsDto, AboutUs>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultTeamDto, Staff>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();

            CreateMap<ResultGuestDto, Guest>().ReverseMap();
            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();



        }
    }
}
