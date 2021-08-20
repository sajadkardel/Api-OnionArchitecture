using Inventory.Domain._Inventory.Exeptions;

namespace Inventory.Domain._Inventory.Entites
{
    public class Inventory
    {
        public int Id { get; private set; }
        public string Product { get; private set; }
        public double UnitPrice { get; private set; }
        public bool InStock { get; private set; }

        public Inventory(string product, double unitPrice)
        {
            GuardAgainstInvalidProduct(product);
            GuardAgainstInvalidUnitPrice(unitPrice);

            Product = product;
            UnitPrice = unitPrice;
        }

        private static void GuardAgainstInvalidUnitPrice(double unitPrice)
        {
            if (unitPrice <= 0)
                throw new InvalidUnitPriceException();
        }

        private static void GuardAgainstInvalidProduct(string product)
        {
            if (string.IsNullOrWhiteSpace(product))
                throw new ProductNullException();
        }
    }
}