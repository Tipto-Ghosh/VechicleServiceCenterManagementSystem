namespace VehicleServiceCenter.Models
{
    public class Mechanic : User
    {
        public float Rating { get; set; }
        public string Status { get; set; }  // Available, Busy

        public Mechanic()
        {
            this.UserType = "Mechanic";

        }

        public Mechanic(float rating, string status)
        {
            this.Rating = rating;
            this.Status = status;
        }
    }
}
