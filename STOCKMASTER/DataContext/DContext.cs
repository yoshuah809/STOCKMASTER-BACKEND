using Microsoft.EntityFrameworkCore;
using STOCKMASTER.Models;


namespace STOCKMASTER.DataContext
{
    public class DContext : DbContext
    {
        public DContext(DbContextOptions<DContext> options )
            : base( options ) 
        {
            
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Product>()
                .HasOne<Category>(p => p.Category);
        }
    }
}
