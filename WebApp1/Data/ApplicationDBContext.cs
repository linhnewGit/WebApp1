using Microsoft.EntityFrameworkCore;
using WebApp1.Models;

namespace WebApp1.Data
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Funny", Description= "SOS", DisplayOrder = 2 },
                new Category { Id=2, Name ="Horror", Description= "Hili", DisplayOrder= 3},
                new Category { Id=3, Name ="Roman", Description= "Cost", DisplayOrder=1},
                new Category { Id=4, Name ="Lmao", Description= "Hoel", DisplayOrder=4}
            );
        }
    }
}
