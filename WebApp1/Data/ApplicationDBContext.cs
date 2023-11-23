using Microsoft.EntityFrameworkCore;

namespace WebApp1.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }
    }
}
