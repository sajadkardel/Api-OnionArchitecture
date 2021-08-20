using Inventory.Application.Contract;
using Inventory.Presentation.Controllers;
using NSubstitute;
using Xunit;
using Xunit.Categories;

namespace Inventory.Presentation.Tests.Unit
{
    public class InventoryControllerTests
    {
        private readonly InventoryController _controller;
        private readonly IInventoryService _inventoryService;

        public InventoryControllerTests()
        {
            _inventoryService = Substitute.For<IInventoryService>();
            _controller = new InventoryController(_inventoryService);
        }

        [Fact]
        [UnitTest]
        public void Should_CallDefineOnService()
        {
            var command = new DefineInventory {Product = "Iphone", UnitPrice = 1100};

            _controller.Define(command);

            _inventoryService.ReceivedWithAnyArgs().Define(default);
        }
    }
}