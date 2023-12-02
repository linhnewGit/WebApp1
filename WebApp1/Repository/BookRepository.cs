using WebApp1.Data;
using WebApp1.Models;
using WebApp1.Repository.IRepository;

namespace WebApp1.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public BookRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
        }

        public void Update(Book entity)
        {
            _dbContext.Books.Update(entity);
        }
    }
}
