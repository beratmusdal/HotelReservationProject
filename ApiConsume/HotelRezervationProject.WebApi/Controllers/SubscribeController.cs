﻿using HotelReservationProject.BusinessLayer.Abstract;
using HotelReservationProject.EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservationProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _SubscribeService;
        public SubscribeController(ISubscribeService SubscribeService)
        {
            _SubscribeService = SubscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _SubscribeService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe Subscribe)
        {
            _SubscribeService.TInsert(Subscribe);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _SubscribeService.TGetByID(id);
            _SubscribeService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe Subscribe)
        {
            _SubscribeService.TUpdate(Subscribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var values = _SubscribeService.TGetByID(id);
            return Ok(values);
        }
    }
}
