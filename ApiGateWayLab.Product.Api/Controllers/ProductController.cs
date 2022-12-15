using Microsoft.AspNetCore.Mvc;

namespace ApiGateWayLab.Product.Api.Controllers
{
    [ApiController]
    [Route("api/products/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            List<Product> products = GeTestData();
            return products;
        }

        private static List<Product> GeTestData()
        {
            List<Product> products = new List<Product>();
            for (int i = 1; i <= 100; i++)
            {
                Product product = new Product
                {
                    Id = i,
                    Name = "Product " + i,
                    Price = (i * 10)
                };
                products.Add(product);
            }

            return products;
        }

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
    }
}