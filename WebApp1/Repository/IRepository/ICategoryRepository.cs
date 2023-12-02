using WebApp1.Models;

namespace WebApp1.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category entity);
    }
}
