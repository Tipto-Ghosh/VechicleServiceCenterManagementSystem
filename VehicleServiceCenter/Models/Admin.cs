namespace VehicleServiceCenter.Models
{
    public class Admin : User
    {
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }

        public Admin()
        {

        }

        public Admin(string type, DateTime createdDate)
        {
            this.Type = type;
            this.CreatedDate = createdDate;
        }
    }
}
