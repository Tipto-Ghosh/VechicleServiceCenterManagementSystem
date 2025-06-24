namespace VehicleServiceCenter.Models
{
    public class Receptionist : User
    {
        public string ShiftTime { get; set; }

        public Receptionist()
        {

        }

        public Receptionist(string shiftTime)
        {
            this.ShiftTime = shiftTime;
        }
    }
}
