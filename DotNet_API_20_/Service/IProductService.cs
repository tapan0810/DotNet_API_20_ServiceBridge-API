using DotNet_API_20_.Models;

namespace DotNet_API_20_.Service
{
    public interface IProductService
    {
        public Task<List<Product>> GetProducts();
    }
}
