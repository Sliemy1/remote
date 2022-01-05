using Amtech.Models;

namespace Amtech.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
      
    }
}
