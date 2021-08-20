using Inventory.Application.Contract;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpPost]
        public bool Define(DefineInventory command)
        {
            return _inventoryService.Define(command);
        }
    }
}