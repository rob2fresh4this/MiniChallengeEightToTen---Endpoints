using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen___Endpoints.Service;

namespace MiniChallengeEightToTen___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        readonly RestaurantPickerService _restaurantPickerService;
        public RestaurantPickerController(RestaurantPickerService restaurantPickerService)
        {
            _restaurantPickerService = restaurantPickerService;
        }

        [HttpGet]
        [Route("pickRestaurant/{categoryMexicanChineseJapanese}")]
        public string GetResponse(string categoryMexicanChineseJapanese)
        {
            return _restaurantPickerService.PickedRestaurant(categoryMexicanChineseJapanese);
        }
    }
}