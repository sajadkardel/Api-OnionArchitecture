using FluentAssertions;
using Inventory.Application.Contract;
using Inventory.Domain._Inventory.Services;
using NSubstitute;
using Xunit;

namespace Inventory.Application.Tests.Unit
{
    public class InventoryServiceTests
    {
        private readonly InventoryService _inventoryApplication;
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryServiceTests()
        {
            _inventoryRepository = Substitute.For<IInventoryRepository>();
            _inventoryApplication = new InventoryService(_inventoryRepository);
        }

        [Fact]
        public void Should_ReturnTrue_WhenInventoryDefined()
        {
            var command = new DefineInventory {Product = "Iphone", UnitPrice = 1100};

            var result = _inventoryApplication.Define(command);

            result.Should().BeTrue();
        }

        [Fact]
        public void Should_DefineNewInventory()
        {
            var command = new DefineInventory {Product = "Iphone", UnitPrice = 1100};

            _inventoryApplication.Define(command);

            _inventoryRepository.ReceivedWithAnyArgs().Create(default);
        }
    }
}