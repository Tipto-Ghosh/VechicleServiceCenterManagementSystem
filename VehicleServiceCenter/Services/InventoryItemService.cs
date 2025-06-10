using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter.Services {
    public class InventoryItemService {
        private InventoryItemRepository inventoryItemRepo;

        public InventoryItemService() {
            this.inventoryItemRepo = new InventoryItemRepository();
        }

        public InventoryItem GetItemById(int itemId) {
            return inventoryItemRepo.GetInventoryItemById(itemId);
        }

        public List<InventoryItem> GetAllItems() {
            return inventoryItemRepo.GetAllItems();
        }

        public List<InventoryItem> GetLowStockItems(int count) {
            return inventoryItemRepo.GetLowStockItems(count);
        }
    }
}