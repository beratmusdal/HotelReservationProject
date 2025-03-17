using AutoMapper;
using HotelReservationProject.DtoLayer.AboutUsDto;
using HotelReservationProject.DtoLayer.RoomDto;
using HotelReservationProject.EntitiyLayer.Concrete;

namespace HotelReservationProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();

            CreateMap<AboutUs, ResultAboutUsDto>().ReverseMap();
            CreateMap<AboutUs, UpdateAboutUsDto>().ReverseMap();
        }
    }
}
