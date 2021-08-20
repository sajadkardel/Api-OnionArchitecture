using Inventory.Application.Contract;
using Inventory.Domain;
using Inventory.Domain._Inventory.Services;

namespace Inventory.Application
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public bool Define(DefineInventory command)
        {
            var inventory = new Domain._Inventory.Entites.Inventory(command.Product, command.UnitPrice);

            _inventoryRepository.Create(inventory);

            return true;
        }
    }
}