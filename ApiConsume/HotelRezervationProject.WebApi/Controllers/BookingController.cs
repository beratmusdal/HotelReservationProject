
using HotelReservationProject.BusinessLayer.Abstract;
using HotelReservationProject.EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservationProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _BookingService;

        public BookingController(IBookingService bookingService)
        {
            _BookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _BookingService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking Booking)
        {
            _BookingService.TInsert(Booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _BookingService.TGetByID(id);
            _BookingService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(Booking Booking)
        {
            _BookingService.TUpdate(Booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _BookingService.TGetByID(id);
            return Ok(values);
        }
    }
}
