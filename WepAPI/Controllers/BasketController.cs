using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {

        IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }
        [HttpPost("add")]
        public IActionResult Add(Basket basket)
        {
            var result = _basketService.Add(basket);
            if (result.Success == true)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbasketdetails")]
        public IActionResult GetCarDetails(int userId)
        {

            var result = _basketService.GetBasketDetailByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Basket basket)
        {
            var result = _basketService.Delete(basket);
            if (result.Success == true)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
