using HotelReservationProject.BusinessLayer.Abstract;
using HotelReservationProject.EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservationProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService _AboutUsService;
        public AboutUsController(IAboutUsService AboutUsService)
        {
            _AboutUsService = AboutUsService;
        }

        [HttpGet]
        public IActionResult AboutUsList()
        {
            var values = _AboutUsService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAboutUs(AboutUs AboutUs)
        {
            _AboutUsService.TInsert(AboutUs);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAboutUs(int id)
        {
            var values = _AboutUsService.TGetByID(id);
            _AboutUsService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAboutUs(AboutUs AboutUs)
        {
            _AboutUsService.TUpdate(AboutUs);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutUs(int id)
        {
            var values = _AboutUsService.TGetByID(id);
            return Ok(values);
        }
    }
}
