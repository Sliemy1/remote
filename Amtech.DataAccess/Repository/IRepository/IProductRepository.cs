using Amtech.Models;

namespace Amtech.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
      
    }
}
