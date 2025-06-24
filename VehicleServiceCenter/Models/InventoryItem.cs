namespace VehicleServiceCenter.Models
{
    public class InventoryItem
    {
        public int InventoryItemID { get; set; }
        public string ItemName { get; set; }
        public int RemainingNumber { get; set; }
        public decimal Price { get; set; }

        public InventoryItem()
        {

        }

        public InventoryItem(string itemName, int remaining, decimal price)
        {
            this.ItemName = itemName;
            this.RemainingNumber = remaining;
            this.Price = price;
        }
    }
}
