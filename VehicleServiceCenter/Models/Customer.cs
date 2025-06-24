namespace VehicleServiceCenter.Models
{
    public class Customer : User
    {

        public string PhoneNumber { get; set; }

        public Customer() { 
            this.UserType = "customer";
        }

        public Customer(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }
    }
}
