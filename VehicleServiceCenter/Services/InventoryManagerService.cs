using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;


namespace VehicleServiceCenter.Services
{
    public class InventoryManagerService
    {
        private InventoryItemRepository inventoryItemRepo;

        public InventoryManagerService()
        {
            this.inventoryItemRepo = new InventoryItemRepository();
        }

        public int AddInventoryItem(InventoryItem item)
        {
            return inventoryItemRepo.InsertItem(item);
        }

        public int EditInventoryItem(InventoryItem item)
        {
            return inventoryItemRepo.UpdateItem(item);
        }

        public int DeleteInventoryItem(int itemId)
        {
            return inventoryItemRepo.DeleteItem(itemId);
        }

        public List<InventoryItem> GetLowStockItems(int count)
        {
            return inventoryItemRepo.GetLowStockItems(count);
        }
    }
}