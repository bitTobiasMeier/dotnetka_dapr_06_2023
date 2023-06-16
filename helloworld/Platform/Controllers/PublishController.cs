using Dapr.Client;
using Microsoft.AspNetCore.Mvc;

namespace Platform.Controllers;

[ApiController]
[Route("[controller]")]
public class PublishController : ControllerBase
{
    private readonly ILogger<PublishController> _logger;
    public PublishController(ILogger<PublishController> logger)
    {        _logger = logger;    }

    [HttpGet(Name = "Publish")]
    public async Task PublishEvent(int orderId)
    {
        using var client = new DaprClientBuilder().Build();
        await client.PublishEventAsync("pubsub", "orders", orderId);
        this._logger.LogInformation(message: "Published data: {OrderId}", orderId);
        Console.WriteLine("Published data: " + orderId);
    }
}