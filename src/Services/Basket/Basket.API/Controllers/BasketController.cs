using Microsoft.AspNetCore.Mvc;

namespace Basket.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BasketController : ControllerBase
    {
        public BasketController()
        {

        }

        [HttpGet]
        public IActionResult GetBasket()
        {

        }

        [HttpPost]
        public IActionResult UpdateBasket()
        {

        }

        [HttpDelete]
        public IActionResult DeleteBasket()
        {

        }

        [HttpPost]
        public IActionResult CreateCheckout()
        {

        }
    }
}
