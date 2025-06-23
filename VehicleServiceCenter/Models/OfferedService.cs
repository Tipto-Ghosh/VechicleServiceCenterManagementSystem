namespace VehicleServiceCenter.Models
{
    public class OfferedService
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int EstimatedDurationMinutes { get; set; }

        public OfferedService()
        {

        }

        public OfferedService(string name, string description, decimal price, int duration)
        {
            this.ServiceName = name;
            this.Description = description;
            this.Price = price;
            this.EstimatedDurationMinutes = duration;
        }
    }
}
