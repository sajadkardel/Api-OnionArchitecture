using System;
using Inventory.Domain;
using Inventory.Domain._Inventory.Services;

namespace Inventory.Infrastructure
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly InventoryContext _inventoryContext;

        public InventoryRepository(InventoryContext inventoryContext)
        {
            _inventoryContext = inventoryContext;
        }

        public void Create(Domain._Inventory.Entites.Inventory entity)
        {
            _inventoryContext.Inventory.Add(entity);
            Save();
        }

        public void Save()
        {
            _inventoryContext.SaveChanges();
        }
    }
}