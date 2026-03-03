using DotNet_API_20_.Models;

namespace DotNet_API_20_.Service
{
    public class ProductService (HttpClient httpClient): IProductService
    {
        public async Task<List<Product>> GetProducts()
        {
            var product = await httpClient.GetFromJsonAsync<List<Product>>("http://192.168.0.2:5099/api/products");

            if (product is null)
                return null;

            return product;
        }
    }
}
