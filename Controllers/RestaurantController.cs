using EightToTenEndpoints.Services.Restaurant;
using Microsoft.AspNetCore.Mvc;

namespace EightToTenEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantController : ControllerBase
{
    private readonly IRestaurantService _restaurantService;

    public RestaurantController(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }
    
    [HttpGet]
    [Route("ChoosePizzaSushiOrBurgers/{category}")]
    public string Choose(string category)
    {
        return _restaurantService.Choose(category);
    }
}
