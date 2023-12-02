using WebApp1.Models;

namespace WebApp1.Repository.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        void Update(Book entity);
    }
}
