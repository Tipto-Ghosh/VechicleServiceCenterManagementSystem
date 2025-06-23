namespace VehicleServiceCenter.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public int CustomerID { get; set; }
        public string LicensePlate { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(int customerId, string licensePlate, string model)
        {
            this.CustomerID = customerId;
            this.LicensePlate = licensePlate;
            this.Model = model;
        }
    }
}
