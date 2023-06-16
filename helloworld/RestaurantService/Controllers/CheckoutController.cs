using Dapr;
using Dapr.Client;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantService.Controllers;

[ApiController]
[Route("[controller]")]
public class CheckoutController
{
    [Topic("pubsub", "orders")]
    [HttpPost("/checkout")]
    public ActionResult<int>Checkout([FromBody] int orderId, [FromServices] DaprClient daprClient)
    {
        return orderId;
    }
}