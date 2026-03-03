using DotNet_API_20_.Models;
using DotNet_API_20_.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_API_20_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductService product) : ControllerBase
    {
        [HttpGet("GetAllProducts")]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var products = await product.GetProducts();

            if(products is null || products.Count == 0)
            {
                return NotFound("No products found.");
            }
            return Ok(products);
        }

    }
}
