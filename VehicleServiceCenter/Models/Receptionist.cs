namespace VehicleServiceCenter.Models
{
    public class Receptionist : User
    {
        public string ShiftTime { get; set; }

        public Receptionist()
        {
            this.UserType = "Receptionist";
        }

        public Receptionist(string shiftTime)
        {
            this.ShiftTime = shiftTime;
            this.UserType = "Receptionist";
        }
    }
}
