namespace VehicleServiceCenter.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }


        public User()
        {

        }

        public User(string name, string gender, string password, DateTime dob, string bloodGroup,
            string email, string userType)
        {

            this.Name = name;
            this.Gender = gender;
            this.Password = password;
            this.DateOfBirth = dob;
            this.BloodGroup = bloodGroup;
            this.Email = email;
            this.UserType = userType;
        }
    }
}
