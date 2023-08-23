using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project_with_dotnet.Models;

namespace project_with_dotnet.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController: ControllerBase {
        public List<Product> products = new List<Product>();

        [HttpGet]
        public IActionResult GetAll () {
            return Ok(products);
        }

        [HttpPost]
        public IActionResult Create(ProductVM productVM) {
            Product product = new Product() {
                ProductId = Guid.NewGuid(),
                Name = productVM.Name,
                Price = productVM.Price
            };
            products.Add(product);
            return Ok(product);
        }
    }
}
