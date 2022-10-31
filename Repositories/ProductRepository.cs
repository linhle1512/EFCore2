using EFcore.Models;

namespace EFcore.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductStoreContext context) : base(context)
        {
        }
    }
}