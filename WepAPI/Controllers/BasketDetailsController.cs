using Business.Abstract;
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
    public class BasketDetailsController : ControllerBase
    {
        IBasketDetailService _basketDetailService;

        public BasketDetailsController(IBasketDetailService basketDetailService)
        {
            _basketDetailService = basketDetailService;
        }


        [HttpGet("getallbasketdetail")]
        public IActionResult GetDetails(int userId)
        {

            var result = _basketDetailService.GetAllBasket(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
