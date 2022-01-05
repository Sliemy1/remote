using Amtech.Models;

namespace Amtech.DataAccess.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
      
    }
}
