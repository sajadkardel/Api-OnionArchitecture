namespace Inventory.Domain.Tests.Unit.Builders
{
    public class InventoryTestBuilder
    {
        private string _product = "Iphone";
        private double _unitPrice = 1100;

        public InventoryTestBuilder WithProduct(string product)
        {
            _product = product;
            return this;
        }

        public InventoryTestBuilder WithUnitPrice(double unitPrice)
        {
            _unitPrice = unitPrice;
            return this;
        }

        public _Inventory.Entites.Inventory Build()
        {
            return new _Inventory.Entites.Inventory(_product, _unitPrice);
        }
    }
}