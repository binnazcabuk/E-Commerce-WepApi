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
    public class BasketsController : ControllerBase
    {

        IBasketService _basketService;
     
        public BasketsController(IBasketService basketService)
        {
            _basketService = basketService;
            
        }
        [HttpPost("add")]
        public IActionResult Add(int userId, int productId, int quantity)
        {
            var result = _basketService.Add(userId,productId,quantity);
            if (result.Success == true)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        
        
       
    }
}
