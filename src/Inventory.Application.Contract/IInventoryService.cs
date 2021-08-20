namespace Inventory.Application.Contract
{
    public interface IInventoryService
    {
        bool Define(DefineInventory command);
    }
}
