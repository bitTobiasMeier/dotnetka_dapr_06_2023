using Dapr.Client;
using Microsoft.AspNetCore.Mvc;
using RestaurantService.Contracts;

namespace Platform.Controllers;

[ApiController]
[Route("[controller]")]
public class PlatformController : ControllerBase
{

    private readonly ILogger<PlatformController> _logger;

    public PlatformController(ILogger<PlatformController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<Dish>> GetAllAsync()
    {
        using var client = new DaprClientBuilder().Build();
        var menuentries = await client.InvokeMethodAsync<IEnumerable<Dish>>(HttpMethod.Get,  "restaurantservice", "menu/1").ConfigureAwait(true);
        return menuentries;
    }
}