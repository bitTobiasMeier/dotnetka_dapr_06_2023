using Microsoft.AspNetCore.Mvc;
using RestaurantService.Contracts;

namespace RestaurantService.Controllers;

[ApiController]
[Route("[controller]")]
public class MenuController : ControllerBase
{
    private readonly ILogger<MenuController> _logger;

    public MenuController(ILogger<MenuController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{restaurantId}")]
    public IEnumerable<Dish> GetAsync(int restaurantId)
    {
        return new List<Dish>()
        {
            new Dish() { Id = 1, Title = "Wolfsbarsch", Price = 15.25m },
            new Dish() { Id = 1, Title = "Warmer Kirschkuchen", Price = 8.73m },
        };
    }


}