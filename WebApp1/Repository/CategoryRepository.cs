using WebApp1.Data;
using WebApp1.Models;
using WebApp1.Repository.IRepository;

namespace WebApp1.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public CategoryRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
        }
        public void Update(Category entity)
        {
            _dbContext.Categories.Update(entity);
        }
    }
}
