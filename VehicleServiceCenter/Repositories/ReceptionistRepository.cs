using System.Data;
using System.Data.SqlClient;
using VehicleServiceCenter.Config;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter.Repositories
{
    public class ReceptionistRepository
    {
        private string connString = DbConfig.connectionString;

        public int InsertReceptionist(Receptionist receptionist)
        {
            try
            {
                UserRepository userRepo = new UserRepository();
                int newUserId = userRepo.InsertUser(receptionist);

                if (newUserId == 0 || newUserId == -1)
                {
                    return newUserId; // User insert failed or already exists
                }

                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"INSERT INTO Receptionists (UserID, ShiftTime)
                                     VALUES (@UserID, @Shift)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", newUserId);
                    cmd.Parameters.AddWithValue("@Shift", receptionist.ShiftTime ?? (object)DBNull.Value);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? newUserId : 0; // If success retun newId , if failed retun 0
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int UpdateReceptionist(Receptionist receptionist)
        {
            try
            {
                UserRepository userRepo = new UserRepository();
                int userUpdate = userRepo.UpdateUser(receptionist);
                if (userUpdate != 1) return 0;

                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = @"UPDATE Receptionists SET Shift = @ShiftTime
                                     WHERE UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Shift", receptionist.ShiftTime ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UserID", receptionist.UserID);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0 ? 1 : 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int DeleteReceptionist(int id)
        {
            try
            {
                UserRepository userRepo = new UserRepository();
                return userRepo.DeleteUser(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public DataTable GetAllReceptionistDetailsAsDataTable() {
            DataTable dt = new DataTable();

            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {
                    string query = "SELECT U.UserID, U.Name, U.Gender, U.DateOfBirth, U.BloodGroup, U.Email, U.UserType, R.Shift FROM Users U INNER JOIN Receptionists R ON U.UserID = R.UserID WHERE U.UserType = 'receptionist'";

                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) {
                            adapter.Fill(dt);
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("GetAllReceptionistDetailsAsDataTable Error: " + ex.Message);
            }

            return dt;
        }



        public int GetReceptionistCount() {
            int count = 0;


            try {
                using (SqlConnection conn = DbConfig.GetConnection()) {

                    string q = @"SELECT COUNT(*) FROM Users WHERE LOWER(UserType) = 'receptionist'";

                    using (SqlCommand cmd = new SqlCommand(q, conn)) {
                        conn.Open();
                        count = (int)cmd.ExecuteScalar();
                    }

                }
            } catch (Exception ex) {
                Console.WriteLine("GetCustomerCount Error " + ex.Message);
            }

            return count;
        }

    }
}
