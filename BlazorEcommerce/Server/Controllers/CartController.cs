using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorEcommerce.Server.Services.CartService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartservice;

        public CartController(ICartService cartService)
        {
            _cartservice = cartService;
        }

        [HttpPost("products")]
        public async Task<ActionResult<ServiceResponse<List<CartProductResponse>>>> GetCartProducts(List<CartItem> cartItems)
        {
            var result = await _cartservice.GetCartProducts(cartItems);
            return Ok(result);
        }
    }
}
