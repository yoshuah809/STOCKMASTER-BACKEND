using Microsoft.EntityFrameworkCore;



namespace STOCKMASTER.DB
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
                 .HasOne(p => p.Category);
               
        }
    }
}
