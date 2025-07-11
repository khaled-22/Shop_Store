using Microsoft.EntityFrameworkCore;
using Shop_Store.Models;

namespace Shop_Store.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
  
            
        }
        public DbSet<Category> Categories { get; set; } // Creating a table Categories

        // Seeding data in the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Test",
                    DisplayOrder = 405

                }

                );
        }
    }
}
