using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Infrastructure
{
    public class InventoryMapping : IEntityTypeConfiguration<Domain._Inventory.Entites.Inventory>
    {
        public void Configure(EntityTypeBuilder<Domain._Inventory.Entites.Inventory> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}