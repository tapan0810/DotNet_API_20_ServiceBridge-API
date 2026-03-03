using DotNet_API_20_.Models;

namespace DotNet_API_20_.Service
{
    public class ProductService (HttpClient httpClient): IProductService
    {
        public async Task<List<Product>> GetProducts(int pageNumber,int pageSize)
        {
            var product = await httpClient.GetFromJsonAsync<List<Product>>("http://10.109.120.117:5099/api/products");

            if (product is null)
                return null;

            return product
                .Skip((pageNumber-1)* pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}
