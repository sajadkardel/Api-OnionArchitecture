namespace Inventory.Domain._Inventory.Services
{
    public interface IInventoryRepository
    {
        void Create(Entites.Inventory entity);
        void Save();
    }
}
