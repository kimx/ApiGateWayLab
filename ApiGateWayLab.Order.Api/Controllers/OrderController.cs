using Microsoft.AspNetCore.Mvc;

namespace ApiGateWayLab.Order.Api.Controllers
{
    [ApiController]
    [Route("api/orders/[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<Order> Get()
        {
            List<Order> orders = GetTestData();
            return orders;
        }

        private static List<Order> GetTestData()
        {
            var orders = new List<Order>();
            // use a loop to create 100 orders
            for (int i = 0; i < 100; i++)
            {
                // create a new order and set its properties
                var order = new Order
                {
                    Id = i,
                    ProductId = i,
                    Total = (decimal)(i * 10.5),
                    Date = DateTime.Now
                };

                // add the order to the list
                orders.Add(order);
            }

            return orders;
        }

        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }
    }
}