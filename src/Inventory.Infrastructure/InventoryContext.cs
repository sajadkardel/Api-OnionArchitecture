using Microsoft.EntityFrameworkCore;

namespace Inventory.Infrastructure
{
    public class InventoryContext : DbContext
    {
        public DbSet<Domain._Inventory.Entites.Inventory> Inventory { get; set; }

        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InventoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}