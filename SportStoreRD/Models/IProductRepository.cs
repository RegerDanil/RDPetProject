using System.Linq;

namespace SportStoreRD.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        void SaveProduct(Product product);
        Product DeleteProduct(int ProductId);
    }
}
