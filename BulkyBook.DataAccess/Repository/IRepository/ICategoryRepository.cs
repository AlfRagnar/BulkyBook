using BulkyBook.Models;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepositoryAsync<Category>
    {
        void Update(Category category);
    }
}